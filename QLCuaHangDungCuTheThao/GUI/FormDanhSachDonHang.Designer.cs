namespace GUI
{
    partial class FormDanhSachDonHang
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
            this.panelPageDanhSachDonHang = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelPageDanhSachDonHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPageDanhSachDonHang
            // 
            this.panelPageDanhSachDonHang.Controls.Add(this.label1);
            this.panelPageDanhSachDonHang.Location = new System.Drawing.Point(16, 44);
            this.panelPageDanhSachDonHang.Name = "panelPageDanhSachDonHang";
            this.panelPageDanhSachDonHang.Size = new System.Drawing.Size(1188, 698);
            this.panelPageDanhSachDonHang.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1040, 670);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "panelDanhSachDonHang";
            // 
            // FormDanhSachDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 791);
            this.Controls.Add(this.panelPageDanhSachDonHang);
            this.Name = "FormDanhSachDonHang";
            this.Text = "FormDanhSachDonHang";
            this.panelPageDanhSachDonHang.ResumeLayout(false);
            this.panelPageDanhSachDonHang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPageDanhSachDonHang;
        private System.Windows.Forms.Label label1;
    }
}