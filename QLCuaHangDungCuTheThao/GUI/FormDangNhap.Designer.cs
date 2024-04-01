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
            this.lbSaiSDT = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.tbSDT = new RJCodeAdvance.RJControls.RJTextBox();
            this.btDangNhap = new RJCodeAdvance.RJControls.RJButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btClose = new RJCodeAdvance.RJControls.RJButton();
            this.groupBox1.SuspendLayout();
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
            this.label4.Location = new System.Drawing.Point(17, 149);
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
            this.tbMatKhau.Margin = new System.Windows.Forms.Padding(4);
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
            this.tbMatKhau._TextChanged += new System.EventHandler(this.tbMatKhau__TextChanged);
            // 
            // lbSaiSDT
            // 
            this.lbSaiSDT.AutoSize = true;
            this.lbSaiSDT.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSaiSDT.ForeColor = System.Drawing.Color.Brown;
            this.lbSaiSDT.Location = new System.Drawing.Point(18, 132);
            this.lbSaiSDT.Name = "lbSaiSDT";
            this.lbSaiSDT.Size = new System.Drawing.Size(181, 13);
            this.lbSaiSDT.TabIndex = 6;
            this.lbSaiSDT.Text = "Số điện thoại này chưa được đăng ký";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb.Location = new System.Drawing.Point(17, 71);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(111, 21);
            this.lb.TabIndex = 3;
            this.lb.Text = "Số điện thoại";
            // 
            // tbSDT
            // 
            this.tbSDT.BackColor = System.Drawing.SystemColors.Window;
            this.tbSDT.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(44)))));
            this.tbSDT.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.tbSDT.BorderRadius = 12;
            this.tbSDT.BorderSize = 2;
            this.tbSDT.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbSDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbSDT.Location = new System.Drawing.Point(12, 96);
            this.tbSDT.Margin = new System.Windows.Forms.Padding(4);
            this.tbSDT.Multiline = false;
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbSDT.PasswordChar = false;
            this.tbSDT.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbSDT.PlaceholderText = "";
            this.tbSDT.Size = new System.Drawing.Size(250, 32);
            this.tbSDT.TabIndex = 1;
            this.tbSDT.Texts = "";
            this.tbSDT.UnderlinedStyle = false;
            this.tbSDT._TextChanged += new System.EventHandler(this.tbSDT__TextChanged);
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
            this.btDangNhap.ForeColor = System.Drawing.Color.White;
            this.btDangNhap.Location = new System.Drawing.Point(46, 226);
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
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbSDT);
            this.groupBox1.Controls.Add(this.btDangNhap);
            this.groupBox1.Controls.Add(this.lb);
            this.groupBox1.Controls.Add(this.lbSaiMatKhau);
            this.groupBox1.Controls.Add(this.lbSaiSDT);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbMatKhau);
            this.groupBox1.Location = new System.Drawing.Point(35, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 362);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(15, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(253, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Vui lòng liên hệ quản lý hoặc quản trị viên hệ thống";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(45, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Quên mật khẩu / chưa có tài khoản?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(39, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 40);
            this.label5.TabIndex = 11;
            this.label5.Text = "ĐĂNG NHẬP";
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.GhostWhite;
            this.btClose.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.btClose.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btClose.BorderRadius = 12;
            this.btClose.BorderSize = 0;
            this.btClose.FlatAppearance.BorderSize = 0;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btClose.ForeColor = System.Drawing.Color.MediumPurple;
            this.btClose.Location = new System.Drawing.Point(310, 12);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(30, 30);
            this.btClose.TabIndex = 12;
            this.btClose.Text = "X";
            this.btClose.TextColor = System.Drawing.Color.MediumPurple;
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(352, 490);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDangNhap";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lb;
        private RJCodeAdvance.RJControls.RJTextBox tbSDT;
        private System.Windows.Forms.Label lbSaiSDT;
        private System.Windows.Forms.Label lbSaiMatKhau;
        private System.Windows.Forms.Label label4;
        private RJCodeAdvance.RJControls.RJTextBox tbMatKhau;
        private RJCodeAdvance.RJControls.RJButton btDangNhap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private RJCodeAdvance.RJControls.RJButton btClose;
    }
}