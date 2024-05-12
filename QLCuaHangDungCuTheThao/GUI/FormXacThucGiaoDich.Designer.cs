namespace GUI
{
    partial class FormXacThucGiaoDich
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
            this.label1 = new System.Windows.Forms.Label();
            this.btDoi = new RJCodeAdvance.RJControls.RJButton();
            this.btBoQua = new RJCodeAdvance.RJControls.RJButton();
            this.picThanhCong = new System.Windows.Forms.PictureBox();
            this.picCho = new System.Windows.Forms.PictureBox();
            this.lbThatBai = new System.Windows.Forms.Label();
            this.picThatBai = new System.Windows.Forms.PictureBox();
            this.lbThanhCong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picThanhCong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThatBai)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.Location = new System.Drawing.Point(45, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đang xác thực giao dịch";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btDoi
            // 
            this.btDoi.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btDoi.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btDoi.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btDoi.BorderRadius = 12;
            this.btDoi.BorderSize = 0;
            this.btDoi.FlatAppearance.BorderSize = 0;
            this.btDoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDoi.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btDoi.ForeColor = System.Drawing.Color.White;
            this.btDoi.Location = new System.Drawing.Point(202, 331);
            this.btDoi.Name = "btDoi";
            this.btDoi.Size = new System.Drawing.Size(294, 48);
            this.btDoi.TabIndex = 2;
            this.btDoi.Text = "Đổi phương thức thanh toán";
            this.btDoi.TextColor = System.Drawing.Color.White;
            this.btDoi.UseVisualStyleBackColor = false;
            this.btDoi.Click += new System.EventHandler(this.btDoi_Click);
            // 
            // btBoQua
            // 
            this.btBoQua.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btBoQua.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.btBoQua.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btBoQua.BorderRadius = 12;
            this.btBoQua.BorderSize = 0;
            this.btBoQua.FlatAppearance.BorderSize = 0;
            this.btBoQua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBoQua.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btBoQua.ForeColor = System.Drawing.Color.White;
            this.btBoQua.Location = new System.Drawing.Point(12, 331);
            this.btBoQua.Name = "btBoQua";
            this.btBoQua.Size = new System.Drawing.Size(184, 48);
            this.btBoQua.TabIndex = 3;
            this.btBoQua.Text = "Bỏ qua xác thực";
            this.btBoQua.TextColor = System.Drawing.Color.White;
            this.btBoQua.UseVisualStyleBackColor = false;
            this.btBoQua.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // picThanhCong
            // 
            this.picThanhCong.BackColor = System.Drawing.SystemColors.Control;
            this.picThanhCong.Image = global::GUI.Properties.Resources.yes;
            this.picThanhCong.Location = new System.Drawing.Point(155, 94);
            this.picThanhCong.Margin = new System.Windows.Forms.Padding(4);
            this.picThanhCong.Name = "picThanhCong";
            this.picThanhCong.Size = new System.Drawing.Size(194, 180);
            this.picThanhCong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picThanhCong.TabIndex = 4;
            this.picThanhCong.TabStop = false;
            this.picThanhCong.Visible = false;
            // 
            // picCho
            // 
            this.picCho.Image = global::GUI.Properties.Resources.loading;
            this.picCho.Location = new System.Drawing.Point(61, 84);
            this.picCho.Margin = new System.Windows.Forms.Padding(4);
            this.picCho.Name = "picCho";
            this.picCho.Size = new System.Drawing.Size(400, 198);
            this.picCho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCho.TabIndex = 1;
            this.picCho.TabStop = false;
            // 
            // lbThatBai
            // 
            this.lbThatBai.AutoSize = true;
            this.lbThatBai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbThatBai.ForeColor = System.Drawing.Color.Red;
            this.lbThatBai.Location = new System.Drawing.Point(134, 280);
            this.lbThatBai.Name = "lbThatBai";
            this.lbThatBai.Size = new System.Drawing.Size(188, 28);
            this.lbThatBai.TabIndex = 5;
            this.lbThatBai.Text = "Giao dịch thất bại!";
            this.lbThatBai.Visible = false;
            // 
            // picThatBai
            // 
            this.picThatBai.BackColor = System.Drawing.SystemColors.Control;
            this.picThatBai.Image = global::GUI.Properties.Resources.fail;
            this.picThatBai.Location = new System.Drawing.Point(155, 94);
            this.picThatBai.Margin = new System.Windows.Forms.Padding(4);
            this.picThatBai.Name = "picThatBai";
            this.picThatBai.Size = new System.Drawing.Size(194, 180);
            this.picThatBai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picThatBai.TabIndex = 6;
            this.picThatBai.TabStop = false;
            this.picThatBai.Visible = false;
            // 
            // lbThanhCong
            // 
            this.lbThanhCong.AutoSize = true;
            this.lbThanhCong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbThanhCong.ForeColor = System.Drawing.Color.Green;
            this.lbThanhCong.Location = new System.Drawing.Point(125, 280);
            this.lbThanhCong.Name = "lbThanhCong";
            this.lbThanhCong.Size = new System.Drawing.Size(221, 28);
            this.lbThanhCong.TabIndex = 7;
            this.lbThanhCong.Text = "Giao dịch thành công!";
            this.lbThanhCong.Visible = false;
            // 
            // FormXacThucGiaoDich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(508, 406);
            this.Controls.Add(this.lbThanhCong);
            this.Controls.Add(this.picThatBai);
            this.Controls.Add(this.lbThatBai);
            this.Controls.Add(this.picThanhCong);
            this.Controls.Add(this.btBoQua);
            this.Controls.Add(this.btDoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picCho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormXacThucGiaoDich";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormXacThucGiaoDich";
            ((System.ComponentModel.ISupportInitialize)(this.picThanhCong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThatBai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picCho;
        private RJCodeAdvance.RJControls.RJButton btDoi;
        private RJCodeAdvance.RJControls.RJButton btBoQua;
        private System.Windows.Forms.PictureBox picThanhCong;
        private System.Windows.Forms.Label lbThatBai;
        private System.Windows.Forms.PictureBox picThatBai;
        private System.Windows.Forms.Label lbThanhCong;
    }
}