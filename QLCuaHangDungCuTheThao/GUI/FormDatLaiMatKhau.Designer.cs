namespace GUI
{
    partial class FormDatLaiMatKhau
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
            this.panelDatLaiMatKhau = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btDatLai = new RJCodeAdvance.RJControls.RJButton();
            this.lbSaiMa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMatKhau = new RJCodeAdvance.RJControls.RJTextBox();
            this.tbXacNhanMK = new RJCodeAdvance.RJControls.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelDatLaiMatKhau.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDatLaiMatKhau
            // 
            this.panelDatLaiMatKhau.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDatLaiMatKhau.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelDatLaiMatKhau.Controls.Add(this.groupBox1);
            this.panelDatLaiMatKhau.Location = new System.Drawing.Point(99, 62);
            this.panelDatLaiMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.panelDatLaiMatKhau.Name = "panelDatLaiMatKhau";
            this.panelDatLaiMatKhau.Size = new System.Drawing.Size(699, 437);
            this.panelDatLaiMatKhau.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(699, 437);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btDatLai);
            this.panel1.Controls.Add(this.lbSaiMa);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbMatKhau);
            this.panel1.Controls.Add(this.tbXacNhanMK);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(175, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 297);
            this.panel1.TabIndex = 29;
            // 
            // btDatLai
            // 
            this.btDatLai.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btDatLai.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btDatLai.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btDatLai.BorderRadius = 12;
            this.btDatLai.BorderSize = 0;
            this.btDatLai.FlatAppearance.BorderSize = 0;
            this.btDatLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDatLai.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btDatLai.ForeColor = System.Drawing.Color.White;
            this.btDatLai.Location = new System.Drawing.Point(5, 225);
            this.btDatLai.Margin = new System.Windows.Forms.Padding(4);
            this.btDatLai.Name = "btDatLai";
            this.btDatLai.Size = new System.Drawing.Size(333, 43);
            this.btDatLai.TabIndex = 28;
            this.btDatLai.Text = "Đặt lại";
            this.btDatLai.TextColor = System.Drawing.Color.White;
            this.btDatLai.UseVisualStyleBackColor = false;
            // 
            // lbSaiMa
            // 
            this.lbSaiMa.AutoSize = true;
            this.lbSaiMa.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSaiMa.ForeColor = System.Drawing.Color.Brown;
            this.lbSaiMa.Location = new System.Drawing.Point(13, 84);
            this.lbSaiMa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSaiMa.Name = "lbSaiMa";
            this.lbSaiMa.Size = new System.Drawing.Size(227, 19);
            this.lbSaiMa.TabIndex = 23;
            this.lbSaiMa.Text = "Mật khẩu phải chứa ít nhất 8 ký tự";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 28);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nhập lại mật khẩu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.tbMatKhau.Location = new System.Drawing.Point(5, 38);
            this.tbMatKhau.Margin = new System.Windows.Forms.Padding(5);
            this.tbMatKhau.Multiline = false;
            this.tbMatKhau.Name = "tbMatKhau";
            this.tbMatKhau.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.tbMatKhau.PasswordChar = false;
            this.tbMatKhau.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbMatKhau.PlaceholderText = "";
            this.tbMatKhau.Size = new System.Drawing.Size(333, 42);
            this.tbMatKhau.TabIndex = 22;
            this.tbMatKhau.Texts = "";
            this.tbMatKhau.UnderlinedStyle = false;
            // 
            // tbXacNhanMK
            // 
            this.tbXacNhanMK.BackColor = System.Drawing.SystemColors.Window;
            this.tbXacNhanMK.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(44)))));
            this.tbXacNhanMK.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.tbXacNhanMK.BorderRadius = 12;
            this.tbXacNhanMK.BorderSize = 2;
            this.tbXacNhanMK.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbXacNhanMK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbXacNhanMK.Location = new System.Drawing.Point(5, 144);
            this.tbXacNhanMK.Margin = new System.Windows.Forms.Padding(5);
            this.tbXacNhanMK.Multiline = false;
            this.tbXacNhanMK.Name = "tbXacNhanMK";
            this.tbXacNhanMK.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.tbXacNhanMK.PasswordChar = false;
            this.tbXacNhanMK.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbXacNhanMK.PlaceholderText = "";
            this.tbXacNhanMK.Size = new System.Drawing.Size(333, 42);
            this.tbXacNhanMK.TabIndex = 25;
            this.tbXacNhanMK.Texts = "";
            this.tbXacNhanMK.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(12, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 28);
            this.label2.TabIndex = 24;
            this.label2.Text = "Mật khẩu mới";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(13, 188);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 19);
            this.label3.TabIndex = 26;
            this.label3.Text = "Mật khẩu không khớp";
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(4, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(691, 63);
            this.label5.TabIndex = 12;
            this.label5.Text = "Đặt lại mật khẩu";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormDatLaiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 567);
            this.Controls.Add(this.panelDatLaiMatKhau);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDatLaiMatKhau";
            this.Text = "FormDatLaiMatKhau";
            this.panelDatLaiMatKhau.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDatLaiMatKhau;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private RJCodeAdvance.RJControls.RJTextBox tbXacNhanMK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private RJCodeAdvance.RJControls.RJTextBox tbMatKhau;
        private System.Windows.Forms.Label lbSaiMa;
        private RJCodeAdvance.RJControls.RJButton btDatLai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
    }
}