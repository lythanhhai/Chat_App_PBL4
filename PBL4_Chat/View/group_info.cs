using PBL4_Chat.BLL;
using PBL4_Chat.DTO;
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
        // list id member
        string list_idMember = "";

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

        string getIdMember()
        {
            list_idMember = "";
            foreach (Group g in BLL_Group.instance.BLL_getAllGroup())
            {
                if (g.id_group == this.id_group)
                {
                    list_idMember += g.userId + " ";
                }
            }
            foreach (User_group ug in BLL_Group.instance.BLL_getAllUserGroup())
            {
                if (ug.id_group == this.id_group)
                {
                    list_idMember += ug.id_member + " ";
                }
            }
            return this.id_group + " " + list_idMember;
        }

        private void groupInfo_Click(object sender, EventArgs e)
        {

            // chuyển dữ liệu
            ((mainForm)this.ParentForm).userId_receive = new mainForm.getUserIdReveive(getIdMember);
            MessageBox.Show(getIdMember());
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
