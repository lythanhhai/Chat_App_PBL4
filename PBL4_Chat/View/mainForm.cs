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
        private const int BUFFER_SIZE = 1024;
        private const int PORT_NUMBER = 9999;

        static ASCIIEncoding encoding = new ASCIIEncoding();
        TcpClient client = new TcpClient();
        Stream stream;
        string data = null;
        string name = null;
        string res = null;
        string nameReceiver = null;


        // chuyen userid cho mainForm
        public delegate string getUserId();
        public getUserId userId;

        // lấy dữ liệu từ user control receiver
        public delegate string getUserIdReveive();
        public getUserIdReveive userId_receive;

        string id = "";
        public mainForm()
        {
            InitializeComponent();

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
        private void mainForm_Load(object sender, EventArgs e)
        {
            showUser();
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
                Console.WriteLine("Error: " + ex);
            }
        }

       
        public delegate void Delegate();
        //public void XLNhan(TcpClient client, Stream stream)

        // hàm xử lý nhận
        
        public void XLNhan()
        {
            
            while (true)
            {

                stream = client.GetStream();
                Byte[] message = new Byte[BUFFER_SIZE];
                stream.Read(message, 0, BUFFER_SIZE);
                data = encoding.GetString(message);

                res = null;
                for(int i = 1; i < data.Split(' ').Length ; i++)
                {
                    res += data.Split(' ')[i] + " ";
                }
                nameReceiver = BLL_User.instance.BLL_getUserById(userId_receive()).firstName + " " + BLL_User.instance.BLL_getUserById(userId_receive()).firstName;
                // khi người dùng đang nhắn 1 người khác nhưng 1 người khác gửi tin thì tin nhắn này không hiển thị lên
                if (string.Compare(data.Split(' ')[0], userId_receive()) == 0)
                {
                    msg();
                }
                else
                {

                }
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

            //txt_message.Text += Environment.NewLine
            //                  + BLL_User.instance.BLL_getUserById(userId()).firstName
            //                  + " "
            //                  + BLL_User.instance.BLL_getUserById(userId()).lastName
            //                  + " << "
            //                  + txt_send.Text;
            txt_message.Text += Environment.NewLine
                              + " << "
                              + txt_send.Text;
            
            // gửi userId_receive cho server
            byte[] userId_receive1 = encoding.GetBytes(userId() + " " + userId_receive());
            stream.Write(userId_receive1, 0, userId_receive1.Length);
            byte[] message = encoding.GetBytes(txt_send.Text);
            stream.Write(message, 0, message.Length);
            //add(encoding.GetString(message));
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
            this.Hide();
            Register rg = new Register();
            rg.Show();

        }
        // đăng xuát
        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            BLL_User.instance.BLL_updateLogin(0, userId());
            this.Hide();
            Register rg = new Register();
            rg.Show();
        }

    }
}
