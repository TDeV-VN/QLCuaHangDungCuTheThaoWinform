namespace GUI
{
    partial class FormKhachHang
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
            this.panelPageKhachHang = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelPageKhachHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPageKhachHang
            // 
            this.panelPageKhachHang.Controls.Add(this.label1);
            this.panelPageKhachHang.Location = new System.Drawing.Point(7, 47);
            this.panelPageKhachHang.Name = "panelPageKhachHang";
            this.panelPageKhachHang.Size = new System.Drawing.Size(1188, 698);
            this.panelPageKhachHang.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1051, 662);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "panelKhachHang";
            // 
            // FormKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 793);
            this.Controls.Add(this.panelPageKhachHang);
            this.Name = "FormKhachHang";
            this.Text = "FormKhachHang";
            this.panelPageKhachHang.ResumeLayout(false);
            this.panelPageKhachHang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPageKhachHang;
        private System.Windows.Forms.Label label1;
    }
}