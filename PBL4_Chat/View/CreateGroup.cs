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

namespace PBL3_DATVEXE.View
{
    public partial class datVe : Form
    {
        // delegate lấy số vé và tổng giá
        public delegate void getVeAndTongGia(int soVe,double tongGia);

        public getVeAndTongGia d1 { get; set; }

        // lấy id_route and id_vehicle từ confirm sang datVe
        public delegate string getIdRouteAndVehicle();

        public getIdRouteAndVehicle getRoute { get; set; }
        public getIdRouteAndVehicle getVehicle { get; set; }

        // lấy tên ghế từ form confirm sang form datVe.
        public delegate List<string> getNameGhe();

        public getNameGhe getGhe { get; set; }
        public int soVe { get; set; }
        public double tongGia { get; set; }

        public string id_detRoute { get; set; }

        public string id_vehicle { get; set; }
        public datVe(int soVe,double tongGia)
        {
            InitializeComponent();
            // giá và số vé
            this.soVe = soVe;
            this.tongGia = tongGia;
            lbTen.ForeColor = Color.FromArgb(78, 184, 206);
            bunifuPanel1.BackgroundColor = Color.FromArgb(78, 184, 206);
            txtName.ForeColor = Color.FromArgb(78, 184, 206);
        }

        private void But_xacnhan_Click(object sender, EventArgs e)
        {

        }

        private void txtName_Click(object sender, EventArgs e)
        {
        //    txtName.Clear();
            lbTen.ForeColor = Color.FromArgb(78, 184, 206);
            bunifuPanel1.BackgroundColor = Color.FromArgb(78, 184, 206);
            txtName.ForeColor = Color.FromArgb(78, 184, 206);

            lbSoDT.ForeColor = Color.White;
            bunifuPanel2.BackgroundColor = Color.White;
            txtPhone.ForeColor = Color.White;

            lbEmail.ForeColor = Color.White;
            bunifuPanel3.BackgroundColor = Color.White;
            txtEmail.ForeColor = Color.White;

            lbNote.ForeColor = Color.White;
            bunifuPanel4.BackgroundColor = Color.White;
            txtNote.ForeColor = Color.White;
        }

        private void txtPhone_Click(object sender, EventArgs e)
        {
          //  txtPhone.Clear();
            lbSoDT.ForeColor = Color.FromArgb(78, 184, 206);
            bunifuPanel2.BackgroundColor = Color.FromArgb(78, 184, 206);
            txtPhone.ForeColor = Color.FromArgb(78, 184, 206);

            lbTen.ForeColor = Color.White;
            bunifuPanel1.BackgroundColor = Color.White;
            txtName.ForeColor = Color.White;

            lbEmail.ForeColor = Color.White;
            bunifuPanel3.BackgroundColor = Color.White;
            txtEmail.ForeColor = Color.White;

            lbNote.ForeColor = Color.White;
            bunifuPanel4.BackgroundColor = Color.White;
            txtNote.ForeColor = Color.White;
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
           // txtEmail.Clear();
            lbEmail.ForeColor = Color.FromArgb(78, 184, 206);
            bunifuPanel3.BackgroundColor = Color.FromArgb(78, 184, 206);
            txtEmail.ForeColor = Color.FromArgb(78, 184, 206);

            lbSoDT.ForeColor = Color.White;
            bunifuPanel2.BackgroundColor = Color.White;
            txtPhone.ForeColor = Color.White;

            lbTen.ForeColor = Color.White;
            bunifuPanel1.BackgroundColor = Color.White;
            txtName.ForeColor = Color.White;

            lbNote.ForeColor = Color.White;
            bunifuPanel4.BackgroundColor = Color.White;
            txtNote.ForeColor = Color.White;
        }

        private void txtNote_Click(object sender, EventArgs e)
        {
         //   txtNote.Clear();
            lbNote.ForeColor = Color.FromArgb(78, 184, 206);
            bunifuPanel4.BackgroundColor = Color.FromArgb(78, 184, 206);
            txtNote.ForeColor = Color.FromArgb(78, 184, 206);
            

            lbSoDT.ForeColor = Color.White;
            bunifuPanel2.BackgroundColor = Color.White;
            txtPhone.ForeColor = Color.White;

            lbEmail.ForeColor = Color.White;
            bunifuPanel3.BackgroundColor = Color.White;
            txtEmail.ForeColor = Color.White;

            lbTen.ForeColor = Color.White;
            bunifuPanel1.BackgroundColor = Color.White;
            txtName.ForeColor = Color.White;
        }

        private void But_xemthongtin_Click(object sender, EventArgs e)
        {
            // showNameSeat();
            panelMain.Hide();
          //  OpenChildForm(new infoTicket(this.id_detRoute,this.id_vehicle,this.tongGia));
        }
        private Form currentChildForm;
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            //panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            panelMain.Text = childForm.Text;
        }

        private void but_troveConfirm_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["DetailSchedule"];
            frm.Show();
            this.Hide();
        }

        private void datVe_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form frm = Application.OpenForms["DetailSchedule"];
            frm.Show();
            this.Hide();
        }
        //public void showNameSeat()
        //{
        //    List<string> listName = getGhe();
        //    //List<seeTicket> list = new List<seeTicket>();
        //    seeTicket[] list = new seeTicket[listName.Count];
        //    int count1 = 0;
        //    foreach(seeTicket i in list)
        //    {

        //        flowLayoutPanel1.Controls.Add(new seeTicket
        //        {
        //             NameGhe = listName[count1],
        //             Gia = (this.tongGia / this.soVe).ToString(),
        //        });
        //        count1++;
        //    }    
        //}
    }
}
