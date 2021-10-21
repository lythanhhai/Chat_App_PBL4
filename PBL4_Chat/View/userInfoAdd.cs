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
    public partial class userInfoAdd : UserControl
    {
        public userInfoAdd()
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
                return lbName_add.Text;
            }
            set
            {
                lbName_add.Text = value;
            }
        }



        public string phone
        {
            get
            {
                return lbPhone_add.Text;
            }
            set
            {
                lbPhone_add.Text = value;
            }
        }


        public string getUserInfoAdd()
        {
            return this.userId;
        }

        private void userInfoAdd_Click(object sender, EventArgs e)
        {
            ((CreateGroup)this.Parent).userId_add.Add(this.userId);
        }
    }
}
