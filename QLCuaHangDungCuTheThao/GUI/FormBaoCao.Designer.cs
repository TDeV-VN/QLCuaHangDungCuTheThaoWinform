namespace GUI
{
    partial class FormBaoCao
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
            this.panelPageBaoCao = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ThongTinCuaHang = new System.Windows.Forms.TabPage();
            this.TaiKhoanNhanVien = new System.Windows.Forms.TabPage();
            this.panelPageBaoCao.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPageBaoCao
            // 
            this.panelPageBaoCao.Controls.Add(this.tabControl1);
            this.panelPageBaoCao.Location = new System.Drawing.Point(10, 57);
            this.panelPageBaoCao.Name = "panelPageBaoCao";
            this.panelPageBaoCao.Size = new System.Drawing.Size(1188, 698);
            this.panelPageBaoCao.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ThongTinCuaHang);
            this.tabControl1.Controls.Add(this.TaiKhoanNhanVien);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1182, 692);
            this.tabControl1.TabIndex = 0;
            // 
            // ThongTinCuaHang
            // 
            this.ThongTinCuaHang.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ThongTinCuaHang.Location = new System.Drawing.Point(4, 22);
            this.ThongTinCuaHang.Name = "ThongTinCuaHang";
            this.ThongTinCuaHang.Padding = new System.Windows.Forms.Padding(3);
            this.ThongTinCuaHang.Size = new System.Drawing.Size(1174, 666);
            this.ThongTinCuaHang.TabIndex = 0;
            this.ThongTinCuaHang.Text = "Thông tin cửa hàng";
            this.ThongTinCuaHang.UseVisualStyleBackColor = true;
            // 
            // TaiKhoanNhanVien
            // 
            this.TaiKhoanNhanVien.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TaiKhoanNhanVien.Location = new System.Drawing.Point(4, 22);
            this.TaiKhoanNhanVien.Name = "TaiKhoanNhanVien";
            this.TaiKhoanNhanVien.Padding = new System.Windows.Forms.Padding(3);
            this.TaiKhoanNhanVien.Size = new System.Drawing.Size(1174, 666);
            this.TaiKhoanNhanVien.TabIndex = 1;
            this.TaiKhoanNhanVien.Text = "Tài khoản nhân viên";
            this.TaiKhoanNhanVien.UseVisualStyleBackColor = true;
            // 
            // FormBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 812);
            this.Controls.Add(this.panelPageBaoCao);
            this.Name = "FormBaoCao";
            this.Text = "FormQuanLy";
            this.panelPageBaoCao.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPageBaoCao;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ThongTinCuaHang;
        private System.Windows.Forms.TabPage TaiKhoanNhanVien;
    }
}