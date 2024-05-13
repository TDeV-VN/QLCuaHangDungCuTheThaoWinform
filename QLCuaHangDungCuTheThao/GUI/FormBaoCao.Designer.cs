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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelPageBaoCao = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ThongTinCuaHang = new System.Windows.Forms.TabPage();
            this.TaiKhoanNhanVien = new System.Windows.Forms.TabPage();
            this.GrTao = new System.Windows.Forms.GroupBox();
            this.cbQuyen_tao = new RJCodeAdvance.RJControls.RJComboBox();
            this.tbEmail_tao = new RJCodeAdvance.RJControls.RJTextBox();
            this.btTao = new RJCodeAdvance.RJControls.RJButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.GrThongTin = new System.Windows.Forms.GroupBox();
            this.cbTrangThai = new RJCodeAdvance.RJControls.RJComboBox();
            this.tbMa = new RJCodeAdvance.RJControls.RJTextBox();
            this.cbQuyen = new RJCodeAdvance.RJControls.RJComboBox();
            this.btLuu = new RJCodeAdvance.RJControls.RJButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbEmail = new RJCodeAdvance.RJControls.RJTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.artanPanel1 = new ArtanComponent.ArtanPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GrVDanhSachTK = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelPageBaoCao.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.TaiKhoanNhanVien.SuspendLayout();
            this.GrTao.SuspendLayout();
            this.GrThongTin.SuspendLayout();
            this.artanPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrVDanhSachTK)).BeginInit();
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
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1182, 692);
            this.tabControl1.TabIndex = 0;
            // 
            // ThongTinCuaHang
            // 
            this.ThongTinCuaHang.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ThongTinCuaHang.Location = new System.Drawing.Point(4, 34);
            this.ThongTinCuaHang.Name = "ThongTinCuaHang";
            this.ThongTinCuaHang.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.ThongTinCuaHang.Size = new System.Drawing.Size(1174, 654);
            this.ThongTinCuaHang.TabIndex = 0;
            this.ThongTinCuaHang.Text = "Thông tin cửa hàng";
            this.ThongTinCuaHang.UseVisualStyleBackColor = true;
            // 
            // TaiKhoanNhanVien
            // 
            this.TaiKhoanNhanVien.Controls.Add(this.GrTao);
            this.TaiKhoanNhanVien.Controls.Add(this.GrThongTin);
            this.TaiKhoanNhanVien.Controls.Add(this.artanPanel1);
            this.TaiKhoanNhanVien.Controls.Add(this.GrVDanhSachTK);
            this.TaiKhoanNhanVien.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TaiKhoanNhanVien.Location = new System.Drawing.Point(4, 34);
            this.TaiKhoanNhanVien.Name = "TaiKhoanNhanVien";
            this.TaiKhoanNhanVien.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.TaiKhoanNhanVien.Size = new System.Drawing.Size(1174, 654);
            this.TaiKhoanNhanVien.TabIndex = 1;
            this.TaiKhoanNhanVien.Text = "Tài khoản nhân viên";
            this.TaiKhoanNhanVien.UseVisualStyleBackColor = true;
            // 
            // GrTao
            // 
            this.GrTao.Controls.Add(this.cbQuyen_tao);
            this.GrTao.Controls.Add(this.tbEmail_tao);
            this.GrTao.Controls.Add(this.btTao);
            this.GrTao.Controls.Add(this.label9);
            this.GrTao.Controls.Add(this.label10);
            this.GrTao.Location = new System.Drawing.Point(699, 366);
            this.GrTao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GrTao.Name = "GrTao";
            this.GrTao.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GrTao.Size = new System.Drawing.Size(459, 201);
            this.GrTao.TabIndex = 3;
            this.GrTao.TabStop = false;
            this.GrTao.Text = "Cấp tài khoản mới";
            // 
            // cbQuyen_tao
            // 
            this.cbQuyen_tao.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbQuyen_tao.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbQuyen_tao.BorderSize = 2;
            this.cbQuyen_tao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbQuyen_tao.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbQuyen_tao.ForeColor = System.Drawing.Color.DimGray;
            this.cbQuyen_tao.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbQuyen_tao.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbQuyen_tao.ListTextColor = System.Drawing.Color.DimGray;
            this.cbQuyen_tao.Location = new System.Drawing.Point(160, 89);
            this.cbQuyen_tao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbQuyen_tao.MinimumSize = new System.Drawing.Size(150, 24);
            this.cbQuyen_tao.Name = "cbQuyen_tao";
            this.cbQuyen_tao.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbQuyen_tao.Size = new System.Drawing.Size(222, 34);
            this.cbQuyen_tao.TabIndex = 13;
            this.cbQuyen_tao.Texts = "";
            // 
            // tbEmail_tao
            // 
            this.tbEmail_tao.BackColor = System.Drawing.SystemColors.Window;
            this.tbEmail_tao.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbEmail_tao.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbEmail_tao.BorderRadius = 12;
            this.tbEmail_tao.BorderSize = 2;
            this.tbEmail_tao.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbEmail_tao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbEmail_tao.Location = new System.Drawing.Point(158, 40);
            this.tbEmail_tao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbEmail_tao.Multiline = false;
            this.tbEmail_tao.Name = "tbEmail_tao";
            this.tbEmail_tao.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.tbEmail_tao.PasswordChar = false;
            this.tbEmail_tao.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbEmail_tao.PlaceholderText = "";
            this.tbEmail_tao.Size = new System.Drawing.Size(296, 38);
            this.tbEmail_tao.TabIndex = 12;
            this.tbEmail_tao.Texts = "";
            this.tbEmail_tao.UnderlinedStyle = false;
            // 
            // btTao
            // 
            this.btTao.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btTao.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btTao.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btTao.BorderRadius = 12;
            this.btTao.BorderSize = 0;
            this.btTao.FlatAppearance.BorderSize = 0;
            this.btTao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTao.ForeColor = System.Drawing.Color.White;
            this.btTao.Location = new System.Drawing.Point(310, 140);
            this.btTao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btTao.Name = "btTao";
            this.btTao.Size = new System.Drawing.Size(144, 48);
            this.btTao.TabIndex = 10;
            this.btTao.Text = "Tạo";
            this.btTao.TextColor = System.Drawing.Color.White;
            this.btTao.UseVisualStyleBackColor = false;
            this.btTao.Click += new System.EventHandler(this.btTao_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 89);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 21);
            this.label9.TabIndex = 12;
            this.label9.Text = "Quyền";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 40);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 21);
            this.label10.TabIndex = 10;
            this.label10.Text = "Email";
            // 
            // GrThongTin
            // 
            this.GrThongTin.Controls.Add(this.cbTrangThai);
            this.GrThongTin.Controls.Add(this.tbMa);
            this.GrThongTin.Controls.Add(this.cbQuyen);
            this.GrThongTin.Controls.Add(this.btLuu);
            this.GrThongTin.Controls.Add(this.label8);
            this.GrThongTin.Controls.Add(this.label7);
            this.GrThongTin.Controls.Add(this.tbEmail);
            this.GrThongTin.Controls.Add(this.label6);
            this.GrThongTin.Controls.Add(this.label5);
            this.GrThongTin.Location = new System.Drawing.Point(699, 69);
            this.GrThongTin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GrThongTin.Name = "GrThongTin";
            this.GrThongTin.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GrThongTin.Size = new System.Drawing.Size(459, 293);
            this.GrThongTin.TabIndex = 2;
            this.GrThongTin.TabStop = false;
            this.GrThongTin.Text = "Thông tin tài khoản";
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbTrangThai.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbTrangThai.BorderSize = 2;
            this.cbTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbTrangThai.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbTrangThai.ForeColor = System.Drawing.Color.DimGray;
            this.cbTrangThai.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbTrangThai.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbTrangThai.ListTextColor = System.Drawing.Color.DimGray;
            this.cbTrangThai.Location = new System.Drawing.Point(160, 185);
            this.cbTrangThai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbTrangThai.MinimumSize = new System.Drawing.Size(150, 24);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbTrangThai.Size = new System.Drawing.Size(222, 34);
            this.cbTrangThai.TabIndex = 12;
            this.cbTrangThai.Texts = "";
            // 
            // tbMa
            // 
            this.tbMa.BackColor = System.Drawing.SystemColors.Window;
            this.tbMa.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbMa.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbMa.BorderRadius = 12;
            this.tbMa.BorderSize = 2;
            this.tbMa.Enabled = false;
            this.tbMa.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbMa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbMa.Location = new System.Drawing.Point(158, 31);
            this.tbMa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbMa.Multiline = false;
            this.tbMa.Name = "tbMa";
            this.tbMa.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.tbMa.PasswordChar = false;
            this.tbMa.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbMa.PlaceholderText = "";
            this.tbMa.Size = new System.Drawing.Size(296, 38);
            this.tbMa.TabIndex = 11;
            this.tbMa.Texts = "";
            this.tbMa.UnderlinedStyle = false;
            // 
            // cbQuyen
            // 
            this.cbQuyen.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbQuyen.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbQuyen.BorderSize = 2;
            this.cbQuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbQuyen.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbQuyen.ForeColor = System.Drawing.Color.DimGray;
            this.cbQuyen.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbQuyen.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbQuyen.ListTextColor = System.Drawing.Color.DimGray;
            this.cbQuyen.Location = new System.Drawing.Point(160, 139);
            this.cbQuyen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbQuyen.MinimumSize = new System.Drawing.Size(150, 24);
            this.cbQuyen.Name = "cbQuyen";
            this.cbQuyen.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbQuyen.Size = new System.Drawing.Size(222, 34);
            this.cbQuyen.TabIndex = 10;
            this.cbQuyen.Texts = "";
            // 
            // btLuu
            // 
            this.btLuu.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btLuu.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btLuu.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btLuu.BorderRadius = 12;
            this.btLuu.BorderSize = 0;
            this.btLuu.Enabled = false;
            this.btLuu.FlatAppearance.BorderSize = 0;
            this.btLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLuu.ForeColor = System.Drawing.Color.White;
            this.btLuu.Location = new System.Drawing.Point(310, 235);
            this.btLuu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(145, 45);
            this.btLuu.TabIndex = 9;
            this.btLuu.Text = "Lưu";
            this.btLuu.TextColor = System.Drawing.Color.White;
            this.btLuu.UseVisualStyleBackColor = false;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 186);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 21);
            this.label8.TabIndex = 6;
            this.label8.Text = "Trạng thái";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 139);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 21);
            this.label7.TabIndex = 4;
            this.label7.Text = "Quyền";
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.SystemColors.Window;
            this.tbEmail.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbEmail.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbEmail.BorderRadius = 12;
            this.tbEmail.BorderSize = 2;
            this.tbEmail.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbEmail.Location = new System.Drawing.Point(157, 86);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbEmail.Multiline = false;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.tbEmail.PasswordChar = false;
            this.tbEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbEmail.PlaceholderText = "";
            this.tbEmail.Size = new System.Drawing.Size(296, 38);
            this.tbEmail.TabIndex = 1;
            this.tbEmail.Texts = "";
            this.tbEmail.UnderlinedStyle = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 86);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã nhân viên";
            // 
            // artanPanel1
            // 
            this.artanPanel1.BackColor = System.Drawing.Color.White;
            this.artanPanel1.BorderRadius = 30;
            this.artanPanel1.Controls.Add(this.tableLayoutPanel1);
            this.artanPanel1.ForeColor = System.Drawing.Color.Black;
            this.artanPanel1.GradientAngle = 90F;
            this.artanPanel1.GradientBottomColor = System.Drawing.Color.MediumPurple;
            this.artanPanel1.GradientTopColor = System.Drawing.Color.MediumSlateBlue;
            this.artanPanel1.Location = new System.Drawing.Point(18, 69);
            this.artanPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.artanPanel1.Name = "artanPanel1";
            this.artanPanel1.Size = new System.Drawing.Size(676, 45);
            this.artanPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 290F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 146F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(676, 45);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(102, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(392, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 45);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quyền";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(532, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 45);
            this.label4.TabIndex = 3;
            this.label4.Text = "Trạng thái";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GrVDanhSachTK
            // 
            this.GrVDanhSachTK.BackgroundColor = System.Drawing.Color.White;
            this.GrVDanhSachTK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GrVDanhSachTK.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GrVDanhSachTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrVDanhSachTK.ColumnHeadersVisible = false;
            this.GrVDanhSachTK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.Email,
            this.Quyen,
            this.TrangThai});
            this.GrVDanhSachTK.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.GrVDanhSachTK.Location = new System.Drawing.Point(18, 119);
            this.GrVDanhSachTK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GrVDanhSachTK.Name = "GrVDanhSachTK";
            this.GrVDanhSachTK.RowHeadersVisible = false;
            this.GrVDanhSachTK.RowHeadersWidth = 51;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            this.GrVDanhSachTK.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.GrVDanhSachTK.RowTemplate.Height = 24;
            this.GrVDanhSachTK.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GrVDanhSachTK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrVDanhSachTK.Size = new System.Drawing.Size(676, 448);
            this.GrVDanhSachTK.TabIndex = 0;
            this.GrVDanhSachTK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrVDanhSachTK_CellClick);
            this.GrVDanhSachTK.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.yourDataGridView_DataBindingComplete);
            // 
            // MaNV
            // 
            this.MaNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MaNV.DataPropertyName = "MaNV";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MaNV.DefaultCellStyle = dataGridViewCellStyle11;
            this.MaNV.HeaderText = "NV001";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            this.MaNV.Width = 125;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Email.DataPropertyName = "Email";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Email.DefaultCellStyle = dataGridViewCellStyle12;
            this.Email.HeaderText = "thanhtien.z8436@gmail.com";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 290;
            // 
            // Quyen
            // 
            this.Quyen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Quyen.DataPropertyName = "Role";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Quyen.DefaultCellStyle = dataGridViewCellStyle13;
            this.Quyen.HeaderText = "Quyen";
            this.Quyen.MinimumWidth = 6;
            this.Quyen.Name = "Quyen";
            this.Quyen.ReadOnly = true;
            this.Quyen.Width = 140;
            // 
            // TrangThai
            // 
            this.TrangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TrangThai.DataPropertyName = "TrangThai";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TrangThai.DefaultCellStyle = dataGridViewCellStyle14;
            this.TrangThai.HeaderText = "TrangThai";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            this.TrangThai.Width = 140;
            // 
            // FormBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 687);
            this.Controls.Add(this.panelPageBaoCao);
            this.Name = "FormBaoCao";
            this.Text = "FormQuanLy";
            this.panelPageBaoCao.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.TaiKhoanNhanVien.ResumeLayout(false);
            this.GrTao.ResumeLayout(false);
            this.GrTao.PerformLayout();
            this.GrThongTin.ResumeLayout(false);
            this.GrThongTin.PerformLayout();
            this.artanPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrVDanhSachTK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPageBaoCao;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ThongTinCuaHang;
        private System.Windows.Forms.TabPage TaiKhoanNhanVien;
        private System.Windows.Forms.DataGridView GrVDanhSachTK;
        private ArtanComponent.ArtanPanel artanPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox GrThongTin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private RJCodeAdvance.RJControls.RJTextBox tbEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private RJCodeAdvance.RJControls.RJButton btLuu;
        private System.Windows.Forms.GroupBox GrTao;
        private RJCodeAdvance.RJControls.RJButton btTao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private RJCodeAdvance.RJControls.RJTextBox tbMa;
        private RJCodeAdvance.RJControls.RJComboBox cbQuyen;
        private RJCodeAdvance.RJControls.RJTextBox tbEmail_tao;
        private RJCodeAdvance.RJControls.RJComboBox cbTrangThai;
        private RJCodeAdvance.RJControls.RJComboBox cbQuyen_tao;
    }
}