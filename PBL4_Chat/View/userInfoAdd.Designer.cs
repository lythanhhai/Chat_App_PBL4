
namespace PBL4_Chat.View
{
    partial class userInfoAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userInfoAdd));
            this.gunaGradientPanel1 = new Guna.UI.WinForms.GunaGradientPanel();
            this.lbPhone_add = new Guna.UI.WinForms.GunaLabel();
            this.lbName_add = new Guna.UI.WinForms.GunaLabel();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.gunaGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaGradientPanel1
            // 
            this.gunaGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientPanel1.BackgroundImage")));
            this.gunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaGradientPanel1.Controls.Add(this.lbPhone_add);
            this.gunaGradientPanel1.Controls.Add(this.lbName_add);
            this.gunaGradientPanel1.Controls.Add(this.gunaCirclePictureBox1);
            this.gunaGradientPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaGradientPanel1.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(36)))), ((int)(((byte)(206)))));
            this.gunaGradientPanel1.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(48)))), ((int)(((byte)(90)))));
            this.gunaGradientPanel1.GradientColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(48)))), ((int)(((byte)(90)))));
            this.gunaGradientPanel1.GradientColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(48)))), ((int)(((byte)(90)))));
            this.gunaGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaGradientPanel1.Name = "gunaGradientPanel1";
            this.gunaGradientPanel1.Size = new System.Drawing.Size(384, 95);
            this.gunaGradientPanel1.TabIndex = 0;
            this.gunaGradientPanel1.Text = "gunaGradientPanel1";
            this.gunaGradientPanel1.Click += new System.EventHandler(this.userInfoAdd_Click);
            // 
            // lbPhone_add
            // 
            this.lbPhone_add.AutoSize = true;
            this.lbPhone_add.BackColor = System.Drawing.Color.Transparent;
            this.lbPhone_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbPhone_add.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbPhone_add.ForeColor = System.Drawing.Color.White;
            this.lbPhone_add.Location = new System.Drawing.Point(80, 54);
            this.lbPhone_add.Name = "lbPhone_add";
            this.lbPhone_add.Size = new System.Drawing.Size(165, 25);
            this.lbPhone_add.TabIndex = 5;
            this.lbPhone_add.Text = "hello, how are you?";
            // 
            // lbName_add
            // 
            this.lbName_add.AutoSize = true;
            this.lbName_add.BackColor = System.Drawing.Color.Transparent;
            this.lbName_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbName_add.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbName_add.ForeColor = System.Drawing.Color.White;
            this.lbName_add.Location = new System.Drawing.Point(80, 16);
            this.lbName_add.Name = "lbName_add";
            this.lbName_add.Size = new System.Drawing.Size(59, 25);
            this.lbName_add.TabIndex = 4;
            this.lbName_add.Text = "Hai Ly";
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaCirclePictureBox1.Image")));
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(15, 16);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(59, 63);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox1.TabIndex = 3;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // userInfoAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaGradientPanel1);
            this.Name = "userInfoAdd";
            this.Size = new System.Drawing.Size(384, 95);
            this.gunaGradientPanel1.ResumeLayout(false);
            this.gunaGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel1;
        private Guna.UI.WinForms.GunaLabel lbPhone_add;
        private Guna.UI.WinForms.GunaLabel lbName_add;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
    }
}
