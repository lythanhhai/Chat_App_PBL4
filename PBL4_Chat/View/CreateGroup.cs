using Bunifu.UI.WinForms;
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
    public partial class CreateGroup : Form
    {
        // nhận userId từ mainForm
        public delegate string getUserId();
        public getUserId userId;

        public CreateGroup()
        {
            InitializeComponent();
        }
        // cho user vào 
        public void showUser()
        {
            List<User> listUser = BLL_User.instance.BLL_getUser();
            foreach (User u in listUser)
            {
                if (u.userId == userId())
                {
                    continue;
                }
                panel_flowUser.Controls.Add(new userInfoAdd
                {
                    userId = u.userId,
                    name = u.firstName + " " + u.lastName,
                    phone = u.phone,
                });
            }
        }
        private void but_troveConfirm_Click(object sender, EventArgs e)
        {

        }

        public List<string> userId_add = new List<string>();
        // tạo nhóm
        private void but_taoNhom_Click(object sender, EventArgs e)
        {
            string id_group = Convert.ToString(Convert.ToInt32(BLL_Group.instance.BLL_getMaxIdGroup()) + 1);
            string date = DateTime.Now.ToString();
            // thêm group
            BLL_Group.instance.BLL_addGroup(id_group, txtNameGroup.Text, userId(), date, txtDes.Text);
            foreach(string str in userId_add)
            {
                // thêm thành viên
                string id_userGroup = Convert.ToString(Convert.ToInt32(BLL_Group.instance.BLL_getMaxIdUserGroup()) + 1);
                BLL_Group.instance.BLL_addUserGroup(id_userGroup, str, id_group, date);
            }    
        }

        private void CreateGroup_Load(object sender, EventArgs e)
        {
            showUser();
        }
    }
}
