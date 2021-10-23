using PBL4_Chat.BLL;
using PBL4_Chat.DTO;
using PBL4_Chat.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL4_Chat
{
    public partial class mainForm : Form
    {
        // format of chat private 
        // id_sender + id_receive + data ...
        // forrmat of chat group 
        // id_sender + id_group + id_sender + list_idMember + data ...

        // group_info(id_group + id_sender + list_idMember) -> mainForm.
        // user_info(id_receive) -> mainForm.

        // 
       
        private const int BUFFER_SIZE = 1024;
        private const int PORT_NUMBER = 9999;

        static ASCIIEncoding encoding = new ASCIIEncoding();
        TcpClient client = new TcpClient();
        Stream stream;
        // message 
        string data = null;
        // tên
        string name = null;
        // message thông qua userId
        string res = null;
        string nameReceiver = null;
        


        // chuyen userid cho mainForm
        public delegate string getUserId();
        public getUserId userId;

        // lấy dữ liệu từ user control receiver or list_member
        public delegate string getUserIdReveive();
        public getUserIdReveive userId_receive;

        // lấy id_group từ group_info
        public delegate string getIdMember();
        public getIdMember list_idMember;

        string id = "";
        public mainForm()
        {
            InitializeComponent();

        }

        // search user 
        private void btn_search_Click(object sender, EventArgs e)
        {
            panel_listUser.Controls.Clear();
            List<User> listUser = BLL_User.instance.BLL_getListUserByName(txt_search.Text);
            foreach (User u in listUser)
            {
                if (u.userId == userId())
                {
                    continue;
                }
                panel_listUser.Controls.Add(new user_info
                {
                    userId = u.userId,
                    name = u.firstName + " " + u.lastName,
                    phone = u.phone,
                });
            }
            List<Group> listGroup = BLL_Group.instance.BLL_getListGroupByName(txt_search.Text);
            foreach (Group g in listGroup)
            {
                if (userId() == g.userId)
                {
                    panel_listUser.Controls.Add(new group_info
                    {
                        id_group = g.id_group,
                        name_group = g.name_group,
                        des = g.des
                    });
                }
                else
                {
                    foreach (User_group ug in BLL_Group.instance.BLL_getAllUserGroup())
                    {
                        if (ug.id_member == userId())
                        {
                            panel_listUser.Controls.Add(new group_info
                            {
                                id_group = g.id_group,
                                name_group = g.name_group,
                                des = g.des
                            });
                            break;
                        }
                    }
                }
            }
        }
        
        // showDSUser có trong hệ thống
        public void showUser()
        {
            List<User> listUser = BLL_User.instance.BLL_getUser();
            foreach (User u in listUser)
            {
                if (u.userId == userId())
                {
                    continue;
                }
                panel_listUser.Controls.Add(new user_info
                {
                    userId = u.userId,
                    name = u.firstName + " " + u.lastName,
                    phone = u.phone,
                });
            }
        }
        // danh sách group trong hệ thống.
        public void showGroup()
        {
            List<Group> listGroup = BLL_Group.instance.BLL_getAllGroup();
            foreach (Group g in listGroup)
            {
                if (userId() == g.userId)
                {
                    panel_listUser.Controls.Add(new group_info
                    {
                        id_group = g.id_group,
                        name_group = g.name_group,
                        des = g.des
                    });
                }
                else
                {
                    foreach (User_group ug in BLL_Group.instance.BLL_getAllUserGroup())
                    {
                        if(ug.id_member == userId())
                        {
                            panel_listUser.Controls.Add(new group_info
                            {
                                id_group = g.id_group,
                                name_group = g.name_group,
                                des = g.des
                            });
                            break;
                        }    
                    }    
                }                    
            }
        }
        private void mainForm_Load(object sender, EventArgs e)
        {
            // 
            lbNamePerson.Text = BLL_User.instance.BLL_getUserById(userId()).firstName + " " + BLL_User.instance.BLL_getUserById(userId()).lastName;
            showUser();
            showGroup();
            pn_chat.Visible = false;
            try
            {
                data = "Conected to Chat Server ...";
                msg();
                // 1. connect
                client.Connect("127.0.0.1", PORT_NUMBER);
                stream = client.GetStream();

                // gửi userId mỗi khi load
                byte[] userId_load = encoding.GetBytes(userId());
                stream.Write(userId_load, 0, userId_load.Length);

                mainForm p = new mainForm();
                //Thread userThread1 = new Thread(new ThreadStart(() => p.XLNhan()));
                Thread userThread1 = new Thread(XLNhan);
                userThread1.Start();
                userThread1.IsBackground = true;
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex);
            }
        }

       
        public delegate void Delegate();
        //public void XLNhan(TcpClient client, Stream stream)

        // hàm xử lý nhận
        
        public void XLNhan()
        {
            try
            {
                while (true)
                {

                    stream = client.GetStream();
                    Byte[] message = new Byte[BUFFER_SIZE];
                    stream.Read(message, 0, BUFFER_SIZE);
                    data = encoding.GetString(message);
                    string data_copy = null;
                    for(int i = 0; i < data.Split(' ').Length; i++)
                    {

                    }    
                    res = null;
                    //MessageBox.Show(data);
                    //MessageBox.Show(data.Split(' ').Length.ToString());
                    //MessageBox.Show(data.Split(' ')[0]);
                    //MessageBox.Show(userId_receive());

                    // private(sender)
                    if (data.Split(' ')[1] == "private")
                    {
                        for (int i = 2; i < data.Split(' ').Length; i++)
                        {
                            res += data.Split(' ')[i] + " ";
                        }
                        // kiểm tra người nhận có đang nhắn private không
                        if (userId_receive().Split(' ').Length == 1)
                        {
                            nameReceiver = BLL_User.instance.BLL_getUserById(userId_receive()).firstName + " " + BLL_User.instance.BLL_getUserById(userId_receive()).lastName;
                            // khi người dùng đang nhắn 1 người khác nhưng 1 người khác gửi tin thì tin nhắn này không hiển thị lên
                            if (string.Compare(data.Split(' ')[0], userId_receive()) == 0)
                            {
                                msg();
                            }
                            else
                            {

                            }
                        }  
                        else
                        {

                        }                            
                        
                    }   
                    // group
                    else
                    {
                        //lấy message từ vị trí thứ 2
                        for (int i = 2; i < data.Split(' ').Length; i++)
                        {
                            res += data.Split(' ')[i] + " ";
                        }
                        //MessageBox.Show(res);
                        // kiểm tra người nhận xem có đang nhắn group không ?
                        if (userId_receive().Split(' ').Length > 1)
                        {
                            nameReceiver = BLL_User.instance.BLL_getUserById(data.Split(' ')[0]).firstName + " " + BLL_User.instance.BLL_getUserById(data.Split(' ')[0]).lastName;
                            // khi người dùng đang nhắn 1 người khác nhưng 1 người khác gửi tin thì tin nhắn này không hiển thị lên
                            // kiểm tra xem có đúng id_group không (chiều dài của user_receive)
                            if (string.Compare(data.Split(' ')[1], userId_receive().Split(' ')[0]) == 0)
                            {
                                msg();
                            }
                            else
                            {

                            }
                        }   
                        else
                        {

                        }                            
                    }                        
                    
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }

        }
        // hiển tin nhắn lên textbox
        private void msg()
        {
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(msg));
            else
            {
                txt_message.Text += Environment.NewLine + nameReceiver + " >> " + res;
            }           
        }


        private void btn_send_Click(object sender, EventArgs e)
        {
            if(txt_send.Text != "")
            {
                txt_message.Text += Environment.NewLine
                              + BLL_User.instance.BLL_getUserById(userId()).firstName
                              + " "
                              + BLL_User.instance.BLL_getUserById(userId()).lastName
                              + " << "
                              + txt_send.Text;
                //txt_message.Text += Environment.NewLine
                //                  + " << "
                //                  + txt_send.Text;
                // gửi userId_receive cho server
                byte[] userId_receive1 = encoding.GetBytes(userId() + " " + userId_receive());
                stream.Write(userId_receive1, 0, userId_receive1.Length);
                byte[] message = encoding.GetBytes(txt_send.Text);
                stream.Write(message, 0, message.Length);
                //add(encoding.GetString(message));
            }
            else
            {
                MessageBox.Show("bạn chưa nhập tin");
            }                
        }

        // hàm add 1 userRelation hoặc tin nhắn
        public void add(string content_mes)
        {
            try
            {
                string id_rel = Convert.ToString(Convert.ToInt32(BLL_UserRelation.instance.BLL_getIdRelMax()) + 1);
                string id_mes = Convert.ToString(Convert.ToInt32(BLL_UserRelation.instance.BLL_getIdMesMax()) + 1);
                string date_send = DateTime.Now.ToString();
                BLL_UserRelation.instance.BLL_addUserOrMes(id_rel, id_mes, userId(), userId_receive(), "friend", content_mes, date_send);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }
        // đăng xuất
        private void btnTrove_Click(object sender, EventArgs e)
        {
            BLL_User.instance.BLL_updateLogin(0, userId());
            //stream.Close();
            //client.Close();
            this.Hide();
            Register rg = new Register();
            rg.Show();

        }
        // đăng xuát
        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            BLL_User.instance.BLL_updateLogin(0, userId());
            //stream.Close();
            //client.Close();
            this.Hide();
            Register rg = new Register();
            rg.Show();
        }

        // hàm lấy userId
        string getUserIdCrea()
        {
            return userId();
        }
        // biến tạo 1 group trong 1 lần 
        static int index = 0;
        private void btn_taoNhom_Click(object sender, EventArgs e)
        {
            CreateGroup cg = new CreateGroup();
            cg.userId += new CreateGroup.getUserId(getUserIdCrea);
            if(index == 0)
            {
                cg.Show();
                index++;
            }    

            else
            {
                MessageBox.Show("Bạn đang mở tạo group");
                index--;
            }                
        }

        private void btn_chooseFile_Click(object sender, EventArgs e)
        {
            Opendialog.ShowDialog();
            string filename = Opendialog.FileName;
            string readFile = File.ReadAllText(filename);
            txt_message.Text += Environment.NewLine
                              + BLL_User.instance.BLL_getUserById(userId()).firstName
                              + " "
                              + BLL_User.instance.BLL_getUserById(userId()).lastName
                              + " << " + readFile;

            byte[] userId_receive1 = encoding.GetBytes(userId() + " " + userId_receive());
            stream.Write(userId_receive1, 0, userId_receive1.Length);
            byte[] message = encoding.GetBytes(readFile);
            stream.Write(message, 0, message.Length);
        }
    }
}
