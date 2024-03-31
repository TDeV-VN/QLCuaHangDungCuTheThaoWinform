namespace GUI
{
    partial class FormDanhMucSanPham
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
            this.panelPageDanhMucSanPham = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelPageDanhMucSanPham.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPageDanhMucSanPham
            // 
            this.panelPageDanhMucSanPham.Controls.Add(this.label1);
            this.panelPageDanhMucSanPham.Location = new System.Drawing.Point(10, 51);
            this.panelPageDanhMucSanPham.Name = "panelPageDanhMucSanPham";
            this.panelPageDanhMucSanPham.Size = new System.Drawing.Size(1188, 698);
            this.panelPageDanhMucSanPham.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1030, 648);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "panelDanhMucSanPham";
            // 
            // FormDanhMucSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 801);
            this.Controls.Add(this.panelPageDanhMucSanPham);
            this.Name = "FormDanhMucSanPham";
            this.Text = "FormDanhMucSanPham";
            this.panelPageDanhMucSanPham.ResumeLayout(false);
            this.panelPageDanhMucSanPham.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPageDanhMucSanPham;
        private System.Windows.Forms.Label label1;
    }
}