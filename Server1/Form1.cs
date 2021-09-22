﻿using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SimpleTcpServer server;
        private void Form1_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer();
            server.Delimiter = 0x13;//enter
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceived;
        }

        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            txtStatus.Invoke((MethodInvoker)delegate()
            {
                txtStatus.Text += e.MessageString;
                e.ReplyLine(string.Format("you said {0} ", e.MessageString));
            });
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //long result = 0;
            //if (long.TryParse(txtHost.Text, out result))
            txtStatus.Text += "starting server";
            System.Net.IPAddress ip = System.Net.IPAddress.Parse(txtHost.Text);
            //Convert.ToInt32(txtHost.Text)
            server.Start(ip, Convert.ToInt32(txtPort.Text));
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if(server.IsStarted)
            {
                server.Stop();
            }    
        }
    }
}
