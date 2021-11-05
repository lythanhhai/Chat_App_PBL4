
namespace PBL4_Chat.View
{
    partial class Cam
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbbCamera = new System.Windows.Forms.ComboBox();
            this.pbCamera = new System.Windows.Forms.PictureBox();
            this.gunaTransfarantPictureBox1 = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.btn_stop = new Guna.UI.WinForms.GunaButton();
            this.btnStart = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox1)).BeginInit();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbCamera
            // 
            this.cbbCamera.FormattingEnabled = true;
            this.cbbCamera.Location = new System.Drawing.Point(889, 836);
            this.cbbCamera.Name = "cbbCamera";
            this.cbbCamera.Size = new System.Drawing.Size(240, 28);
            this.cbbCamera.TabIndex = 0;
            // 
            // pbCamera
            // 
            this.pbCamera.Location = new System.Drawing.Point(967, 484);
            this.pbCamera.Name = "pbCamera";
            this.pbCamera.Size = new System.Drawing.Size(501, 311);
            this.pbCamera.TabIndex = 1;
            this.pbCamera.TabStop = false;
            // 
            // gunaTransfarantPictureBox1
            // 
            this.gunaTransfarantPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaTransfarantPictureBox1.BaseColor = System.Drawing.Color.Black;
            this.gunaTransfarantPictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaTransfarantPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.gunaTransfarantPictureBox1.Name = "gunaTransfarantPictureBox1";
            this.gunaTransfarantPictureBox1.Size = new System.Drawing.Size(1468, 795);
            this.gunaTransfarantPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaTransfarantPictureBox1.TabIndex = 5;
            this.gunaTransfarantPictureBox1.TabStop = false;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.pbCamera);
            this.gunaPanel1.Controls.Add(this.gunaTransfarantPictureBox1);
            this.gunaPanel1.Location = new System.Drawing.Point(12, 12);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1468, 795);
            this.gunaPanel1.TabIndex = 6;
            // 
            // btn_stop
            // 
            this.btn_stop.AnimationHoverSpeed = 0.07F;
            this.btn_stop.AnimationSpeed = 0.03F;
            this.btn_stop.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_stop.BorderColor = System.Drawing.Color.Black;
            this.btn_stop.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_stop.FocusedColor = System.Drawing.Color.Empty;
            this.btn_stop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_stop.ForeColor = System.Drawing.Color.White;
            this.btn_stop.Image = null;
            this.btn_stop.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_stop.Location = new System.Drawing.Point(1154, 836);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_stop.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_stop.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_stop.OnHoverImage = null;
            this.btn_stop.OnPressedColor = System.Drawing.Color.Black;
            this.btn_stop.Size = new System.Drawing.Size(160, 63);
            this.btn_stop.TabIndex = 7;
            this.btn_stop.Text = "Stop";
            this.btn_stop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btnStart
            // 
            this.btnStart.AnimationHoverSpeed = 0.07F;
            this.btnStart.AnimationSpeed = 0.03F;
            this.btnStart.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnStart.BorderColor = System.Drawing.Color.Black;
            this.btnStart.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnStart.FocusedColor = System.Drawing.Color.Empty;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Image = null;
            this.btnStart.ImageSize = new System.Drawing.Size(20, 20);
            this.btnStart.Location = new System.Drawing.Point(1320, 836);
            this.btnStart.Name = "btnStart";
            this.btnStart.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnStart.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnStart.OnHoverForeColor = System.Drawing.Color.White;
            this.btnStart.OnHoverImage = null;
            this.btnStart.OnPressedColor = System.Drawing.Color.Black;
            this.btnStart.Size = new System.Drawing.Size(160, 63);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Start";
            this.btnStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Cam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(1492, 911);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.cbbCamera);
            this.Name = "Cam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cam";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Cam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCamera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox1)).EndInit();
            this.gunaPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbCamera;
        private System.Windows.Forms.PictureBox pbCamera;
        private Guna.UI.WinForms.GunaTransfarantPictureBox gunaTransfarantPictureBox1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaButton btn_stop;
        private Guna.UI.WinForms.GunaButton btnStart;
    }
}