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
using AForge.Video;
using AForge.Video.DirectShow;
using Guna.UI.WinForms;

namespace PBL4_Chat.View
{
    public partial class Cam : Form
    {
        public Cam()
        {
            InitializeComponent();
        }

        public delegate string getUserId();
        public getUserId userId;

        public delegate string getUserReceive();
        public getUserReceive userReceiver;


        private const int BUFFER_SIZE = 1024 * 1000;
        private const int PORT_NUMBER = 9999;

        static ASCIIEncoding encoding = new ASCIIEncoding();
        TcpClient client = new TcpClient();
        NetworkStream ns;

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;

        MemoryStream ms;
        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                ns = client.GetStream();
                //do
                //{

                    ms = new MemoryStream();
                    pbCamera.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] buffer = ms.GetBuffer();
                    byte[] userId_receive1 = encoding.GetBytes(userId() + " " + userReceiver());
                    ns.Write(userId_receive1, 0, userId_receive1.Length);
                    ns.Write(buffer, 0, buffer.Length);
                    //System.Timers.Timer MyTimer = new System.Timers.Timer();
                    //MyTimer.Interval = (500); // 0.5s
                    //MyTimer.Start();
                //}
                //while (videoCaptureDevice.IsRunning);
            }
            catch(Exception err)  
            {
                MessageBox.Show(err.ToString());
            }
        }

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

                    if (userReceiver() == null)
                    {
                        break;
                    }


                    // chat image
                    message = new Byte[BUFFER_SIZE];
                    ns.Read(message, 0, message.Length);
                    // private(sender)
                    MessageBox.Show("1");
                    MessageBox.Show(choose);
                    if (choose.Contains("private"))
                    {
                        MessageBox.Show("2");
                        // kiểm tra người nhận có đang nhắn private không
                        if (userReceiver().Split(' ').Length == 1)
                        {
                            MessageBox.Show("3");
                            //nameReceiver = BLL_User.instance.BLL_getUserById(userId_receive()).firstName + " " + BLL_User.instance.BLL_getUserById(userId_receive()).lastName;
                            // khi người dùng đang nhắn 1 người khác nhưng 1 người khác gửi tin thì tin nhắn này không hiển thị lên
                            if (string.Compare(choose.Split(' ')[0], userReceiver()) == 0)
                            {
                                MessageBox.Show("a");
                                msg();
                            }
                            else
                            {

                            }
                        }
                        else
                        {

                        }


                        continue;
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

                MemoryStream imagestream1 = new MemoryStream(message);
                Image image2 = Image.FromStream(imagestream1);
                pbCamera.Image = image2;

            }
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            pbCamera.Image = bitmap;
        }
        private void Cam_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo fi in filterInfoCollection)
            {
                cbbCamera.Items.Add(fi.Name);
                cbbCamera.SelectedIndex = 0;
                videoCaptureDevice = new VideoCaptureDevice();
            }
            try
            {
                videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cbbCamera.SelectedIndex].MonikerString);
                videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
                videoCaptureDevice.Start();
                client.Connect("127.0.0.1", PORT_NUMBER);
                ns = client.GetStream();

                // gửi userId mỗi khi load
                byte[] userId_load = encoding.GetBytes(userId() + " " + "Cam");
                ns.Write(userId_load, 0, userId_load.Length);

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

        private void btn_stop_Click(object sender, EventArgs e)
        {
            if(videoCaptureDevice.IsRunning)
            {
                videoCaptureDevice.Stop();
            }    
        }
    }
}
