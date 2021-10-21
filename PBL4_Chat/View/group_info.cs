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

        string getIdGroup()
        {
            return this.id_group;
        }

        private void groupInfo_Click(object sender, EventArgs e)
        {
            // chuyển dữ liệu
            ((mainForm)this.ParentForm).id_group = new mainForm.getIdGroup(getIdGroup);
            // load tên
            ((mainForm)this.ParentForm).lbName_Receiver.Text = this.name_group;
            ((mainForm)this.ParentForm).lbStatus.Text = "online";
            ((mainForm)this.ParentForm).pn_chat.Visible = true;
            // khi người dùng nhắn cho 1 người khác sẽ xóa panel để upload tin nhắn
            ((mainForm)this.ParentForm).txt_message.Clear();
            ((mainForm)this.ParentForm).txt_send.Clear();
            
        }
    }
}
