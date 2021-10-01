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


        // chuyen userid cho mainForm
        public delegate string getUserId();
        public getUserId userId;

        public mainForm()
        {
            InitializeComponent();

        }

        // showDSUser có trong hệ thống
        public void showUser()
        {
            //List<Detail> listDetail = BLL_TKVX.Instance.getALLDetailSchedule_BLL(departure, arrival, date.Date);
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
            try
            {
                data = "Conected to Chat Server ...";
                msg();
                // 1. connect
                client.Connect("127.0.0.1", PORT_NUMBER);
                stream = client.GetStream();

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
        public void XLNhan()
        {
            
            while (true)
            {
                stream = client.GetStream();
                Byte[] a = new Byte[BUFFER_SIZE];
                stream.Read(a, 0, BUFFER_SIZE);
                data = encoding.GetString(a);
                //MessageBox.Show(data);
                msg();
            }

        }
        private void msg()
        {
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(msg));
            else
                txt_message.Text = txt_message.Text + Environment.NewLine + BLL_User.instance.BLL_getUserById(userId()).firstName + " " + BLL_User.instance.BLL_getUserById(userId()).lastName + " >> " + data;
        }


        private void btn_send_Click(object sender, EventArgs e)
        {

                //txt_message.Text += BLL_User.instance.BLL_getUserById(userId()).firstName 
                //                  + " "
                //                  + BLL_User.instance.BLL_getUserById(userId()).lastName 
                //                  + " << "
                //                  + txt_send.Text 
                //                  + Environment.NewLine;
                byte[] c = encoding.GetBytes(txt_send.Text);
                stream.Write(c, 0, c.Length);
                
        }

        
    }
}
