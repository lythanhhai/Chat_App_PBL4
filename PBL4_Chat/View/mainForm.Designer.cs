
namespace PBL4_Chat
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.btn_message = new Guna.UI.WinForms.GunaButton();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.gunaCirclePictureBox2 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.lbStatusPerson = new System.Windows.Forms.Label();
            this.lbNamePerson = new System.Windows.Forms.Label();
            this.gunaPanel3 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel6 = new Guna.UI.WinForms.GunaPanel();
            this.btn_search = new Guna.UI.WinForms.GunaButton();
            this.txt_search = new Guna.UI.WinForms.GunaTextBox();
            this.GunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.btnDangXuat = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_taoNhom = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaPanel4 = new Guna.UI.WinForms.GunaPanel();
            this.pn_chat = new Guna.UI.WinForms.GunaPanel();
            this.txt_message = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaLinkLabel1 = new Guna.UI.WinForms.GunaLinkLabel();
            this.gunaPanel8 = new Guna.UI.WinForms.GunaPanel();
            this.lbName_Receiver = new Guna.UI.WinForms.GunaLabel();
            this.GunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.GunaCircleButton1 = new Guna.UI.WinForms.GunaCircleButton();
            this.lbStatus = new Guna.UI.WinForms.GunaLabel();
            this.GunaImageButton5 = new Guna.UI.WinForms.GunaImageButton();
            this.GunaImageButton4 = new Guna.UI.WinForms.GunaImageButton();
            this.gunaPanel5 = new Guna.UI.WinForms.GunaPanel();
            this.GunaElipsePanel5 = new Guna.UI.WinForms.GunaElipsePanel();
            this.btn_chooseFile = new Guna.UI.WinForms.GunaImageButton();
            this.btn_chooseImg = new Guna.UI.WinForms.GunaImageButton();
            this.txt_send = new Guna.UI.WinForms.GunaTextBox();
            this.btn_send = new Guna.UI.WinForms.GunaButton();
            this.panel_listUser = new System.Windows.Forms.FlowLayoutPanel();
            this.Opendialog = new System.Windows.Forms.OpenFileDialog();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            this.gunaPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox2)).BeginInit();
            this.gunaPanel3.SuspendLayout();
            this.gunaPanel6.SuspendLayout();
            this.gunaPanel4.SuspendLayout();
            this.pn_chat.SuspendLayout();
            this.txt_message.SuspendLayout();
            this.gunaPanel8.SuspendLayout();
            this.gunaPanel5.SuspendLayout();
            this.GunaElipsePanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(22)))), ((int)(((byte)(32)))));
            this.gunaPanel1.Controls.Add(this.btn_message);
            this.gunaPanel1.Controls.Add(this.gunaCirclePictureBox1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(96, 959);
            this.gunaPanel1.TabIndex = 0;
            // 
            // btn_message
            // 
            this.btn_message.AnimationHoverSpeed = 0.07F;
            this.btn_message.AnimationSpeed = 0.03F;
            this.btn_message.BackColor = System.Drawing.Color.Transparent;
            this.btn_message.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(154)))), ((int)(((byte)(250)))));
            this.btn_message.BorderColor = System.Drawing.Color.Black;
            this.btn_message.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_message.FocusedColor = System.Drawing.Color.Empty;
            this.btn_message.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_message.ForeColor = System.Drawing.Color.White;
            this.btn_message.Image = global::PBL4_Chat.Properties.Resources.message;
            this.btn_message.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_message.ImageSize = new System.Drawing.Size(18, 18);
            this.btn_message.Location = new System.Drawing.Point(0, 216);
            this.btn_message.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_message.Name = "btn_message";
            this.btn_message.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(168)))), ((int)(((byte)(251)))));
            this.btn_message.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_message.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_message.OnHoverImage = null;
            this.btn_message.OnPressedColor = System.Drawing.Color.Black;
            this.btn_message.Radius = 4;
            this.btn_message.Size = new System.Drawing.Size(96, 61);
            this.btn_message.TabIndex = 20;
            this.btn_message.Click += new System.EventHandler(this.btn_message_Click);
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.SystemColors.Window;
            this.gunaCirclePictureBox1.Image = global::PBL4_Chat.Properties.Resources.profile;
            this.gunaCirclePictureBox1.InitialImage = global::PBL4_Chat.Properties.Resources.profile;
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(3, 12);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(89, 88);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox1.TabIndex = 0;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(22)))), ((int)(((byte)(32)))));
            this.gunaPanel2.Controls.Add(this.gunaCirclePictureBox2);
            this.gunaPanel2.Controls.Add(this.lbStatusPerson);
            this.gunaPanel2.Controls.Add(this.lbNamePerson);
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.gunaPanel2.Location = new System.Drawing.Point(1192, 0);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(255, 959);
            this.gunaPanel2.TabIndex = 1;
            // 
            // gunaCirclePictureBox2
            // 
            this.gunaCirclePictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaCirclePictureBox2.BaseColor = System.Drawing.SystemColors.Window;
            this.gunaCirclePictureBox2.Image = global::PBL4_Chat.Properties.Resources.profile;
            this.gunaCirclePictureBox2.InitialImage = global::PBL4_Chat.Properties.Resources.profile;
            this.gunaCirclePictureBox2.Location = new System.Drawing.Point(55, 39);
            this.gunaCirclePictureBox2.Name = "gunaCirclePictureBox2";
            this.gunaCirclePictureBox2.Size = new System.Drawing.Size(151, 146);
            this.gunaCirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox2.TabIndex = 4;
            this.gunaCirclePictureBox2.TabStop = false;
            this.gunaCirclePictureBox2.UseTransfarantBackground = false;
            // 
            // lbStatusPerson
            // 
            this.lbStatusPerson.AutoSize = true;
            this.lbStatusPerson.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbStatusPerson.Location = new System.Drawing.Point(110, 241);
            this.lbStatusPerson.Name = "lbStatusPerson";
            this.lbStatusPerson.Size = new System.Drawing.Size(51, 20);
            this.lbStatusPerson.TabIndex = 3;
            this.lbStatusPerson.Text = "online";
            // 
            // lbNamePerson
            // 
            this.lbNamePerson.AutoSize = true;
            this.lbNamePerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNamePerson.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbNamePerson.Location = new System.Drawing.Point(94, 203);
            this.lbNamePerson.Name = "lbNamePerson";
            this.lbNamePerson.Size = new System.Drawing.Size(79, 29);
            this.lbNamePerson.TabIndex = 2;
            this.lbNamePerson.Text = "label1";
            // 
            // gunaPanel3
            // 
            this.gunaPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.gunaPanel3.Controls.Add(this.gunaPanel6);
            this.gunaPanel3.Controls.Add(this.btnDangXuat);
            this.gunaPanel3.Controls.Add(this.btn_taoNhom);
            this.gunaPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel3.Location = new System.Drawing.Point(96, 0);
            this.gunaPanel3.Name = "gunaPanel3";
            this.gunaPanel3.Size = new System.Drawing.Size(1096, 100);
            this.gunaPanel3.TabIndex = 2;
            // 
            // gunaPanel6
            // 
            this.gunaPanel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaPanel6.Controls.Add(this.btn_search);
            this.gunaPanel6.Controls.Add(this.txt_search);
            this.gunaPanel6.Controls.Add(this.GunaLabel1);
            this.gunaPanel6.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gunaPanel6.Name = "gunaPanel6";
            this.gunaPanel6.Size = new System.Drawing.Size(387, 100);
            this.gunaPanel6.TabIndex = 3;
            // 
            // btn_search
            // 
            this.btn_search.AnimationHoverSpeed = 0.07F;
            this.btn_search.AnimationSpeed = 0.03F;
            this.btn_search.BackColor = System.Drawing.Color.Transparent;
            this.btn_search.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.btn_search.BorderColor = System.Drawing.Color.Black;
            this.btn_search.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_search.FocusedColor = System.Drawing.Color.Empty;
            this.btn_search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Image = global::PBL4_Chat.Properties.Resources.search;
            this.btn_search.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_search.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_search.Location = new System.Drawing.Point(319, 38);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_search.Name = "btn_search";
            this.btn_search.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(168)))), ((int)(((byte)(251)))));
            this.btn_search.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_search.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_search.OnHoverImage = null;
            this.btn_search.OnPressedColor = System.Drawing.Color.Black;
            this.btn_search.Radius = 4;
            this.btn_search.Size = new System.Drawing.Size(51, 49);
            this.btn_search.TabIndex = 2;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.Color.Transparent;
            this.txt_search.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.txt_search.BorderColor = System.Drawing.Color.Silver;
            this.txt_search.BorderSize = 0;
            this.txt_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_search.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_search.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_search.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_search.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txt_search.ForeColor = System.Drawing.Color.Black;
            this.txt_search.Location = new System.Drawing.Point(18, 37);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_search.Name = "txt_search";
            this.txt_search.PasswordChar = '\0';
            this.txt_search.Radius = 4;
            this.txt_search.SelectedText = "";
            this.txt_search.Size = new System.Drawing.Size(293, 49);
            this.txt_search.TabIndex = 2;
            this.txt_search.Text = "...........";
            this.txt_search.TextChanged += new System.EventHandler(this.btn_search_Click);
            // 
            // GunaLabel1
            // 
            this.GunaLabel1.AutoSize = true;
            this.GunaLabel1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(212)))), ((int)(((byte)(213)))));
            this.GunaLabel1.Location = new System.Drawing.Point(13, 2);
            this.GunaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GunaLabel1.Name = "GunaLabel1";
            this.GunaLabel1.Size = new System.Drawing.Size(57, 30);
            this.GunaLabel1.TabIndex = 2;
            this.GunaLabel1.Text = "Chat";
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.AnimationHoverSpeed = 0.07F;
            this.btnDangXuat.AnimationSpeed = 0.03F;
            this.btnDangXuat.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnDangXuat.BorderColor = System.Drawing.Color.Black;
            this.btnDangXuat.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnDangXuat.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnDangXuat.CheckedForeColor = System.Drawing.Color.White;
            this.btnDangXuat.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.CheckedImage")));
            this.btnDangXuat.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnDangXuat.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDangXuat.FocusedColor = System.Drawing.Color.Empty;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.Image = null;
            this.btnDangXuat.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDangXuat.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDangXuat.Location = new System.Drawing.Point(982, 3);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnDangXuat.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDangXuat.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDangXuat.OnHoverImage = null;
            this.btnDangXuat.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDangXuat.OnPressedColor = System.Drawing.Color.Black;
            this.btnDangXuat.Size = new System.Drawing.Size(111, 63);
            this.btnDangXuat.TabIndex = 1;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDangXuat.Click += new System.EventHandler(this.btnTrove_Click);
            // 
            // btn_taoNhom
            // 
            this.btn_taoNhom.AnimationHoverSpeed = 0.07F;
            this.btn_taoNhom.AnimationSpeed = 0.03F;
            this.btn_taoNhom.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_taoNhom.BorderColor = System.Drawing.Color.Black;
            this.btn_taoNhom.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_taoNhom.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_taoNhom.CheckedForeColor = System.Drawing.Color.White;
            this.btn_taoNhom.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_taoNhom.CheckedImage")));
            this.btn_taoNhom.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_taoNhom.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_taoNhom.FocusedColor = System.Drawing.Color.Empty;
            this.btn_taoNhom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_taoNhom.ForeColor = System.Drawing.Color.White;
            this.btn_taoNhom.Image = null;
            this.btn_taoNhom.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_taoNhom.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_taoNhom.Location = new System.Drawing.Point(780, 3);
            this.btn_taoNhom.Name = "btn_taoNhom";
            this.btn_taoNhom.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_taoNhom.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_taoNhom.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_taoNhom.OnHoverImage = null;
            this.btn_taoNhom.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_taoNhom.OnPressedColor = System.Drawing.Color.Black;
            this.btn_taoNhom.Size = new System.Drawing.Size(180, 63);
            this.btn_taoNhom.TabIndex = 0;
            this.btn_taoNhom.Text = "Tạo nhóm";
            this.btn_taoNhom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_taoNhom.Click += new System.EventHandler(this.btn_taoNhom_Click);
            // 
            // gunaPanel4
            // 
            this.gunaPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(47)))));
            this.gunaPanel4.Controls.Add(this.pn_chat);
            this.gunaPanel4.Controls.Add(this.panel_listUser);
            this.gunaPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel4.Location = new System.Drawing.Point(96, 100);
            this.gunaPanel4.Name = "gunaPanel4";
            this.gunaPanel4.Size = new System.Drawing.Size(1096, 859);
            this.gunaPanel4.TabIndex = 3;
            // 
            // pn_chat
            // 
            this.pn_chat.Controls.Add(this.txt_message);
            this.pn_chat.Controls.Add(this.gunaPanel8);
            this.pn_chat.Controls.Add(this.gunaPanel5);
            this.pn_chat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_chat.Location = new System.Drawing.Point(387, 0);
            this.pn_chat.Name = "pn_chat";
            this.pn_chat.Size = new System.Drawing.Size(709, 859);
            this.pn_chat.TabIndex = 30;
            // 
            // txt_message
            // 
            this.txt_message.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_message.AutoScroll = true;
            this.txt_message.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_message.Controls.Add(this.gunaLinkLabel1);
            this.txt_message.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.txt_message.Location = new System.Drawing.Point(0, 116);
            this.txt_message.MaximumSize = new System.Drawing.Size(709, 658);
            this.txt_message.MinimumSize = new System.Drawing.Size(709, 658);
            this.txt_message.Name = "txt_message";
            this.txt_message.Size = new System.Drawing.Size(709, 658);
            this.txt_message.TabIndex = 17;
            this.txt_message.WrapContents = false;
            // 
            // gunaLinkLabel1
            // 
            this.gunaLinkLabel1.ActiveLinkColor = System.Drawing.Color.Silver;
            this.gunaLinkLabel1.AutoSize = true;
            this.gunaLinkLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLinkLabel1.Location = new System.Drawing.Point(3, 0);
            this.gunaLinkLabel1.Name = "gunaLinkLabel1";
            this.gunaLinkLabel1.Size = new System.Drawing.Size(134, 25);
            this.gunaLinkLabel1.TabIndex = 0;
            this.gunaLinkLabel1.TabStop = true;
            this.gunaLinkLabel1.Text = "gunaLinkLabel1";
            this.gunaLinkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            // 
            // gunaPanel8
            // 
            this.gunaPanel8.Controls.Add(this.lbName_Receiver);
            this.gunaPanel8.Controls.Add(this.GunaSeparator1);
            this.gunaPanel8.Controls.Add(this.GunaCircleButton1);
            this.gunaPanel8.Controls.Add(this.lbStatus);
            this.gunaPanel8.Controls.Add(this.GunaImageButton5);
            this.gunaPanel8.Controls.Add(this.GunaImageButton4);
            this.gunaPanel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel8.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel8.Name = "gunaPanel8";
            this.gunaPanel8.Size = new System.Drawing.Size(709, 118);
            this.gunaPanel8.TabIndex = 2;
            // 
            // lbName_Receiver
            // 
            this.lbName_Receiver.AutoSize = true;
            this.lbName_Receiver.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbName_Receiver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(212)))), ((int)(((byte)(213)))));
            this.lbName_Receiver.Location = new System.Drawing.Point(8, 26);
            this.lbName_Receiver.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName_Receiver.Name = "lbName_Receiver";
            this.lbName_Receiver.Size = new System.Drawing.Size(70, 28);
            this.lbName_Receiver.TabIndex = 25;
            this.lbName_Receiver.Text = "Hai Ly";
            // 
            // GunaSeparator1
            // 
            this.GunaSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.GunaSeparator1.CausesValidation = false;
            this.GunaSeparator1.LineColor = System.Drawing.Color.White;
            this.GunaSeparator1.Location = new System.Drawing.Point(0, 103);
            this.GunaSeparator1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GunaSeparator1.Name = "GunaSeparator1";
            this.GunaSeparator1.Size = new System.Drawing.Size(709, 15);
            this.GunaSeparator1.TabIndex = 24;
            // 
            // GunaCircleButton1
            // 
            this.GunaCircleButton1.AnimationHoverSpeed = 0.07F;
            this.GunaCircleButton1.AnimationSpeed = 0.03F;
            this.GunaCircleButton1.BackColor = System.Drawing.Color.Transparent;
            this.GunaCircleButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(34)))), ((int)(((byte)(41)))));
            this.GunaCircleButton1.BorderColor = System.Drawing.Color.Black;
            this.GunaCircleButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.GunaCircleButton1.FocusedColor = System.Drawing.Color.Empty;
            this.GunaCircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GunaCircleButton1.ForeColor = System.Drawing.Color.White;
            this.GunaCircleButton1.Image = global::PBL4_Chat.Properties.Resources.Next_page_24px;
            this.GunaCircleButton1.ImageSize = new System.Drawing.Size(24, 24);
            this.GunaCircleButton1.Location = new System.Drawing.Point(642, 26);
            this.GunaCircleButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GunaCircleButton1.Name = "GunaCircleButton1";
            this.GunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(168)))), ((int)(((byte)(251)))));
            this.GunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.GunaCircleButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.GunaCircleButton1.OnHoverImage = null;
            this.GunaCircleButton1.OnPressedColor = System.Drawing.Color.Black;
            this.GunaCircleButton1.Size = new System.Drawing.Size(60, 59);
            this.GunaCircleButton1.TabIndex = 29;
            this.GunaCircleButton1.UseTransfarantBackground = true;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(159)))), ((int)(((byte)(163)))));
            this.lbStatus.Location = new System.Drawing.Point(9, 66);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(46, 19);
            this.lbStatus.TabIndex = 26;
            this.lbStatus.Text = "online";
            // 
            // GunaImageButton5
            // 
            this.GunaImageButton5.DialogResult = System.Windows.Forms.DialogResult.None;
            this.GunaImageButton5.Image = global::PBL4_Chat.Properties.Resources.Video_Call_24px;
            this.GunaImageButton5.ImageSize = new System.Drawing.Size(24, 24);
            this.GunaImageButton5.Location = new System.Drawing.Point(570, 26);
            this.GunaImageButton5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GunaImageButton5.Name = "GunaImageButton5";
            this.GunaImageButton5.OnHoverImage = null;
            this.GunaImageButton5.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.GunaImageButton5.Size = new System.Drawing.Size(64, 59);
            this.GunaImageButton5.TabIndex = 28;
            // 
            // GunaImageButton4
            // 
            this.GunaImageButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.GunaImageButton4.Image = global::PBL4_Chat.Properties.Resources.User_Account_16px;
            this.GunaImageButton4.ImageSize = new System.Drawing.Size(24, 24);
            this.GunaImageButton4.Location = new System.Drawing.Point(492, 26);
            this.GunaImageButton4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GunaImageButton4.Name = "GunaImageButton4";
            this.GunaImageButton4.OnHoverImage = null;
            this.GunaImageButton4.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.GunaImageButton4.Size = new System.Drawing.Size(57, 59);
            this.GunaImageButton4.TabIndex = 27;
            // 
            // gunaPanel5
            // 
            this.gunaPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(47)))));
            this.gunaPanel5.Controls.Add(this.GunaElipsePanel5);
            this.gunaPanel5.Controls.Add(this.btn_send);
            this.gunaPanel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaPanel5.Location = new System.Drawing.Point(0, 767);
            this.gunaPanel5.Name = "gunaPanel5";
            this.gunaPanel5.Size = new System.Drawing.Size(709, 92);
            this.gunaPanel5.TabIndex = 1;
            // 
            // GunaElipsePanel5
            // 
            this.GunaElipsePanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(22)))), ((int)(((byte)(32)))));
            this.GunaElipsePanel5.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(22)))), ((int)(((byte)(32)))));
            this.GunaElipsePanel5.Controls.Add(this.btn_chooseFile);
            this.GunaElipsePanel5.Controls.Add(this.btn_chooseImg);
            this.GunaElipsePanel5.Controls.Add(this.txt_send);
            this.GunaElipsePanel5.Location = new System.Drawing.Point(0, 5);
            this.GunaElipsePanel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GunaElipsePanel5.Name = "GunaElipsePanel5";
            this.GunaElipsePanel5.Size = new System.Drawing.Size(623, 87);
            this.GunaElipsePanel5.TabIndex = 18;
            // 
            // btn_chooseFile
            // 
            this.btn_chooseFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(22)))), ((int)(((byte)(32)))));
            this.btn_chooseFile.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_chooseFile.Image = global::PBL4_Chat.Properties.Resources.Attach_24px;
            this.btn_chooseFile.ImageSize = new System.Drawing.Size(24, 24);
            this.btn_chooseFile.Location = new System.Drawing.Point(483, 0);
            this.btn_chooseFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_chooseFile.Name = "btn_chooseFile";
            this.btn_chooseFile.OnHoverImage = null;
            this.btn_chooseFile.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btn_chooseFile.Size = new System.Drawing.Size(66, 87);
            this.btn_chooseFile.TabIndex = 2;
            this.btn_chooseFile.Click += new System.EventHandler(this.btn_chooseFile_Click);
            // 
            // btn_chooseImg
            // 
            this.btn_chooseImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(22)))), ((int)(((byte)(32)))));
            this.btn_chooseImg.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_chooseImg.Image = global::PBL4_Chat.Properties.Resources.Instagram_24px;
            this.btn_chooseImg.ImageSize = new System.Drawing.Size(24, 24);
            this.btn_chooseImg.Location = new System.Drawing.Point(552, 0);
            this.btn_chooseImg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_chooseImg.Name = "btn_chooseImg";
            this.btn_chooseImg.OnHoverImage = null;
            this.btn_chooseImg.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btn_chooseImg.Size = new System.Drawing.Size(67, 87);
            this.btn_chooseImg.TabIndex = 1;
            this.btn_chooseImg.Click += new System.EventHandler(this.btn_chooseImg_Click);
            // 
            // txt_send
            // 
            this.txt_send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(22)))), ((int)(((byte)(32)))));
            this.txt_send.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.txt_send.BorderColor = System.Drawing.Color.Silver;
            this.txt_send.BorderSize = 0;
            this.txt_send.CausesValidation = false;
            this.txt_send.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_send.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.txt_send.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_send.FocusedForeColor = System.Drawing.Color.White;
            this.txt_send.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_send.ForeColor = System.Drawing.Color.Black;
            this.txt_send.Location = new System.Drawing.Point(0, 5);
            this.txt_send.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_send.Name = "txt_send";
            this.txt_send.PasswordChar = '\0';
            this.txt_send.SelectedText = "";
            this.txt_send.Size = new System.Drawing.Size(480, 77);
            this.txt_send.TabIndex = 0;
            this.txt_send.Text = "Ok";
            // 
            // btn_send
            // 
            this.btn_send.AnimationHoverSpeed = 0.07F;
            this.btn_send.AnimationSpeed = 0.03F;
            this.btn_send.BackColor = System.Drawing.Color.Transparent;
            this.btn_send.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(154)))), ((int)(((byte)(250)))));
            this.btn_send.BorderColor = System.Drawing.Color.Black;
            this.btn_send.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_send.FocusedColor = System.Drawing.Color.Empty;
            this.btn_send.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_send.ForeColor = System.Drawing.Color.White;
            this.btn_send.Image = global::PBL4_Chat.Properties.Resources.send;
            this.btn_send.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_send.ImageSize = new System.Drawing.Size(18, 18);
            this.btn_send.Location = new System.Drawing.Point(624, 10);
            this.btn_send.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_send.Name = "btn_send";
            this.btn_send.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(168)))), ((int)(((byte)(251)))));
            this.btn_send.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_send.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_send.OnHoverImage = null;
            this.btn_send.OnPressedColor = System.Drawing.Color.Black;
            this.btn_send.Radius = 4;
            this.btn_send.Size = new System.Drawing.Size(85, 77);
            this.btn_send.TabIndex = 19;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // panel_listUser
            // 
            this.panel_listUser.AutoScroll = true;
            this.panel_listUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_listUser.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panel_listUser.Location = new System.Drawing.Point(0, 0);
            this.panel_listUser.Name = "panel_listUser";
            this.panel_listUser.Padding = new System.Windows.Forms.Padding(0, 113, 0, 0);
            this.panel_listUser.Size = new System.Drawing.Size(387, 859);
            this.panel_listUser.TabIndex = 0;
            this.panel_listUser.Visible = false;
            this.panel_listUser.WrapContents = false;
            // 
            // Opendialog
            // 
            this.Opendialog.FileName = "openFileDialog1";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 959);
            this.Controls.Add(this.gunaPanel4);
            this.Controls.Add(this.gunaPanel3);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.gunaPanel1);
            this.Name = "mainForm";
            this.Text = "mainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.gunaPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox2)).EndInit();
            this.gunaPanel3.ResumeLayout(false);
            this.gunaPanel6.ResumeLayout(false);
            this.gunaPanel6.PerformLayout();
            this.gunaPanel4.ResumeLayout(false);
            this.pn_chat.ResumeLayout(false);
            this.txt_message.ResumeLayout(false);
            this.txt_message.PerformLayout();
            this.gunaPanel8.ResumeLayout(false);
            this.gunaPanel8.PerformLayout();
            this.gunaPanel5.ResumeLayout(false);
            this.GunaElipsePanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaPanel gunaPanel3;
        private Guna.UI.WinForms.GunaPanel gunaPanel4;
        private System.Windows.Forms.FlowLayoutPanel panel_listUser;
        private Guna.UI.WinForms.GunaPanel gunaPanel5;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        internal Guna.UI.WinForms.GunaPanel gunaPanel6;
        internal Guna.UI.WinForms.GunaButton btn_search;
        internal Guna.UI.WinForms.GunaTextBox txt_search;
        internal Guna.UI.WinForms.GunaLabel GunaLabel1;
        private Guna.UI.WinForms.GunaAdvenceButton btn_taoNhom;
        internal Guna.UI.WinForms.GunaButton btn_send;
        internal Guna.UI.WinForms.GunaElipsePanel GunaElipsePanel5;
        internal Guna.UI.WinForms.GunaImageButton btn_chooseFile;
        internal Guna.UI.WinForms.GunaImageButton btn_chooseImg;
        internal Guna.UI.WinForms.GunaTextBox txt_send;
        internal Guna.UI.WinForms.GunaPanel pn_chat;
        private Guna.UI.WinForms.GunaPanel gunaPanel8;
        internal Guna.UI.WinForms.GunaLabel lbName_Receiver;
        internal Guna.UI.WinForms.GunaSeparator GunaSeparator1;
        internal Guna.UI.WinForms.GunaCircleButton GunaCircleButton1;
        internal Guna.UI.WinForms.GunaLabel lbStatus;
        internal Guna.UI.WinForms.GunaImageButton GunaImageButton5;
        internal Guna.UI.WinForms.GunaImageButton GunaImageButton4;
        private Guna.UI.WinForms.GunaAdvenceButton btnDangXuat;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox2;
        private System.Windows.Forms.Label lbStatusPerson;
        private System.Windows.Forms.Label lbNamePerson;
        internal Guna.UI.WinForms.GunaButton btn_message;
        private System.Windows.Forms.OpenFileDialog Opendialog;
        internal System.Windows.Forms.FlowLayoutPanel txt_message;
        private Guna.UI.WinForms.GunaLinkLabel gunaLinkLabel1;
    }
}

