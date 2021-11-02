using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

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
                videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cbbCamera.SelectedIndex].MonikerString);
                videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
                videoCaptureDevice.Start();

                

                ns = client.GetStream();
                do
                {
                    byte[] userId_receive1 = encoding.GetBytes(userId() + " " + "Cam");
                    ns.Write(userId_receive1, 0, userId_receive1.Length);
                    ms = new MemoryStream();
                    pbCamera.Image.Save(ms, pbCamera.Image.RawFormat);
                    byte[] buffer = ms.GetBuffer();
                    ns.Write(buffer, 0, buffer.Length);
                    Timer MyTimer = new Timer();
                    MyTimer.Interval = (500); // 0.5s
                    MyTimer.Start();
                }
                while (videoCaptureDevice.IsRunning);
            }
            catch(Exception err)  
            {
                MessageBox.Show(err.ToString());
            }
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pbCamera.Image = (Bitmap)eventArgs.Frame.Clone();
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
