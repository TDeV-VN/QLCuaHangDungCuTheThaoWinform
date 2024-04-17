namespace GUI
{
    partial class FormOTP
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
            this.panelOTP = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbGuiLaiMa = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.btXacThuc = new RJCodeAdvance.RJControls.RJButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMa = new RJCodeAdvance.RJControls.RJTextBox();
            this.lbSaiMa = new System.Windows.Forms.Label();
            this.btGuiMa = new RJCodeAdvance.RJControls.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEmail = new RJCodeAdvance.RJControls.RJTextBox();
            this.lbSaiEmail = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelOTP.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOTP
            // 
            this.panelOTP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelOTP.Controls.Add(this.groupBox1);
            this.panelOTP.Location = new System.Drawing.Point(117, 90);
            this.panelOTP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelOTP.Name = "panelOTP";
            this.panelOTP.Size = new System.Drawing.Size(699, 437);
            this.panelOTP.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(699, 437);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // lbGuiLaiMa
            // 
            this.lbGuiLaiMa.AutoSize = true;
            this.lbGuiLaiMa.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbGuiLaiMa.Location = new System.Drawing.Point(233, 290);
            this.lbGuiLaiMa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGuiLaiMa.Name = "lbGuiLaiMa";
            this.lbGuiLaiMa.Size = new System.Drawing.Size(67, 17);
            this.lbGuiLaiMa.TabIndex = 24;
            this.lbGuiLaiMa.TabStop = true;
            this.lbGuiLaiMa.Text = "Gửi lại mã";
            this.lbGuiLaiMa.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(31, 290);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 28);
            this.label4.TabIndex = 23;
            this.label4.Text = "Kiểm tra email của bạn.";
            // 
            // btXacThuc
            // 
            this.btXacThuc.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btXacThuc.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btXacThuc.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btXacThuc.BorderRadius = 12;
            this.btXacThuc.BorderSize = 0;
            this.btXacThuc.FlatAppearance.BorderSize = 0;
            this.btXacThuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXacThuc.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btXacThuc.ForeColor = System.Drawing.Color.White;
            this.btXacThuc.Location = new System.Drawing.Point(22, 243);
            this.btXacThuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btXacThuc.Name = "btXacThuc";
            this.btXacThuc.Size = new System.Drawing.Size(333, 43);
            this.btXacThuc.TabIndex = 22;
            this.btXacThuc.Text = "Xác thực";
            this.btXacThuc.TextColor = System.Drawing.Color.White;
            this.btXacThuc.UseVisualStyleBackColor = false;
            this.btXacThuc.Click += new System.EventHandler(this.btXacThuc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(29, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 28);
            this.label2.TabIndex = 21;
            this.label2.Text = "Mã xác thực";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbMa
            // 
            this.tbMa.BackColor = System.Drawing.SystemColors.Window;
            this.tbMa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(44)))));
            this.tbMa.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.tbMa.BorderRadius = 12;
            this.tbMa.BorderSize = 2;
            this.tbMa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbMa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbMa.Location = new System.Drawing.Point(22, 155);
            this.tbMa.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbMa.Multiline = false;
            this.tbMa.Name = "tbMa";
            this.tbMa.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.tbMa.PasswordChar = false;
            this.tbMa.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbMa.PlaceholderText = "";
            this.tbMa.Size = new System.Drawing.Size(333, 42);
            this.tbMa.TabIndex = 19;
            this.tbMa.Texts = "";
            this.tbMa.UnderlinedStyle = false;
            // 
            // lbSaiMa
            // 
            this.lbSaiMa.AutoSize = true;
            this.lbSaiMa.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSaiMa.ForeColor = System.Drawing.Color.Brown;
            this.lbSaiMa.Location = new System.Drawing.Point(30, 201);
            this.lbSaiMa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSaiMa.Name = "lbSaiMa";
            this.lbSaiMa.Size = new System.Drawing.Size(247, 19);
            this.lbSaiMa.TabIndex = 20;
            this.lbSaiMa.Text = "Mã xác thực không khớp hoặc hết hạn";
            // 
            // btGuiMa
            // 
            this.btGuiMa.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btGuiMa.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btGuiMa.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btGuiMa.BorderRadius = 12;
            this.btGuiMa.BorderSize = 0;
            this.btGuiMa.FlatAppearance.BorderSize = 0;
            this.btGuiMa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGuiMa.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btGuiMa.ForeColor = System.Drawing.Color.White;
            this.btGuiMa.Location = new System.Drawing.Point(377, 55);
            this.btGuiMa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btGuiMa.Name = "btGuiMa";
            this.btGuiMa.Size = new System.Drawing.Size(103, 39);
            this.btGuiMa.TabIndex = 18;
            this.btGuiMa.Text = "Gửi mã";
            this.btGuiMa.TextColor = System.Drawing.Color.White;
            this.btGuiMa.UseVisualStyleBackColor = false;
            this.btGuiMa.Click += new System.EventHandler(this.btGuiMa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(29, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 28);
            this.label1.TabIndex = 17;
            this.label1.Text = "Email";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.tbEmail.Location = new System.Drawing.Point(22, 52);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbEmail.Multiline = false;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.tbEmail.PasswordChar = false;
            this.tbEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbEmail.PlaceholderText = "";
            this.tbEmail.Size = new System.Drawing.Size(333, 42);
            this.tbEmail.TabIndex = 15;
            this.tbEmail.Texts = "";
            this.tbEmail.UnderlinedStyle = false;
            // 
            // lbSaiEmail
            // 
            this.lbSaiEmail.AutoSize = true;
            this.lbSaiEmail.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSaiEmail.ForeColor = System.Drawing.Color.Brown;
            this.lbSaiEmail.Location = new System.Drawing.Point(30, 99);
            this.lbSaiEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSaiEmail.Name = "lbSaiEmail";
            this.lbSaiEmail.Size = new System.Drawing.Size(160, 19);
            this.lbSaiEmail.TabIndex = 16;
            this.lbSaiEmail.Text = "Tài khoản không tồn tại";
            this.lbSaiEmail.Click += new System.EventHandler(this.lbSaiEmail_Click);
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(4, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(691, 61);
            this.label5.TabIndex = 11;
            this.label5.Text = "Xác thực danh tính";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbGuiLaiMa);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btGuiMa);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btXacThuc);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbMa);
            this.panel1.Controls.Add(this.lbSaiMa);
            this.panel1.Controls.Add(this.tbEmail);
            this.panel1.Controls.Add(this.lbSaiEmail);
            this.panel1.Location = new System.Drawing.Point(155, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 319);
            this.panel1.TabIndex = 25;
            // 
            // FormOTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 615);
            this.Controls.Add(this.panelOTP);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormOTP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormOTP";
            this.panelOTP.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOTP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private RJCodeAdvance.RJControls.RJTextBox tbEmail;
        private System.Windows.Forms.Label lbSaiEmail;
        private RJCodeAdvance.RJControls.RJButton btGuiMa;
        private RJCodeAdvance.RJControls.RJButton btXacThuc;
        private System.Windows.Forms.Label label2;
        private RJCodeAdvance.RJControls.RJTextBox tbMa;
        private System.Windows.Forms.Label lbSaiMa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel lbGuiLaiMa;
        private System.Windows.Forms.Panel panel1;
    }
}