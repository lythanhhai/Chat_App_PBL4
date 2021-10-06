using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL4_Chat.View
{
    public partial class user_message : UserControl
    {
        public user_message()
        {
            InitializeComponent();
            //gunaTextBox1.AutoSize = false;
            //gunaTextBox1.Height += 10;
        }

        private void AutoSizeTextBox(TextBox txt)
        {
            const int x_margin = 0;
            const int y_margin = 2;
            Size size = TextRenderer.MeasureText(txt.Text, txt.Font);
            txt.ClientSize =
                new Size(size.Width + x_margin, size.Height + y_margin);
        }
        private void user_message_Load(object sender, EventArgs e)
        {
            
        }
    }
}
