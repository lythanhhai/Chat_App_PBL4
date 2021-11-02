
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
            this.btnStart = new System.Windows.Forms.Button();
            this.pbCamera = new System.Windows.Forms.PictureBox();
            this.btn_stop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamera)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbCamera
            // 
            this.cbbCamera.FormattingEnabled = true;
            this.cbbCamera.Location = new System.Drawing.Point(841, 835);
            this.cbbCamera.Name = "cbbCamera";
            this.cbbCamera.Size = new System.Drawing.Size(240, 28);
            this.cbbCamera.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(1292, 835);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(112, 43);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pbCamera
            // 
            this.pbCamera.Location = new System.Drawing.Point(12, 12);
            this.pbCamera.Name = "pbCamera";
            this.pbCamera.Size = new System.Drawing.Size(1468, 800);
            this.pbCamera.TabIndex = 1;
            this.pbCamera.TabStop = false;
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(1141, 835);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(112, 43);
            this.btn_stop.TabIndex = 3;
            this.btn_stop.Text = "stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // Cam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1492, 911);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pbCamera);
            this.Controls.Add(this.cbbCamera);
            this.Name = "Cam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cam";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Cam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCamera)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbCamera;
        private System.Windows.Forms.PictureBox pbCamera;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btn_stop;
    }
}