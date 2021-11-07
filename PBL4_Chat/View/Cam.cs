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
using System.Timers;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using Guna.UI.WinForms;
using Timer = System.Timers.Timer;
using NAudio.Wave;

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

        // luồng
        Thread send;
        Thread receive;

        // stream voice
        WaveIn wave;
        WaveOut waveout;
        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (videoCaptureDevice.IsRunning == false)
                {
                    videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cbbCamera.SelectedIndex].MonikerString);
                    videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
                    videoCaptureDevice.Start();
                }
                    send = new Thread(xuLyGui);
                    send.IsBackground = true;
                    send.Start();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }
        private static readonly Object objLock = new object();
        void myTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            //your code

            bool isNullOrEmpty = pbCamera == null || pbCamera.Image == null;
            if (isNullOrEmpty == true)
            {

            }
            else
            {


                //Image image = (Image)pbCamera.Image.Clone();
                ns = client.GetStream();
                ms = new MemoryStream();
                Invoke((MethodInvoker)(delegate ()
                {
                    var image = pbCamera.Image;
                    image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                }));
                    //pbCamera.Image.Save(ms, pbCamera.Image.RawFormat);
                byte[] buffer = ms.GetBuffer();
                byte[] userId_receive1 = encoding.GetBytes(userId() + " " + userReceiver());
                ns.Write(userId_receive1, 0, userId_receive1.Length);
                ns.Write(buffer, 0, buffer.Length);


                //Thread.Sleep(1000);
                try
                {
                    //Task.Delay(10);
                }
                catch (Exception err)
                {

                }
                //i--;

            }


        }
        System.Timers.Timer myTimer = new Timer(250);
        public void xuLyGui()
        {
            try
            {

                myTimer.Start();
                myTimer.Elapsed += new ElapsedEventHandler(myTimer_Elapsed);
                Task.Delay(10);


                //while (true)
                //{

                //    bool isNullOrEmpty = pbCamera == null || pbCamera.Image == null;
                //    if (isNullOrEmpty == true)
                //    {

                //    }
                //    else
                //    {


                //        //Image image = (Image)pbCamera.Image.Clone();
                //        ns = client.GetStream();
                //        ms = new MemoryStream();
                //        pbCamera.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                //        byte[] buffer = ms.GetBuffer();
                //        byte[] userId_receive1 = encoding.GetBytes(userId() + " " + userReceiver());
                //        ns.Write(userId_receive1, 0, userId_receive1.Length);
                //        ns.Write(buffer, 0, buffer.Length);


                //        Thread.Sleep(500);
                //        try
                //        {
                //            //Task.Delay(10);
                //        }
                //        catch (Exception err)
                //        {

                //        }
                //        //i--;

                //    }
                //}    



            }
            catch (Exception err)
            {

            }
        }
        
        
        //int question = 0;
        byte[] message;
        byte[] messageVoice;
        // xử lý nhận
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
                    if(choose.Contains("Voice"))
                    {
                        //MessageBox.Show("1");
                        messageVoice = new Byte[BUFFER_SIZE];
                        ns.Read(messageVoice, 0, messageVoice.Length);
                        // private(sender)
                        if (choose.Contains("private"))
                        {
                            //MessageBox.Show("2");
                            // kiểm tra người nhận có đang nhắn private không
                            if (userReceiver().Split(' ').Length == 1)
                            {
                                //MessageBox.Show("3");
                                //nameReceiver = BLL_User.instance.BLL_getUserById(userId_receive()).firstName + " " + BLL_User.instance.BLL_getUserById(userId_receive()).lastName;
                                // khi người dùng đang nhắn 1 người khác nhưng 1 người khác gửi tin thì tin nhắn này không hiển thị lên
                                if (string.Compare(choose.Split(' ')[0], userReceiver()) == 0)
                                {
                                    //MessageBox.Show("4");
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
                    }   
                    else
                    {
                        message = new Byte[BUFFER_SIZE];
                        ns.Read(message, 0, message.Length);
                        // private(sender)
                        if (choose.Contains("private"))
                        {
                            // kiểm tra người nhận có đang nhắn private không
                            if (userReceiver().Split(' ').Length == 1)
                            {
                                //nameReceiver = BLL_User.instance.BLL_getUserById(userId_receive()).firstName + " " + BLL_User.instance.BLL_getUserById(userId_receive()).lastName;
                                // khi người dùng đang nhắn 1 người khác nhưng 1 người khác gửi tin thì tin nhắn này không hiển thị lên
                                if (string.Compare(choose.Split(' ')[0], userReceiver()) == 0)
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
        // xử lý nhận ảnh 
        private void msg()
        {
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(msg));
            else
            {

                MemoryStream imagestream1 = new MemoryStream(message);
                Image image2 = Image.FromStream(imagestream1);
                gunaTransfarantPictureBox1.Image = image2;

            }
        }
        // xử lý nhận voice
        private NAudio.Wave.BlockAlignReductionStream stream = null;

        private NAudio.Wave.DirectSoundOut output = null;
        private void msg1()
        {
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(msg1));
            else
            {

                //MessageBox.Show(encoding.GetString(messageVoice));
                DisposeWave();
                //1
                waveout = new WaveOut();
                IWaveProvider provider = new RawSourceWaveStream(new MemoryStream(messageVoice), new WaveFormat(16000, 16, 1));
                waveout.DeviceNumber = cbbPhone.SelectedIndex;
                waveout.Init(provider);
                waveout.Play();
                //2
                //byte[] b = WaveFileReader(@"D:\Class\ky2_2122\XL tín hiệu số\44.1khz.wav");

                //WaveStream wav = new RawSourceWaveStream(new MemoryStream(b), new WaveFormat(44100, 16, 2));
                //WaveOutEvent output = new WaveOutEvent();
                //output.Init(wav);
                //output.Play();
                //3
                //NAudio.Wave.WaveStream pcm = new NAudio.Wave.WaveChannel32(new NAudio.Wave.WaveFileReader(@"D:\Class\ky2_2122\XL tín hiệu số\44.1khz.wav"));
                //stream = new NAudio.Wave.BlockAlignReductionStream(pcm);
                //output = new NAudio.Wave.DirectSoundOut();
                //output.Init(stream);
                //output.Play();
            }
        }
        private void DisposeWave()
        {
            //if (waveout != null)
            //{
            //    if (waveout.PlaybackState == NAudio.Wave.PlaybackState.Playing) waveout.Stop();
            //    waveout.Dispose();
            //    waveout = null;
            //}
            
        }

        public delegate void SetImageCallback(Bitmap bmp);
        private void SetImage(Bitmap image)
        {
            if (pbCamera.InvokeRequired)
            {
                SetImageCallback callback = new SetImageCallback(SetImage);
                this.BeginInvoke(callback, new object[] { image });
            }
            else
            {
                pbCamera.Image = image;
            }
        }
        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            SetImage(bitmap);  
            //pbCamera.Image = bitmap;
        }
        
        private void Cam_Load(object sender, EventArgs e)
        {
            // load cbb camera
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo fi in filterInfoCollection)
            {
                cbbCamera.Items.Add(fi.Name);
                cbbCamera.SelectedIndex = 0;
                videoCaptureDevice = new VideoCaptureDevice();
            }
            // load mic
            for (int i = 0; i < WaveIn.DeviceCount; i++)
            {
                var device = WaveIn.GetCapabilities(i);
                cbbMic.Items.Add(device.ProductName);
                cbbMic.SelectedIndex = 0;
            }
            // load phone
            for (int i = 0; i < WaveOut.DeviceCount; i++)
            {
                var device = WaveOut.GetCapabilities(i);
                cbbPhone.Items.Add(device.ProductName);
                cbbPhone.SelectedIndex = 0;
            }
            try
            {

                client.Connect("127.0.0.1", PORT_NUMBER);
                ns = client.GetStream();

                // gửi userId mỗi khi load
                byte[] userId_load = encoding.GetBytes(userId() + " " + "Cam");
                ns.Write(userId_load, 0, userId_load.Length);

                //Thread userThread1 = new Thread(new ThreadStart(() => p.XLNhan()));
                receive = new Thread(XLNhan);
                receive.IsBackground = true;
                receive.Start();

            }

            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            if (videoCaptureDevice.IsRunning)
            {
                myTimer.Stop();
                videoCaptureDevice.Stop();
            }
        }

        // record
        byte[] bufferVoice;
        int size_bufferVoice;
        private void Wave_DataAvailable(object sender, WaveInEventArgs e)
        {
            //writer.Write(e.Buffer, 0, e.BytesRecorded);
            bufferVoice = e.Buffer;
            size_bufferVoice = e.BytesRecorded;
        }
        private void btn_unMute_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start("mmsys.cpl", ",1");
            try
            {
                wave = new WaveIn();
                wave.WaveFormat = new WaveFormat(16000, 16, 1);
                wave.DeviceNumber = cbbMic.SelectedIndex;
                wave.DataAvailable += Wave_DataAvailable;
                wave.StartRecording();

                Thread sendVoice = new Thread(xuLyGuiVoice);
                sendVoice.IsBackground = true;
                sendVoice.Start();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }
        private static readonly Object objLock1 = new object();
        void myTimer_ElapsedVoice(object sender, ElapsedEventArgs e)
        {

            ns = client.GetStream();
            //ms = new MemoryStream();
            //Invoke((MethodInvoker)(delegate ()
            //{
            //    var bufferVoice1 = bufferVoice;
            //    var size_bufferVoice1 = size_bufferVoice;
            //    ms.Write(bufferVoice1, 0, size_bufferVoice1);
            //}));
           
            byte[] userId_receive1 = encoding.GetBytes(userId() + " " + userReceiver() + " " + "Voice");
            ns.Write(userId_receive1, 0, userId_receive1.Length);
            //byte[] bufferVoiceMS = ms.GetBuffer();
            ns.Write(bufferVoice, 0, size_bufferVoice);
            //Array.Clear(bufferVoice, 0, bufferVoice.Length);

        }
        System.Timers.Timer myTimerVoice = new Timer(200);
        public void xuLyGuiVoice()
        {
            try
            {

                myTimerVoice.Start();
                myTimerVoice.Elapsed += new ElapsedEventHandler(myTimer_ElapsedVoice);
                Task.Delay(10); 

            }
            catch (Exception err)
            {

            }
        }

        private void btn_Mute_Click(object sender, EventArgs e)
        {
            try
            {
                wave.StopRecording();
                myTimerVoice.Stop();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

    }
}
