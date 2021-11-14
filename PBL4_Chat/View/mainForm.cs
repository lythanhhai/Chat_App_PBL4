using Bunifu.UI.WinForms;
using Guna.UI.WinForms;
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

        private const int BUFFER_SIZE = 1024 * 1000;
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

        //// gửi ảnh
        MemoryStream ms;
        NetworkStream ns;
        //BinaryWriter bw;


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
        private void mainForm_Load(object sender, EventArgs e)
        {
            // 
            lbNamePerson.Text = BLL_User.instance.BLL_getUserById(userId()).firstName + " " + BLL_User.instance.BLL_getUserById(userId()).lastName;
            showUser();
            showGroup();
            pn_chat.Visible = false;
            try
            {
                //data = "Conected to Chat Server ...";
                //msg();
                // 1. connect
                client.Connect("192.168.1.7", PORT_NUMBER);
                stream = client.GetStream();
                ns = client.GetStream();

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

        public string getUserIdForCam1()
        {
            return userId_receive();
        }

        public string getUserReceiveForCam1()
        {
            return userId();
        }

        // hàm xử lý nhận
        byte[] message;
        public void XLNhan()
        {
            try
            {
                while (true)
                {
                    ns = client.GetStream();
                    byte[] byte_choose = new Byte[BUFFER_SIZE];
                    ns.Read(byte_choose, 0, byte_choose.Length);
                    string choose = encoding.GetString(byte_choose);
                    //MessageBox.Show(encoding.GetString(choose));

                    //stream = client.GetStream();
                    //Byte[] message = new Byte[BUFFER_SIZE];
                    //stream.Read(message, 0, BUFFER_SIZE);
                    //data = encoding.GetString(message);
                    //string data_copy = null;

                    //for (int i = 0; i < data.Split(' ').Length; i++)
                    //{

                    //}

                    res = null;
                    if (userId_receive() == null)
                    {
                        break;
                    }
                    //MessageBox.Show(data);
                    //MessageBox.Show(data.Split(' ').Length.ToString());
                    //MessageBox.Show(data.Split(' ')[0]);
                    //MessageBox.Show(userId_receive());

                    // chat image
                    //MessageBox.Show(choose);
                    if (choose.Contains("Cam"))
                    {
                        if (choose.Split(' ')[1] == "private")
                        {
                            if (userId_receive().Split(' ').Length == 1)
                            {
                                if (string.Compare(choose.Split(' ')[0], userId_receive()) == 0)
                                {
                                    DialogResult dr = MessageBox.Show("Ban co cuoc goi",
                                    "Video call", MessageBoxButtons.YesNo);
                                    if (DialogResult.Yes == dr)
                                    {
                                        msgShow();
                                    }
                                    else
                                    {

                                    }
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
                    else if (choose.Contains("image"))
                    {
                        message = new Byte[BUFFER_SIZE];
                        ns.Read(message, 0, message.Length);
                        // private(sender)
                        if (choose.Split(' ')[1] == "private")
                        {
                            // kiểm tra người nhận có đang nhắn private không
                            if (userId_receive().Split(' ').Length == 1)
                            {
                                //nameReceiver = BLL_User.instance.BLL_getUserById(userId_receive()).firstName + " " + BLL_User.instance.BLL_getUserById(userId_receive()).lastName;
                                // khi người dùng đang nhắn 1 người khác nhưng 1 người khác gửi tin thì tin nhắn này không hiển thị lên
                                if (string.Compare(choose.Split(' ')[0], userId_receive()) == 0)
                                {
                                    msg1();
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
                            //MessageBox.Show("group");
                            //MessageBox.Show(res);
                            // kiểm tra người nhận xem có đang nhắn group không ?
                            if (userId_receive().Split(' ').Length - 1 > 1)
                            {
                                //nameReceiver = BLL_User.instance.BLL_getUserById(data.Split(' ')[0]).firstName + " " + BLL_User.instance.BLL_getUserById(data.Split(' ')[0]).lastName;
                                // khi người dùng đang nhắn 1 người khác nhưng 1 người khác gửi tin thì tin nhắn này không hiển thị lên
                                // kiểm tra xem có đúng id_group không (chiều dài của user_receive)
                                if (string.Compare(choose.Split(' ')[1], userId_receive().Split(' ')[0]) == 0)
                                {
                                    msg1();
                                }
                                else
                                {

                                }
                            }
                            else
                            {

                            }
                        }
                        //
                        //MessageBox.Show("a");
                        //message = new Byte[1024 * 500];
                        //ns.Read(message, 0, message.Length);
                        //msg1();
                        //MessageBox.Show("a");
                        //MessageBox.Show(data.Length.ToString());
                        //MessageBox.Show(data.Split(' ').Length.ToString());
                        //for (int i = 2; i < data.Split(' ').Length; i++)
                        //{
                        //    res += data.Split(' ')[i] + " ";
                        //}
                        //MessageBox.Show(res.Trim());
                        continue;
                    }
                    // gửi file
                    else if (choose.Contains("file"))
                    {
                        message = new Byte[BUFFER_SIZE];
                        ns.Read(message, 0, message.Length);
                        // private(sender)
                        if (choose.Split(' ')[1] == "private")
                        {
                            // kiểm tra người nhận có đang nhắn private không
                            if (userId_receive().Split(' ').Length == 1)
                            {
                                //nameReceiver = BLL_User.instance.BLL_getUserById(userId_receive()).firstName + " " + BLL_User.instance.BLL_getUserById(userId_receive()).lastName;
                                // khi người dùng đang nhắn 1 người khác nhưng 1 người khác gửi tin thì tin nhắn này không hiển thị lên
                                if (string.Compare(choose.Split(' ')[0], userId_receive()) == 0)
                                {
                                    msg2();
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
                            // kiểm tra người nhận xem có đang nhắn group không ?
                            if (userId_receive().Split(' ').Length - 1 > 1)
                            {
                                //nameReceiver = BLL_User.instance.BLL_getUserById(data.Split(' ')[0]).firstName + " " + BLL_User.instance.BLL_getUserById(data.Split(' ')[0]).lastName;
                                // khi người dùng đang nhắn 1 người khác nhưng 1 người khác gửi tin thì tin nhắn này không hiển thị lên
                                // kiểm tra xem có đúng id_group không (chiều dài của user_receive)
                                if (string.Compare(choose.Split(' ')[1], userId_receive().Split(' ')[0]) == 0)
                                {
                                    msg2();
                                }
                                else
                                {

                                }
                            }
                            else
                            {

                            }
                        }
                        continue;
                    }
                    // chat text
                    else
                    {
                        byte[] content = new Byte[BUFFER_SIZE];
                        ns.Read(content, 0, content.Length);
                        data = encoding.GetString(content);

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
                            if (userId_receive().Split(' ').Length - 1 > 1)
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


            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }

        }

        private void msgShow()
        {
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(msgShow));
            else
            {
                Cam cam1 = new Cam();
                cam1.userId += new Cam.getUserId(getUserIdForCam);
                cam1.userReceiver += new Cam.getUserReceive(getUserReceiveForCam);
                cam1.Show();

            }
        }

        // hiển tin nhắn lên textbox
        private void msg()
        {
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(msg));
            else
            {
                //txt_message1.Text += Environment.NewLine + nameReceiver + " >> " + res;
                //if (res != null)
                //{//quan trọng
                GunaTextBox gtb = new GunaTextBox();
                gtb.BaseColor = System.Drawing.Color.White;
                gtb.BorderColor = System.Drawing.Color.Silver;
                gtb.Cursor = System.Windows.Forms.Cursors.IBeam;
                gtb.FocusedBaseColor = System.Drawing.Color.White;
                gtb.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
                gtb.FocusedForeColor = System.Drawing.SystemColors.ControlText;
                gtb.Font = new System.Drawing.Font("Segoe UI", 9F);
                gtb.Location = new System.Drawing.Point(3, 3);
                gtb.MaximumSize = new System.Drawing.Size(270, 1000);
                gtb.MinimumSize = new System.Drawing.Size(270, 50);
                gtb.Multiline = true;
                gtb.PasswordChar = '\0';
                gtb.SelectedText = "";
                gtb.Size = new System.Drawing.Size(270, 50);
                gtb.TabIndex = 0;
                gtb.Text = res;
                gtb.Enabled = false;
                gtb.Radius = 20;
                gtb.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
                txt_message.Controls.Add(gtb);


                //ns = new NetworkStream(socket);

                //}

            }
        }
        // xử lý nhận luồng ảnh
        private void msg1()
        {
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(msg1));
            else
            {
                //txt_message1.Text += Environment.NewLine + nameReceiver + " >> " + res;
                //if (res != null)
                //{
                //MemoryStream imagestream = new MemoryStream(message);
                //Image image1 = Image.FromStream(imagestream);
                //////Bitmap bmp = new Bitmap(imagestream);
                //gunaTransfarantPictureBox1.Image = image1;
                //}
                MemoryStream imagestream1 = new MemoryStream(message);
                Image image2 = Image.FromStream(imagestream1);

                // panel
                BunifuPanel bp = new BunifuPanel();
                bp.BackgroundColor = System.Drawing.Color.Transparent;
                //bp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
                bp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                bp.BorderColor = System.Drawing.Color.Silver;
                bp.BorderRadius = 30;
                bp.BorderThickness = 1;
                bp.Location = new System.Drawing.Point(345, 3);
                bp.MaximumSize = new System.Drawing.Size(240, 260);
                bp.MinimumSize = new System.Drawing.Size(230, 160);
                bp.Margin = new System.Windows.Forms.Padding(10, 5, 3, 5);
                bp.ShowBorders = true;
                bp.Size = new System.Drawing.Size(230, 200);
                bp.TabIndex = 1;

                // thêm ảnh vào control
                GunaTransfarantPictureBox gpb = new GunaTransfarantPictureBox();
                //gpb.BaseColor = System.Drawing.Color.White;
                gpb.Location = new System.Drawing.Point(3, 3);
                gpb.MaximumSize = new System.Drawing.Size(230, 250);
                gpb.MinimumSize = new System.Drawing.Size(230, 160);
                gpb.Size = new System.Drawing.Size(230, 190);
                gpb.TabIndex = 0;
                gpb.TabStop = false;
                gpb.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
                gpb.Image = image2;

                bp.Controls.Add(gpb);
                txt_message.Controls.Add(bp);
            }
        }

        private void msg2()
        {
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(msg2));
            else
            {
                //txt_message1.Text += Environment.NewLine + nameReceiver + " >> " + encoding.GetString(message);
                int fileNameLen = BitConverter.ToInt32(message, 0);
                string fileName1 = Encoding.ASCII.GetString(message, 4, fileNameLen);
                MemoryStream filestream1 = new MemoryStream(message);

                //gunaTransfarantPictureBox1.Image = image2;
                // thêm ảnh vào control
                GunaLinkLabel gll = new GunaLinkLabel();
                gll.ActiveLinkColor = System.Drawing.Color.Silver;
                gll.AutoSize = true;
                gll.Font = new System.Drawing.Font("Segoe UI", 9F);
                gll.Location = new System.Drawing.Point(20, 10);
                gll.Size = new System.Drawing.Size(134, 25);
                gll.TabIndex = 0;
                gll.TabStop = true;
                gll.Margin = new System.Windows.Forms.Padding(10, 30, 3, 5);
                gll.Text = fileName1;
                gll.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
                gll.Click += new System.EventHandler(downloadFile);


                // panel
                BunifuPanel bp = new BunifuPanel();
                bp.BackgroundColor = System.Drawing.Color.Transparent;
                //bp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
                bp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                bp.BorderColor = System.Drawing.Color.Silver;
                bp.BorderRadius = 30;
                bp.BorderThickness = 1;
                bp.Location = new System.Drawing.Point(3, 3);
                bp.MaximumSize = new System.Drawing.Size(170, 40);
                bp.MinimumSize = new System.Drawing.Size(150, 40);
                bp.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
                bp.ShowBorders = true;
                bp.Size = new System.Drawing.Size(150, 40);
                bp.TabIndex = 1;

                bp.Controls.Add(gll);
                txt_message.Controls.Add(bp);


            }
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            if (txt_send.Text != "")
            {
                //txt_message1.Text += Environment.NewLine
                //              + BLL_User.instance.BLL_getUserById(userId()).firstName
                //              + " "
                //              + BLL_User.instance.BLL_getUserById(userId()).lastName
                //              + " << "
                //              + txt_send.Text;

                GunaTextBox gtb = new GunaTextBox();
                gtb.BaseColor = System.Drawing.Color.White;
                gtb.BorderColor = System.Drawing.Color.Silver;
                gtb.Cursor = System.Windows.Forms.Cursors.IBeam;
                gtb.FocusedBaseColor = System.Drawing.Color.White;
                gtb.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
                gtb.FocusedForeColor = System.Drawing.SystemColors.ControlText;
                gtb.Font = new System.Drawing.Font("Segoe UI", 9F);
                gtb.Location = new System.Drawing.Point(3, 3);
                gtb.MaximumSize = new System.Drawing.Size(270, 1000);
                gtb.MinimumSize = new System.Drawing.Size(270, 50);
                gtb.Multiline = true;
                gtb.PasswordChar = '\0';
                gtb.SelectedText = "";
                gtb.Size = new System.Drawing.Size(270, 50);
                gtb.TabIndex = 0;
                gtb.Text = txt_send.Text;
                gtb.Margin = new System.Windows.Forms.Padding(185, 5, 3, 5);
                gtb.Enabled = false;
                gtb.Radius = 20;
                txt_message.Controls.Add(gtb);
                //txt_message.Text += Environment.NewLine
                //                  + " << "
                //                  + txt_send.Text;
                // gửi userId_receive cho server
                ns = client.GetStream();
                //stream = client.GetStream();
                byte[] userId_receive1 = encoding.GetBytes(userId() + " " + userId_receive());
                ns.Write(userId_receive1, 0, userId_receive1.Length);
                byte[] message = encoding.GetBytes(txt_send.Text);
                ns.Write(message, 0, message.Length);
                txt_send.Text = "";
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
            cg.Show();
            //if(index == 0)
            //{
            //    cg.Show();
            //    index++;
            //}    

            //else
            //{
            //    MessageBox.Show("Bạn đang mở tạo group");
            //    index--;
            //}                
        }

        private void downloadFile(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "RichTextFile |*.rtf|Text file (*.txt)|*.txt|XML file (*.xml)|*.xml|All files (*.*)|*.*";
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.Title = "Where do you want to save the file?";
            saveFileDialog1.InitialDirectory = @"D:/";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show("You selected the file: " + saveFileDialog1.FileName);
                string saveFileName = saveFileDialog1.FileName;
                byte[] message1;
                if (message == null)
                {
                    message1 = new byte[1024 * 500];
                }
                else
                {
                    message1 = message;
                }
                File.WriteAllBytes(saveFileName, message1);
            }
            else
            {
                //MessageBox.Show("You hit cancel or closed the dialog.");
            }
            saveFileDialog1.Dispose();
            saveFileDialog1 = null;
        }

        private void btn_chooseFile_Click(object sender, EventArgs e)
        {
            try
            {
                Opendialog.Filter = "Files (*.txt;*.docx;*.xlsx;*.pdf;*.readme;)|*.txt;*.docx;*.xlsx;*.pdf;*.readme";
                //OpenFileDialog Opendialog = new OpenFileDialog();
                Opendialog.ShowDialog();
                string filename = Opendialog.FileName;

                // kiểm tra xem người dùng có chọn file không
                if (!String.IsNullOrEmpty(filename) != null && File.Exists(filename))
                {
                    string readFile = File.ReadAllText(filename);
                    //txt_send.Text = readFile;
                    //txt_message.Text += Environment.NewLine
                    //                  + BLL_User.instance.BLL_getUserById(userId()).firstName
                    //                  + " "
                    //                  + BLL_User.instance.BLL_getUserById(userId()).lastName
                    //                  + " << " + readFile;
                    string handleFileName = Path.GetFileName(filename);


                    // panel
                    BunifuPanel bp = new BunifuPanel();
                    bp.BackgroundColor = System.Drawing.Color.Transparent;
                    //bp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
                    bp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    bp.BorderColor = System.Drawing.Color.Silver;
                    bp.BorderRadius = 30;
                    bp.BorderThickness = 1;
                    bp.Location = new System.Drawing.Point(345, 3);
                    bp.MaximumSize = new System.Drawing.Size(170, 40);
                    bp.MinimumSize = new System.Drawing.Size(150, 40);
                    bp.Margin = new System.Windows.Forms.Padding(300, 5, 3, 5);
                    //bp.Padding = new System.Windows.Forms.Padding(20, 25, 0, 0);
                    bp.ShowBorders = true;
                    bp.Size = new System.Drawing.Size(150, 40);
                    bp.TabIndex = 1;

                    // gunalink

                    GunaLinkLabel gll = new GunaLinkLabel();
                    gll.ActiveLinkColor = System.Drawing.Color.Silver;
                    gll.AutoSize = true;
                    gll.Margin = new System.Windows.Forms.Padding(0);
                    gll.Font = new System.Drawing.Font("Segoe UI", 9F);
                    gll.Location = new System.Drawing.Point(20, 10);
                    gll.Size = new System.Drawing.Size(134, 25);
                    gll.TabIndex = 0;
                    gll.TabStop = true;
                    gll.Text = handleFileName;
                    gll.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
                    // sự kiện download
                    gll.Click += new System.EventHandler(downloadFile);


                    bp.Controls.Add(gll);
                    txt_message.Controls.Add(bp);


                    //FileStream stream = File.OpenRead(filename);
                    // byte[] fileBytes = new byte[stream.Length];

                    //ms = new MemoryStream();
                    //FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
                    //ms.CopyTo(fs);
                    ////File.WriteAllBytes(filename, ms.ToArray());
                    //byte[] buffer = ms.GetBuffer();

                    //ms = new MemoryStream();
                    //FileStream file1 = new FileStream(filename, FileMode.Open, FileAccess.Read);
                    //byte[] byte1s = new byte[file1.Length];
                    //file1.Read(byte1s, 0, (int)file1.Length);
                    //ms.Write(byte1s, 0, (int)file1.Length);

                    //byte[] buffer = ms.GetBuffer();

                    //FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
                    //ms = new MemoryStream();
                    //fs.CopyTo(ms);
                    //byte[] buffer = ms.GetBuffer();

                    //byte[] userId_receive1 = encoding.GetBytes(userId() + " " + userId_receive() + " " + "file");
                    //ns.Write(userId_receive1, 0, userId_receive1.Length);
                    //byte[] dataFile = File.ReadAllBytes(filename);
                    ////byte[] dataFile = FileToByteArray(filename);
                    //MessageBox.Show(encoding.GetString(buffer));
                    ////fs.Read(dataFile, 0, System.Convert.ToInt32(fs.Length));
                    //ns.Write(buffer, 0, buffer.Length);

                    ns = client.GetStream();
                    string file_name = Path.GetFileName(filename);

                    FileInfo fileInfo = new FileInfo(filename);
                    string file_path = fileInfo.DirectoryName + @"\";

                    byte[] fileNameByte = Encoding.ASCII.GetBytes(file_name);

                    byte[] fileData = File.ReadAllBytes(file_path + file_name);

                    byte[] mesData = new byte[4 + fileNameByte.Length + fileData.Length];

                    byte[] fileNameLen = BitConverter.GetBytes(fileNameByte.Length);


                    fileNameLen.CopyTo(mesData, 0);

                    fileNameByte.CopyTo(mesData, 4);

                    fileData.CopyTo(mesData, 4 + fileNameByte.Length);

                    byte[] userId_receive1 = encoding.GetBytes(userId() + " " + userId_receive() + " " + "file");
                    ns.Write(userId_receive1, 0, userId_receive1.Length);
                    ns.Write(mesData, 0, mesData.Length);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }

        }

        public static byte[] FileToByteArray(string fileName)
        {
            byte[] fileData = null;

            using (FileStream fs = File.OpenRead(fileName))
            {
                var binaryReader = new BinaryReader(fs);
                fileData = binaryReader.ReadBytes((int)fs.Length);
            }
            return fileData;
        }

        int demBam = 0;
        private void btn_message_Click(object sender, EventArgs e)
        {
            panel_listUser.Visible = true;
            //if(demBam == 0)
            //{
            //    demBam++;
            //}    
            //else
            //{
            //    panel_listUser.Visible = false;
            //    demBam--;
            //}                
        }

        private void btn_chooseImg_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog opnfd = new OpenFileDialog();
                opnfd.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.gif;)|*.jpg;*.jpeg;*.png;*.gif";
                if (opnfd.ShowDialog() == DialogResult.OK)
                {

                    // panel
                    BunifuPanel bp = new BunifuPanel();
                    bp.BackgroundColor = System.Drawing.Color.Transparent;
                    //bp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
                    bp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    bp.BorderColor = System.Drawing.Color.Silver;
                    bp.BorderRadius = 30;
                    bp.BorderThickness = 1;
                    bp.Location = new System.Drawing.Point(345, 3);
                    bp.MaximumSize = new System.Drawing.Size(240, 260);
                    bp.MinimumSize = new System.Drawing.Size(230, 160);
                    bp.Margin = new System.Windows.Forms.Padding(230, 5, 3, 5);
                    bp.ShowBorders = true;
                    bp.Size = new System.Drawing.Size(230, 200);
                    bp.TabIndex = 1;

                    // thêm ảnh vào control
                    GunaTransfarantPictureBox gpb = new GunaTransfarantPictureBox();
                    //gpb.BaseColor = System.Drawing.Color.White;
                    gpb.Location = new System.Drawing.Point(3, 3);
                    gpb.MaximumSize = new System.Drawing.Size(230, 250);
                    gpb.MinimumSize = new System.Drawing.Size(230, 160);
                    gpb.Size = new System.Drawing.Size(230, 190);
                    gpb.TabIndex = 0;
                    gpb.TabStop = false;
                    gpb.Margin = new System.Windows.Forms.Padding(220, 5, 2, 5);
                    gpb.Image = new Bitmap(opnfd.FileName);


                    bp.Controls.Add(gpb);
                    txt_message.Controls.Add(bp);




                    ms = new MemoryStream();
                    gpb.Image.Save(ms, gpb.Image.RawFormat);
                    byte[] buffer = ms.GetBuffer();
                    //ms.Close();

                    ns = client.GetStream();
                    byte[] userId_receive1 = encoding.GetBytes(userId() + " " + userId_receive() + " " + "image");
                    ns.Write(userId_receive1, 0, userId_receive1.Length);
                    ns.Write(buffer, 0, buffer.Length);
                    //ns.Close();


                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        public string getUserIdForCam()
        {
            return userId();
        }

        public string getUserReceiveForCam()
        {
            return userId_receive();
        }

        private void btnCamera_Click(object sender, EventArgs e)
        {
            Cam cam = new Cam();
            cam.userId += new Cam.getUserId(getUserIdForCam);
            cam.userReceiver += new Cam.getUserReceive(getUserReceiveForCam);
            ns = client.GetStream();
            byte[] userId_receive1 = encoding.GetBytes(userId() + " " + userId_receive() + " " + "Cam");
            ns.Write(userId_receive1, 0, userId_receive1.Length);
            cam.Show();
        }
    }
}
