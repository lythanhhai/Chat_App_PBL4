
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
    public partial class Register : Form
    {
        public Register()
        {
            
            InitializeComponent();
            // sự kiện buttonImageSignIn
            ButSignInLeft.Image = global::PBL4_Chat.Properties.Resources.signInHover;
            ButSignInLeft.Enabled = false;
            // content

        }

        private void bunifuPictureBox3_MouseHover(object sender, EventArgs e)
        {
            ButSignUpLeft.Image = global::PBL4_Chat.Properties.Resources.signUpHove;
        }

        private void bunifuPictureBox3_MouseLeave(object sender, EventArgs e)
        {
            if(ButSignUpLeft.Enabled == true)
            {
                ButSignUpLeft.Image = global::PBL4_Chat.Properties.Resources.SignUp2;
            }    
        }

        private void bunifuPictureBox1_MouseHover(object sender, EventArgs e)
        {
            ButSignInLeft.Image = global::PBL4_Chat.Properties.Resources.signInHover;
        }

        private void bunifuPictureBox1_MouseLeave(object sender, EventArgs e)
        {
            if(ButSignInLeft.Enabled == true)
            {
                ButSignInLeft.Image = global::PBL4_Chat.Properties.Resources.SignIn2;
            }    
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            lbUser.ForeColor = Color.FromArgb(10,70,70);
            pnUser.BackColor = Color.FromArgb(10, 70, 70);
            txtUser.ForeColor = Color.FromArgb(10, 70, 70);
            bpbUser.Image = global::PBL4_Chat.Properties.Resources.UserEvent;

            lbPass.ForeColor = Color.FromArgb(0,0,0);
            pnPass.BackColor = Color.FromArgb(0, 0, 0);
            txtPass.ForeColor = Color.FromArgb(0, 0, 0);
            bpbPass.Image = global::PBL4_Chat.Properties.Resources.password;
        }

        private void txtPass_Click(object sender, EventArgs e)
        {
            lbPass.ForeColor = Color.FromArgb(10, 70, 70);
            pnPass.BackColor = Color.FromArgb(10, 70, 70);
            txtPass.ForeColor = Color.FromArgb(10, 70, 70);
            bpbPass.Image = global::PBL4_Chat.Properties.Resources.PasswordEvent;

            lbUser.ForeColor = Color.FromArgb(0, 0, 0);
            pnUser.BackColor = Color.FromArgb(0, 0, 0);
            txtUser.ForeColor = Color.FromArgb(0, 0, 0);
            bpbUser.Image = global::PBL4_Chat.Properties.Resources.user;
        }
        private void bunifuPictureBox3_Click(object sender, EventArgs e)
        {
            ButSignInLeft.Enabled = true;
            ButSignInLeft.Image = global::PBL4_Chat.Properties.Resources.SignIn2;
            ButSignUpLeft.Enabled = false;
            bunifuPages1.SelectTab(tabPage2);
            lbContent.Text = "Please create your different account"
                              + Environment.NewLine +
                              "Before start journey with us"
                              + Environment.NewLine +
                              "Or if you have had it\n"
                              + Environment.NewLine +
                              "Press button sign in below to log in";
            lbTitle.Text = "HI, Create Your Account !";
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            ButSignUpLeft.Enabled = true;

            ButSignUpLeft.Image = global::PBL4_Chat.Properties.Resources.SignUp2;
            ButSignInLeft.Enabled = false;
            bunifuPages1.SelectTab(tabPage1);
            lbContent.Text = "Please enter your account personal detail"
                              + Environment.NewLine +
                              "And after start journey with us"
                              + Environment.NewLine +
                              "Or if you haven't had it "
                              + Environment.NewLine +
                              "Press button sign up below to register";
            lbTitle.Text = "HI, Welcome Back !";

        }

        private void txtUser1_Click(object sender, EventArgs e)
        {
            lbUser1.ForeColor = Color.FromArgb(10, 70, 70);
            pnUser1.BackColor = Color.FromArgb(10, 70, 70);
            txtUser1.ForeColor = Color.FromArgb(10, 70, 70);
            bpbUser1.Image = global::PBL4_Chat.Properties.Resources.UserEvent;

            lbPass1.ForeColor = Color.FromArgb(0, 0, 0);
            pnPass1.BackColor = Color.FromArgb(0, 0, 0);
            txtPass1.ForeColor = Color.FromArgb(0, 0, 0);
            bpbPass1.Image = global::PBL4_Chat.Properties.Resources.password;

            lbConPass.ForeColor = Color.FromArgb(0, 0, 0);
            pnConPass.BackColor = Color.FromArgb(0, 0, 0);
            txtConPass.ForeColor = Color.FromArgb(0, 0, 0);
            bpbConPass.Image = global::PBL4_Chat.Properties.Resources.confirmPass;

            lbEmail.ForeColor = Color.FromArgb(0, 0, 0);
            pnEmail.BackColor = Color.FromArgb(0, 0, 0);
            txtEmail.ForeColor = Color.FromArgb(0, 0, 0);
            bpbEmail.Image = global::PBL4_Chat.Properties.Resources.confirmPass;

            lbPhone.ForeColor = Color.FromArgb(0, 0, 0);
            pnPhone.BackColor = Color.FromArgb(0, 0, 0);
            txtPhone.ForeColor = Color.FromArgb(0, 0, 0);
            bpbPhone.Image = global::PBL4_Chat.Properties.Resources.confirmPass;

            lbFirstName.ForeColor = Color.FromArgb(0, 0, 0);
            pnFirstName.BackColor = Color.FromArgb(0, 0, 0);
            txtFirstName.ForeColor = Color.FromArgb(0, 0, 0);
            bpbFirstName.Image = global::PBL4_Chat.Properties.Resources.confirmPass;

            lbLastname.ForeColor = Color.FromArgb(0, 0, 0);
            pnLastname.BackColor = Color.FromArgb(0, 0, 0);
            txtLastname.ForeColor = Color.FromArgb(0, 0, 0);
            bpbLastname.Image = global::PBL4_Chat.Properties.Resources.confirmPass;

        }

        private void txtPass1_Click(object sender, EventArgs e)
        {
            lbUser1.ForeColor = Color.FromArgb(0,0,0);
            pnUser1.BackColor = Color.FromArgb(0, 0, 0);
            txtUser1.ForeColor = Color.FromArgb(0, 0, 0);
            bpbUser1.Image = global::PBL4_Chat.Properties.Resources.user;

            lbPass1.ForeColor = Color.FromArgb(10,70,70);
            pnPass1.BackColor = Color.FromArgb(10, 70, 70);
            txtPass1.ForeColor = Color.FromArgb(10, 70, 70);
            bpbPass1.Image = global::PBL4_Chat.Properties.Resources.PasswordEvent;

            lbConPass.ForeColor = Color.FromArgb(0, 0, 0);
            pnConPass.BackColor = Color.FromArgb(0, 0, 0);
            txtConPass.ForeColor = Color.FromArgb(0, 0, 0);
            bpbConPass.Image = global::PBL4_Chat.Properties.Resources.confirmPass;

            lbEmail.ForeColor = Color.FromArgb(0, 0, 0);
            pnEmail.BackColor = Color.FromArgb(0, 0, 0);
            txtEmail.ForeColor = Color.FromArgb(0, 0, 0);
            bpbEmail.Image = global::PBL4_Chat.Properties.Resources.confirmPass;

            lbPhone.ForeColor = Color.FromArgb(0, 0, 0);
            pnPhone.BackColor = Color.FromArgb(0, 0, 0);
            txtPhone.ForeColor = Color.FromArgb(0, 0, 0);
            bpbPhone.Image = global::PBL4_Chat.Properties.Resources.confirmPass;

            lbFirstName.ForeColor = Color.FromArgb(0, 0, 0);
            pnFirstName.BackColor = Color.FromArgb(0, 0, 0);
            txtFirstName.ForeColor = Color.FromArgb(0, 0, 0);
            bpbFirstName.Image = global::PBL4_Chat.Properties.Resources.confirmPass;

            lbLastname.ForeColor = Color.FromArgb(0, 0, 0);
            pnLastname.BackColor = Color.FromArgb(0, 0, 0);
            txtLastname.ForeColor = Color.FromArgb(0, 0, 0);
            bpbLastname.Image = global::PBL4_Chat.Properties.Resources.confirmPass;
        }

        private void txtConPass_Click(object sender, EventArgs e)
        {
            lbUser1.ForeColor = Color.FromArgb(0, 0, 0);
            pnUser1.BackColor = Color.FromArgb(0, 0, 0);
            txtUser1.ForeColor = Color.FromArgb(0, 0, 0);
            bpbUser1.Image = global::PBL4_Chat.Properties.Resources.user;

            lbPass1.ForeColor = Color.FromArgb(0, 0, 0);
            pnPass1.BackColor = Color.FromArgb(0, 0, 0);
            txtPass1.ForeColor = Color.FromArgb(0, 0, 0);
            bpbPass1.Image = global::PBL4_Chat.Properties.Resources.password;

            lbConPass.ForeColor = Color.FromArgb(10, 70, 70);
            pnConPass.BackColor = Color.FromArgb(10, 70, 70);
            txtConPass.ForeColor = Color.FromArgb(10, 70, 70);
            bpbConPass.Image = global::PBL4_Chat.Properties.Resources.confirmPassEvent;

            lbEmail.ForeColor = Color.FromArgb(0, 0, 0);
            pnEmail.BackColor = Color.FromArgb(0, 0, 0);
            txtEmail.ForeColor = Color.FromArgb(0, 0, 0);
            bpbEmail.Image = global::PBL4_Chat.Properties.Resources.confirmPass;

            lbPhone.ForeColor = Color.FromArgb(0, 0, 0);
            pnPhone.BackColor = Color.FromArgb(0, 0, 0);
            txtPhone.ForeColor = Color.FromArgb(0, 0, 0);
            bpbPhone.Image = global::PBL4_Chat.Properties.Resources.confirmPass;

            lbFirstName.ForeColor = Color.FromArgb(0, 0, 0);
            pnFirstName.BackColor = Color.FromArgb(0, 0, 0);
            txtFirstName.ForeColor = Color.FromArgb(0, 0, 0);
            bpbFirstName.Image = global::PBL4_Chat.Properties.Resources.confirmPass;

            lbLastname.ForeColor = Color.FromArgb(0, 0, 0);
            pnLastname.BackColor = Color.FromArgb(0, 0, 0);
            txtLastname.ForeColor = Color.FromArgb(0, 0, 0);
            bpbLastname.Image = global::PBL4_Chat.Properties.Resources.confirmPass;
        }

        private void txtPhone_Click(object sender, EventArgs e)
        {
            lbUser1.ForeColor = Color.FromArgb(0, 0, 0);
            pnUser1.BackColor = Color.FromArgb(0, 0, 0);
            txtUser1.ForeColor = Color.FromArgb(0, 0, 0);
            bpbUser1.Image = global::PBL4_Chat.Properties.Resources.user;

            lbPass1.ForeColor = Color.FromArgb(0, 0, 0);
            pnPass1.BackColor = Color.FromArgb(0, 0, 0);
            txtPass1.ForeColor = Color.FromArgb(0, 0, 0);
            bpbPass1.Image = global::PBL4_Chat.Properties.Resources.password;

            lbConPass.ForeColor = Color.FromArgb(0, 0, 0);
            pnConPass.BackColor = Color.FromArgb(0, 0, 0);
            txtConPass.ForeColor = Color.FromArgb(0, 0, 0);
            bpbConPass.Image = global::PBL4_Chat.Properties.Resources.confirmPass;

            lbEmail.ForeColor = Color.FromArgb(0, 0, 0);
            pnEmail.BackColor = Color.FromArgb(0, 0, 0);
            txtEmail.ForeColor = Color.FromArgb(0, 0, 0);
            bpbEmail.Image = global::PBL4_Chat.Properties.Resources.confirmPass;

            lbPhone.ForeColor = Color.FromArgb(10, 70, 70);
            pnPhone.BackColor = Color.FromArgb(10, 70, 70);
            txtPhone.ForeColor = Color.FromArgb(10, 70, 70);
            bpbPhone.Image = global::PBL4_Chat.Properties.Resources.confirmPass;

            lbFirstName.ForeColor = Color.FromArgb(0, 0, 0);
            pnFirstName.BackColor = Color.FromArgb(0, 0, 0);
            txtFirstName.ForeColor = Color.FromArgb(0, 0, 0);
            bpbFirstName.Image = global::PBL4_Chat.Properties.Resources.confirmPass;

            lbLastname.ForeColor = Color.FromArgb(0, 0, 0);
            pnLastname.BackColor = Color.FromArgb(0, 0, 0);
            txtLastname.ForeColor = Color.FromArgb(0, 0, 0);
            bpbLastname.Image = global::PBL4_Chat.Properties.Resources.confirmPass;
        }

        private void txtFirstName_Click(object sender, EventArgs e)
        {
            lbUser1.ForeColor = Color.FromArgb(0, 0, 0);
            pnUser1.BackColor = Color.FromArgb(0, 0, 0);
            txtUser1.ForeColor = Color.FromArgb(0, 0, 0);
            bpbUser1.Image = global::PBL4_Chat.Properties.Resources.user;

            lbPass1.ForeColor = Color.FromArgb(0, 0, 0);
            pnPass1.BackColor = Color.FromArgb(0, 0, 0);
            txtPass1.ForeColor = Color.FromArgb(0, 0, 0);
            bpbPass1.Image = global::PBL4_Chat.Properties.Resources.password;

            lbConPass.ForeColor = Color.FromArgb(0, 0, 0);
            pnConPass.BackColor = Color.FromArgb(0, 0, 0);
            txtConPass.ForeColor = Color.FromArgb(0, 0, 0);
            bpbConPass.Image = global::PBL4_Chat.Properties.Resources.confirmPass;

            lbEmail.ForeColor = Color.FromArgb(0, 0, 0);
            pnEmail.BackColor = Color.FromArgb(0, 0, 0);
            txtEmail.ForeColor = Color.FromArgb(0, 0, 0);
            bpbEmail.Image = global::PBL4_Chat.Properties.Resources.confirmPass;

            lbPhone.ForeColor = Color.FromArgb(0, 0, 0);
            pnPhone.BackColor = Color.FromArgb(0, 0, 0);
            txtPhone.ForeColor = Color.FromArgb(0, 0, 0);
            bpbPhone.Image = global::PBL4_Chat.Properties.Resources.confirmPass;

            lbFirstName.ForeColor = Color.FromArgb(10, 70, 70);
            pnFirstName.BackColor = Color.FromArgb(10, 70, 70);
            txtFirstName.ForeColor = Color.FromArgb(10, 70, 70);
            bpbFirstName.Image = global::PBL4_Chat.Properties.Resources.confirmPass;

            lbLastname.ForeColor = Color.FromArgb(0, 0, 0);
            pnLastname.BackColor = Color.FromArgb(0, 0, 0);
            txtLastname.ForeColor = Color.FromArgb(0, 0, 0);
            bpbLastname.Image = global::PBL4_Chat.Properties.Resources.confirmPass;
        }

        private void txtLastname_Click(object sender, EventArgs e)
        {
            lbUser1.ForeColor = Color.FromArgb(0, 0, 0);
            pnUser1.BackColor = Color.FromArgb(0, 0, 0);
            txtUser1.ForeColor = Color.FromArgb(0, 0, 0);
            bpbUser1.Image = global::PBL4_Chat.Properties.Resources.user;

            lbPass1.ForeColor = Color.FromArgb(0, 0, 0);
            pnPass1.BackColor = Color.FromArgb(0, 0, 0);
            txtPass1.ForeColor = Color.FromArgb(0, 0, 0);
            bpbPass1.Image = global::PBL4_Chat.Properties.Resources.password;

            lbConPass.ForeColor = Color.FromArgb(0, 0, 0);
            pnConPass.BackColor = Color.FromArgb(0, 0, 0);
            txtConPass.ForeColor = Color.FromArgb(0, 0, 0);
            bpbConPass.Image = global::PBL4_Chat.Properties.Resources.confirmPass;

            lbEmail.ForeColor = Color.FromArgb(0, 0, 0);
            pnEmail.BackColor = Color.FromArgb(0, 0, 0);
            txtEmail.ForeColor = Color.FromArgb(0, 0, 0);
            bpbEmail.Image = global::PBL4_Chat.Properties.Resources.confirmPass;

            lbPhone.ForeColor = Color.FromArgb(0, 0, 0);
            pnPhone.BackColor = Color.FromArgb(0, 0, 0);
            txtPhone.ForeColor = Color.FromArgb(0, 0, 0);
            bpbPhone.Image = global::PBL4_Chat.Properties.Resources.confirmPass;

            lbFirstName.ForeColor = Color.FromArgb(0, 0, 0);
            pnFirstName.BackColor = Color.FromArgb(0, 0, 0);
            txtFirstName.ForeColor = Color.FromArgb(0, 0, 0);
            bpbFirstName.Image = global::PBL4_Chat.Properties.Resources.confirmPass;

            lbLastname.ForeColor = Color.FromArgb(10, 70, 70);
            pnLastname.BackColor = Color.FromArgb(10, 70, 70);
            txtLastname.ForeColor = Color.FromArgb(10, 70, 70);
            bpbLastname.Image = global::PBL4_Chat.Properties.Resources.confirmPass;
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            lbUser1.ForeColor = Color.FromArgb(0, 0, 0);
            pnUser1.BackColor = Color.FromArgb(0, 0, 0);
            txtUser1.ForeColor = Color.FromArgb(0, 0, 0);
            bpbUser1.Image = global::PBL4_Chat.Properties.Resources.user;

            lbPass1.ForeColor = Color.FromArgb(0, 0, 0);
            pnPass1.BackColor = Color.FromArgb(0, 0, 0);
            txtPass1.ForeColor = Color.FromArgb(0, 0, 0);
            bpbPass1.Image = global::PBL4_Chat.Properties.Resources.password;

            lbConPass.ForeColor = Color.FromArgb(0, 0, 0);
            pnConPass.BackColor = Color.FromArgb(0, 0, 0);
            txtConPass.ForeColor = Color.FromArgb(0, 0, 0);
            bpbConPass.Image = global::PBL4_Chat.Properties.Resources.confirmPass;

            lbEmail.ForeColor = Color.FromArgb(10, 70, 70);
            pnEmail.BackColor = Color.FromArgb(10, 70, 70);
            txtEmail.ForeColor = Color.FromArgb(10, 70, 70);
            bpbEmail.Image = global::PBL4_Chat.Properties.Resources.confirmPass;

            lbPhone.ForeColor = Color.FromArgb(0, 0, 0);
            pnPhone.BackColor = Color.FromArgb(0, 0, 0);
            txtPhone.ForeColor = Color.FromArgb(0, 0, 0);
            bpbPhone.Image = global::PBL4_Chat.Properties.Resources.confirmPass;

            lbFirstName.ForeColor = Color.FromArgb(0, 0, 0);
            pnFirstName.BackColor = Color.FromArgb(0, 0, 0);
            txtFirstName.ForeColor = Color.FromArgb(0, 0, 0);
            bpbFirstName.Image = global::PBL4_Chat.Properties.Resources.confirmPass;

            lbLastname.ForeColor = Color.FromArgb(0, 0, 0);
            pnLastname.BackColor = Color.FromArgb(0, 0, 0);
            txtLastname.ForeColor = Color.FromArgb(0, 0, 0);
            bpbLastname.Image = global::PBL4_Chat.Properties.Resources.confirmPass;
        }


        private void bpbSignIn_Click(object sender, EventArgs e)
        {
            //int count = 0;
            //int row = -1;
            //string id_login = "";
            //AffterLogin aflogin = new AffterLogin();
            //foreach (Login i in BLL_TKVX.Instance.getAllLogin_BLL())
            //{
            //    if (txtUser.Text == i.userName && txtPass.Text == i.passWord)
            //    {

            //        count++;
            //        id_login = i.id_login;
            //        row = i.row;
            //        break;
            //    }
            //}
            //if (count > 0 && row == 1)
            //{

            //    //ds.Show();
            //    aflogin.Show();
            //    Properties.Settings.Default.id_login = id_login;
            //    Properties.Settings.Default.Save();
            //    Properties.Settings.Default.Reload();
            //    this.Hide();
            //}

            //if(count > 0 && row == 0)
            //{
            //    main_ql f = new main_ql();
            //    f.Show();
            //    this.Hide();

            //}
            //if(count==0)
            //{
            //    lbErrorPassSignIn.Text = "Username or Password is incorrect";
            //}
            //List<DetailRoute> list = BLL_TKVX.Instance.getAllChiTietTuyen_BLL();
            //foreach (DetailRoute i in list)
            //{

            //    //if ((DateTime.Compare(DateTime.Now.Date, i.date) > 0))
            //    if ((DateTime.Compare(DateTime.Now.Date, i.date) > 0))// || (DateTime.Compare(Convert.ToDateTime(DateTime.Now.Hour),Convert.ToDateTime(i.time_start)) > 0))
            //    {
            //        BLL_TKVX.Instance.updateDetailRoute_BLL(i.id_delRoute);
            //    }
            //}

        }

        private void bpbSignUp_Click(object sender, EventArgs e)
        {
            ////if (txtUser1.Text.Length >= 5)
            ////{
            ////    lbErrorUserSignUp.Text = "";
            ////}
            ////// kiểm tra lượng ký tự password
            ////if (txtPass1.Text.Length >= 8)
            ////{
            ////    lbErrorPassSignUp.Text = "";
            ////}
            ////// kiểm tra 2 mật khâu trùng nhau không
            ////if (String.Compare(txtPass1.Text, txtConPass.Text) == 0)
            ////{
            ////    lbErrorConPassSignUp.Text = "";
            ////}
            ////// kiểm tra tích vào 
            ////if (cbAgree.Checked == true)
            ////{
            ////    lbErrorDontTick.Text = "";
            ////}
            //List<Login> list = BLL_TKVX.Instance.getAllLogin_BLL();
            //int count = 0;
            //foreach (Login i in list)
            //{
            //    if (txtUser1.Text == i.userName)
            //    {
            //        count++;
            //        break;
            //    }
            //}
            //if (count > 0)
            //{
            //    lbErrorUserSignUp.Text = "Username have used to";
            //}
            //else
            //{
            //}

            //if (String.Compare(txtPass1.Text, txtConPass.Text) != 0 || txtUser1.Text.Length < 5 || txtPass1.Text.Length < 8 || cbAgree.Checked == false)
            //{
                
            //    // kiểm tra lượng ký tự username
            //    if (txtUser1.Text.Length < 5)
            //    {
            //        lbErrorUserSignUp.Text = "Please insert more than 5 characters";
            //    }
            //    // kiểm tra lượng ký tự password
            //    if (txtPass1.Text.Length < 8)
            //    {
            //        lbErrorPassSignUp.Text = "Please insert more than 8 characters";
            //    }
            //    // kiểm tra 2 mật khâu trùng nhau không
            //    if (String.Compare(txtPass1.Text, txtConPass.Text) != 0)
            //    {
            //        lbErrorConPassSignUp.Text = "Confirm Password dont same as password";
            //    }
            //    // kiểm tra tích vào 
            //    if (cbAgree.Checked == false)
            //    {
            //        lbErrorDontTick.Text = "You havent agree with condition and service of app";
            //    }
            //}
   
            //else
            //{

            //    if(count == 0)
            //    {
            //        string id_login = Convert.ToString(Convert.ToInt32(BLL_TKVX.Instance.getIdLoginMax_BLL()) + 1);
            //        BLL_TKVX.Instance.insertLogin_BLL(id_login, txtUser1.Text, txtPass1.Text);
            //    }    
                    
                

            //}                
        }

        private void checkRemember_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void Register_Load(object sender, EventArgs e)
        {
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        
    }
}
