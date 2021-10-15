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
    public partial class group_info : UserControl
    {
        public group_info()
        {
            InitializeComponent();
        }
        private string _id_group;
        private string _name_group;
        private string _des;

        public string id_group
        {
            get
            {
                return _id_group;
            }
            set
            {
                _id_group = value;
            }
        }
        public string name_group
        {
            get
            {
                return lbNameGroup.Text;
            }
            set
            {
                lbNameGroup.Text = value;
            }
        }

        public string des
        {
            get
            {
                return lbDes.Text;
            }
            set
            {
                lbDes.Text = value;
            }
        }
    }
}
