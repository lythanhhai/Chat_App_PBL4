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
    public partial class user_info : UserControl
    {
        public user_info()
        {
            InitializeComponent();
        }
        private string _userId;
        private string _name;
        private string _phone;

        public string userId
        {
            get
            {
                return _userId;
            }
            set
            {
                _userId = value;
            }
        }
        public string name
        {
            get
            {
                return lbName.Text;
            }
            set
            {
                lbName.Text = value;
            }
        }



        public string phone
        {
            get
            {
                return lbPhone.Text;
            }
            set
            {
                lbPhone.Text = value;
            }
        }
    }
}
