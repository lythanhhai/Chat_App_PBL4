
namespace PBL4_Chat.View
{
    partial class user_info
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(user_info));
            this.userInfo = new Guna.UI.WinForms.GunaGradientPanel();
            this.lbPhone = new Guna.UI.WinForms.GunaLabel();
            this.lbName = new Guna.UI.WinForms.GunaLabel();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.userInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // userInfo
            // 
            this.userInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userInfo.BackgroundImage")));
            this.userInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userInfo.Controls.Add(this.lbPhone);
            this.userInfo.Controls.Add(this.lbName);
            this.userInfo.Controls.Add(this.gunaCirclePictureBox1);
            this.userInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userInfo.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(36)))), ((int)(((byte)(206)))));
            this.userInfo.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(48)))), ((int)(((byte)(90)))));
            this.userInfo.GradientColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(48)))), ((int)(((byte)(90)))));
            this.userInfo.GradientColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(48)))), ((int)(((byte)(90)))));
            this.userInfo.Location = new System.Drawing.Point(0, 0);
            this.userInfo.Name = "userInfo";
            this.userInfo.Size = new System.Drawing.Size(370, 95);
            this.userInfo.TabIndex = 0;
            this.userInfo.Text = "gunaGradientPanel1";
            this.userInfo.Click += new System.EventHandler(this.userInfo_Click);
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.BackColor = System.Drawing.Color.Transparent;
            this.lbPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbPhone.ForeColor = System.Drawing.Color.White;
            this.lbPhone.Location = new System.Drawing.Point(68, 53);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(165, 25);
            this.lbPhone.TabIndex = 2;
            this.lbPhone.Text = "hello, how are you?";
            this.lbPhone.Click += new System.EventHandler(this.userInfo_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(68, 15);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(59, 25);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Hai Ly";
            this.lbName.Click += new System.EventHandler(this.userInfo_Click);
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox1.Image = global::PBL4_Chat.Properties.Resources.profile;
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(3, 15);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(59, 63);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox1.TabIndex = 0;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            this.gunaCirclePictureBox1.Click += new System.EventHandler(this.userInfo_Click);
            // 
            // user_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.userInfo);
            this.Name = "user_info";
            this.Size = new System.Drawing.Size(370, 95);
            this.userInfo.ResumeLayout(false);
            this.userInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradientPanel userInfo;
        private Guna.UI.WinForms.GunaLabel lbPhone;
        private Guna.UI.WinForms.GunaLabel lbName;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
    }
}
