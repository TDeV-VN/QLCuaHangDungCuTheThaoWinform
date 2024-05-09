namespace GUI
{
    partial class FormDangNhap
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
            this.lbSaiMatKhau = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMatKhau = new RJCodeAdvance.RJControls.RJTextBox();
            this.lbSaiEmail = new System.Windows.Forms.Label();
            this.tbEmail = new RJCodeAdvance.RJControls.RJTextBox();
            this.btDangNhap = new RJCodeAdvance.RJControls.RJButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbQuenMK = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btClose = new RJCodeAdvance.RJControls.RJButton();
            this.panelDangNhap = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.btQuayLai = new FontAwesome.Sharp.IconButton();
            this.groupBox1.SuspendLayout();
            this.panelDangNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSaiMatKhau
            // 
            this.lbSaiMatKhau.AutoSize = true;
            this.lbSaiMatKhau.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSaiMatKhau.ForeColor = System.Drawing.Color.Brown;
            this.lbSaiMatKhau.Location = new System.Drawing.Point(18, 210);
            this.lbSaiMatKhau.Name = "lbSaiMatKhau";
            this.lbSaiMatKhau.Size = new System.Drawing.Size(69, 13);
            this.lbSaiMatKhau.TabIndex = 9;
            this.lbSaiMatKhau.Text = "Sai mật khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(17, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mật khẩu";
            // 
            // tbMatKhau
            // 
            this.tbMatKhau.BackColor = System.Drawing.SystemColors.Window;
            this.tbMatKhau.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(44)))));
            this.tbMatKhau.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.tbMatKhau.BorderRadius = 12;
            this.tbMatKhau.BorderSize = 2;
            this.tbMatKhau.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbMatKhau.Location = new System.Drawing.Point(12, 174);
            this.tbMatKhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbMatKhau.Multiline = false;
            this.tbMatKhau.Name = "tbMatKhau";
            this.tbMatKhau.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbMatKhau.PasswordChar = false;
            this.tbMatKhau.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbMatKhau.PlaceholderText = "";
            this.tbMatKhau.Size = new System.Drawing.Size(250, 32);
            this.tbMatKhau.TabIndex = 7;
            this.tbMatKhau.Texts = "";
            this.tbMatKhau.UnderlinedStyle = false;
            // 
            // lbSaiEmail
            // 
            this.lbSaiEmail.AutoSize = true;
            this.lbSaiEmail.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSaiEmail.ForeColor = System.Drawing.Color.Brown;
            this.lbSaiEmail.Location = new System.Drawing.Point(18, 128);
            this.lbSaiEmail.Name = "lbSaiEmail";
            this.lbSaiEmail.Size = new System.Drawing.Size(121, 13);
            this.lbSaiEmail.TabIndex = 6;
            this.lbSaiEmail.Text = "Tài khoản không tồn tại";
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.SystemColors.Window;
            this.tbEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(44)))));
            this.tbEmail.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.tbEmail.BorderRadius = 12;
            this.tbEmail.BorderSize = 2;
            this.tbEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbEmail.Location = new System.Drawing.Point(12, 92);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbEmail.Multiline = false;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbEmail.PasswordChar = false;
            this.tbEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbEmail.PlaceholderText = "";
            this.tbEmail.Size = new System.Drawing.Size(250, 32);
            this.tbEmail.TabIndex = 1;
            this.tbEmail.Texts = "";
            this.tbEmail.UnderlinedStyle = false;
            // 
            // btDangNhap
            // 
            this.btDangNhap.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btDangNhap.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btDangNhap.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btDangNhap.BorderRadius = 12;
            this.btDangNhap.BorderSize = 0;
            this.btDangNhap.FlatAppearance.BorderSize = 0;
            this.btDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDangNhap.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btDangNhap.ForeColor = System.Drawing.Color.White;
            this.btDangNhap.Location = new System.Drawing.Point(46, 232);
            this.btDangNhap.Name = "btDangNhap";
            this.btDangNhap.Size = new System.Drawing.Size(182, 40);
            this.btDangNhap.TabIndex = 10;
            this.btDangNhap.Text = "Đăng nhập";
            this.btDangNhap.TextColor = System.Drawing.Color.White;
            this.btDangNhap.UseVisualStyleBackColor = false;
            this.btDangNhap.Click += new System.EventHandler(this.btDangNhap_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbQuenMK);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbEmail);
            this.groupBox1.Controls.Add(this.btDangNhap);
            this.groupBox1.Controls.Add(this.lbSaiMatKhau);
            this.groupBox1.Controls.Add(this.lbSaiEmail);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbMatKhau);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(251, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 355);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // lbQuenMK
            // 
            this.lbQuenMK.AutoSize = true;
            this.lbQuenMK.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbQuenMK.Location = new System.Drawing.Point(18, 288);
            this.lbQuenMK.Name = "lbQuenMK";
            this.lbQuenMK.Size = new System.Drawing.Size(91, 13);
            this.lbQuenMK.TabIndex = 15;
            this.lbQuenMK.TabStop = true;
            this.lbQuenMK.Text = "Quên mật khẩu?";
            this.lbQuenMK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbQuenMK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbQuenMK_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(17, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(18, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Chưa có tài khoản? Liên hệ quản lý";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(14, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 40);
            this.label5.TabIndex = 11;
            this.label5.Text = "ĐĂNG NHẬP";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btClose.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.btClose.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btClose.BorderRadius = 12;
            this.btClose.BorderSize = 0;
            this.btClose.FlatAppearance.BorderSize = 0;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btClose.ForeColor = System.Drawing.Color.MediumPurple;
            this.btClose.Location = new System.Drawing.Point(658, 12);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(30, 30);
            this.btClose.TabIndex = 12;
            this.btClose.Text = "X";
            this.btClose.TextColor = System.Drawing.Color.MediumPurple;
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // panelDangNhap
            // 
            this.panelDangNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDangNhap.Controls.Add(this.iconPictureBox1);
            this.panelDangNhap.Controls.Add(this.groupBox1);
            this.panelDangNhap.Location = new System.Drawing.Point(76, 67);
            this.panelDangNhap.Name = "panelDangNhap";
            this.panelDangNhap.Size = new System.Drawing.Size(524, 355);
            this.panelDangNhap.TabIndex = 13;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.iconPictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconPictureBox1.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Black;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Black;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 252;
            this.iconPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(252, 355);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox1.TabIndex = 12;
            this.iconPictureBox1.TabStop = false;
            // 
            // btQuayLai
            // 
            this.btQuayLai.BackColor = System.Drawing.Color.Transparent;
            this.btQuayLai.FlatAppearance.BorderSize = 0;
            this.btQuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btQuayLai.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btQuayLai.IconColor = System.Drawing.Color.Black;
            this.btQuayLai.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btQuayLai.IconSize = 25;
            this.btQuayLai.Location = new System.Drawing.Point(12, 16);
            this.btQuayLai.Name = "btQuayLai";
            this.btQuayLai.Size = new System.Drawing.Size(40, 25);
            this.btQuayLai.TabIndex = 14;
            this.btQuayLai.UseVisualStyleBackColor = false;
            this.btQuayLai.Click += new System.EventHandler(this.btQuayLai_Click);
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.btQuayLai);
            this.Controls.Add(this.panelDangNhap);
            this.Controls.Add(this.btClose);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDangNhap";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelDangNhap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private RJCodeAdvance.RJControls.RJTextBox tbEmail;
        private System.Windows.Forms.Label lbSaiEmail;
        private System.Windows.Forms.Label lbSaiMatKhau;
        private System.Windows.Forms.Label label4;
        private RJCodeAdvance.RJControls.RJTextBox tbMatKhau;
        private RJCodeAdvance.RJControls.RJButton btDangNhap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private RJCodeAdvance.RJControls.RJButton btClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lbQuenMK;
        private System.Windows.Forms.Panel panelDangNhap;
        private FontAwesome.Sharp.IconButton btQuayLai;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}