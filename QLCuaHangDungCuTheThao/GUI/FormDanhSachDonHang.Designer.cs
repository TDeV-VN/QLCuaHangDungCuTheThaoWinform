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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelPageDanhSachDonHang = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbTrangThai = new RJCodeAdvance.RJControls.RJComboBox();
            this.cbNhanVien = new RJCodeAdvance.RJControls.RJComboBox();
            this.cbNgayTao = new RJCodeAdvance.RJControls.RJComboBox();
            this.iconPictureBox9 = new FontAwesome.Sharp.IconPictureBox();
            this.tbTimKiemDH = new RJCodeAdvance.RJControls.RJTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.GrVDanhSach = new System.Windows.Forms.DataGridView();
            this.MaDH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTaoDH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdtKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khachPhaiTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthaidh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artanPanel1 = new ArtanComponent.ArtanPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTongTienCacDonHang = new System.Windows.Forms.Label();
            this.lbSoLuongDonHang = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelPageDanhSachDonHang.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox9)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrVDanhSach)).BeginInit();
            this.artanPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPageDanhSachDonHang
            // 
            this.panelPageDanhSachDonHang.Controls.Add(this.groupBox2);
            this.panelPageDanhSachDonHang.Controls.Add(this.groupBox1);
            this.panelPageDanhSachDonHang.Location = new System.Drawing.Point(21, 54);
            this.panelPageDanhSachDonHang.Margin = new System.Windows.Forms.Padding(4);
            this.panelPageDanhSachDonHang.Name = "panelPageDanhSachDonHang";
            this.panelPageDanhSachDonHang.Size = new System.Drawing.Size(1584, 859);
            this.panelPageDanhSachDonHang.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cbTrangThai);
            this.groupBox2.Controls.Add(this.cbNhanVien);
            this.groupBox2.Controls.Add(this.cbNgayTao);
            this.groupBox2.Controls.Add(this.iconPictureBox9);
            this.groupBox2.Controls.Add(this.tbTimKiemDH);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 123);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(13, 4, 13, 4);
            this.groupBox2.Size = new System.Drawing.Size(1584, 736);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(1292, 14);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(171, 23);
            this.label10.TabIndex = 7;
            this.label10.Text = "Nhân viên phụ trách:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(1001, 14);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 23);
            this.label9.TabIndex = 6;
            this.label9.Text = "Trạng thái:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(706, 14);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 23);
            this.label8.TabIndex = 5;
            this.label8.Text = "Ngày tạo:";
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbTrangThai.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbTrangThai.BorderSize = 1;
            this.cbTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbTrangThai.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbTrangThai.ForeColor = System.Drawing.Color.DimGray;
            this.cbTrangThai.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbTrangThai.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbTrangThai.ListTextColor = System.Drawing.Color.DimGray;
            this.cbTrangThai.Location = new System.Drawing.Point(1005, 41);
            this.cbTrangThai.Margin = new System.Windows.Forms.Padding(4);
            this.cbTrangThai.MinimumSize = new System.Drawing.Size(267, 37);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Padding = new System.Windows.Forms.Padding(1);
            this.cbTrangThai.Size = new System.Drawing.Size(267, 37);
            this.cbTrangThai.TabIndex = 1;
            this.cbTrangThai.Texts = "";
            // 
            // cbNhanVien
            // 
            this.cbNhanVien.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbNhanVien.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbNhanVien.BorderSize = 1;
            this.cbNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbNhanVien.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbNhanVien.ForeColor = System.Drawing.Color.DimGray;
            this.cbNhanVien.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbNhanVien.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbNhanVien.ListTextColor = System.Drawing.Color.DimGray;
            this.cbNhanVien.Location = new System.Drawing.Point(1296, 41);
            this.cbNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.cbNhanVien.MinimumSize = new System.Drawing.Size(267, 37);
            this.cbNhanVien.Name = "cbNhanVien";
            this.cbNhanVien.Padding = new System.Windows.Forms.Padding(1);
            this.cbNhanVien.Size = new System.Drawing.Size(267, 37);
            this.cbNhanVien.TabIndex = 0;
            this.cbNhanVien.Texts = "";
            // 
            // cbNgayTao
            // 
            this.cbNgayTao.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbNgayTao.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbNgayTao.BorderSize = 1;
            this.cbNgayTao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbNgayTao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbNgayTao.ForeColor = System.Drawing.Color.DimGray;
            this.cbNgayTao.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbNgayTao.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbNgayTao.ListTextColor = System.Drawing.Color.DimGray;
            this.cbNgayTao.Location = new System.Drawing.Point(710, 41);
            this.cbNgayTao.Margin = new System.Windows.Forms.Padding(4);
            this.cbNgayTao.MinimumSize = new System.Drawing.Size(267, 37);
            this.cbNgayTao.Name = "cbNgayTao";
            this.cbNgayTao.Padding = new System.Windows.Forms.Padding(1);
            this.cbNgayTao.Size = new System.Drawing.Size(267, 37);
            this.cbNgayTao.TabIndex = 2;
            this.cbNgayTao.Texts = "";
            // 
            // iconPictureBox9
            // 
            this.iconPictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox9.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.iconPictureBox9.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.iconPictureBox9.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconPictureBox9.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.iconPictureBox9.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox9.IconSize = 41;
            this.iconPictureBox9.Location = new System.Drawing.Point(16, 30);
            this.iconPictureBox9.Margin = new System.Windows.Forms.Padding(0);
            this.iconPictureBox9.Name = "iconPictureBox9";
            this.iconPictureBox9.Size = new System.Drawing.Size(43, 41);
            this.iconPictureBox9.TabIndex = 4;
            this.iconPictureBox9.TabStop = false;
            // 
            // tbTimKiemDH
            // 
            this.tbTimKiemDH.BackColor = System.Drawing.SystemColors.Window;
            this.tbTimKiemDH.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbTimKiemDH.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.tbTimKiemDH.BorderRadius = 12;
            this.tbTimKiemDH.BorderSize = 2;
            this.tbTimKiemDH.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbTimKiemDH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbTimKiemDH.Location = new System.Drawing.Point(64, 30);
            this.tbTimKiemDH.Margin = new System.Windows.Forms.Padding(5);
            this.tbTimKiemDH.Multiline = false;
            this.tbTimKiemDH.Name = "tbTimKiemDH";
            this.tbTimKiemDH.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.tbTimKiemDH.PasswordChar = false;
            this.tbTimKiemDH.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbTimKiemDH.PlaceholderText = "Tìm kiếm theo mã đơn hàng, số điện thoại khách hàng";
            this.tbTimKiemDH.Size = new System.Drawing.Size(468, 42);
            this.tbTimKiemDH.TabIndex = 3;
            this.tbTimKiemDH.Texts = "";
            this.tbTimKiemDH.UnderlinedStyle = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.GrVDanhSach);
            this.groupBox3.Controls.Add(this.artanPanel1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(13, 77);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1558, 655);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // GrVDanhSach
            // 
            this.GrVDanhSach.AllowUserToAddRows = false;
            this.GrVDanhSach.AllowUserToDeleteRows = false;
            this.GrVDanhSach.AllowUserToResizeColumns = false;
            this.GrVDanhSach.AllowUserToResizeRows = false;
            this.GrVDanhSach.BackgroundColor = System.Drawing.Color.White;
            this.GrVDanhSach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GrVDanhSach.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrVDanhSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GrVDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrVDanhSach.ColumnHeadersVisible = false;
            this.GrVDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDH,
            this.NgayTaoDH,
            this.sdtKH,
            this.khachPhaiTra,
            this.trangthaidh});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GrVDanhSach.DefaultCellStyle = dataGridViewCellStyle2;
            this.GrVDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrVDanhSach.GridColor = System.Drawing.Color.White;
            this.GrVDanhSach.Location = new System.Drawing.Point(4, 74);
            this.GrVDanhSach.Margin = new System.Windows.Forms.Padding(4);
            this.GrVDanhSach.MultiSelect = false;
            this.GrVDanhSach.Name = "GrVDanhSach";
            this.GrVDanhSach.ReadOnly = true;
            this.GrVDanhSach.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrVDanhSach.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GrVDanhSach.RowHeadersVisible = false;
            this.GrVDanhSach.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            this.GrVDanhSach.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.GrVDanhSach.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.GrVDanhSach.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.GrVDanhSach.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.GrVDanhSach.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            this.GrVDanhSach.RowTemplate.Height = 30;
            this.GrVDanhSach.RowTemplate.ReadOnly = true;
            this.GrVDanhSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrVDanhSach.Size = new System.Drawing.Size(1550, 577);
            this.GrVDanhSach.TabIndex = 1;
            this.GrVDanhSach.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.yourDataGridView_DataBindingComplete);
            // 
            // MaDH
            // 
            this.MaDH.DataPropertyName = "MaHD";
            this.MaDH.HeaderText = "HD00000001";
            this.MaDH.MinimumWidth = 6;
            this.MaDH.Name = "MaDH";
            this.MaDH.ReadOnly = true;
            this.MaDH.Width = 160;
            // 
            // NgayTaoDH
            // 
            this.NgayTaoDH.DataPropertyName = "ThoiGianLap";
            this.NgayTaoDH.HeaderText = "19/03/2004 15:07";
            this.NgayTaoDH.MinimumWidth = 6;
            this.NgayTaoDH.Name = "NgayTaoDH";
            this.NgayTaoDH.ReadOnly = true;
            this.NgayTaoDH.Width = 250;
            // 
            // sdtKH
            // 
            this.sdtKH.DataPropertyName = "SDT";
            this.sdtKH.HeaderText = "01234567890";
            this.sdtKH.MinimumWidth = 6;
            this.sdtKH.Name = "sdtKH";
            this.sdtKH.ReadOnly = true;
            this.sdtKH.Width = 250;
            // 
            // khachPhaiTra
            // 
            this.khachPhaiTra.DataPropertyName = "TienKhachPhaiTra";
            this.khachPhaiTra.HeaderText = "10,000,000";
            this.khachPhaiTra.MinimumWidth = 6;
            this.khachPhaiTra.Name = "khachPhaiTra";
            this.khachPhaiTra.ReadOnly = true;
            this.khachPhaiTra.Width = 300;
            // 
            // trangthaidh
            // 
            this.trangthaidh.DataPropertyName = "TrangThai";
            this.trangthaidh.HeaderText = "Hoan thanh";
            this.trangthaidh.MinimumWidth = 6;
            this.trangthaidh.Name = "trangthaidh";
            this.trangthaidh.ReadOnly = true;
            this.trangthaidh.Width = 200;
            // 
            // artanPanel1
            // 
            this.artanPanel1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.artanPanel1.BorderRadius = 30;
            this.artanPanel1.Controls.Add(this.tableLayoutPanel1);
            this.artanPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.artanPanel1.ForeColor = System.Drawing.Color.Black;
            this.artanPanel1.GradientAngle = 90F;
            this.artanPanel1.GradientBottomColor = System.Drawing.Color.MediumPurple;
            this.artanPanel1.GradientTopColor = System.Drawing.Color.MediumSlateBlue;
            this.artanPanel1.Location = new System.Drawing.Point(4, 19);
            this.artanPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.artanPanel1.Name = "artanPanel1";
            this.artanPanel1.Size = new System.Drawing.Size(1550, 55);
            this.artanPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 213F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 271F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1550, 55);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(4, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 55);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã đơn hàng";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(217, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(325, 55);
            this.label3.TabIndex = 1;
            this.label3.Text = "Thời gian lập";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(550, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(325, 55);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số điện thoại khách hàng";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(883, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(392, 55);
            this.label6.TabIndex = 3;
            this.label6.Text = "Số tiền khách phải trả";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(1283, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(263, 55);
            this.label7.TabIndex = 4;
            this.label7.Text = "Trạng thái";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbTongTienCacDonHang);
            this.groupBox1.Controls.Add(this.lbSoLuongDonHang);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1584, 123);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(8, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hôm nay:";
            // 
            // lbTongTienCacDonHang
            // 
            this.lbTongTienCacDonHang.AutoSize = true;
            this.lbTongTienCacDonHang.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTongTienCacDonHang.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTongTienCacDonHang.Location = new System.Drawing.Point(775, 57);
            this.lbTongTienCacDonHang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTongTienCacDonHang.Name = "lbTongTienCacDonHang";
            this.lbTongTienCacDonHang.Size = new System.Drawing.Size(185, 32);
            this.lbTongTienCacDonHang.TabIndex = 5;
            this.lbTongTienCacDonHang.Text = "10,000,000 VNĐ";
            this.lbTongTienCacDonHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbSoLuongDonHang
            // 
            this.lbSoLuongDonHang.AutoSize = true;
            this.lbSoLuongDonHang.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSoLuongDonHang.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbSoLuongDonHang.Location = new System.Drawing.Point(284, 57);
            this.lbSoLuongDonHang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSoLuongDonHang.Name = "lbSoLuongDonHang";
            this.lbSoLuongDonHang.Size = new System.Drawing.Size(150, 32);
            this.lbSoLuongDonHang.TabIndex = 3;
            this.lbSoLuongDonHang.Text = "14 đơn hàng";
            this.lbSoLuongDonHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(497, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 50);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tổng tiền:";
            // 
            // FormDanhSachDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1621, 974);
            this.Controls.Add(this.panelPageDanhSachDonHang);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDanhSachDonHang";
            this.Text = "FormDanhSachDonHang";
            this.panelPageDanhSachDonHang.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox9)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrVDanhSach)).EndInit();
            this.artanPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPageDanhSachDonHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTongTienCacDonHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbSoLuongDonHang;
        private System.Windows.Forms.GroupBox groupBox2;
        private ArtanComponent.ArtanPanel artanPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView GrVDanhSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTaoDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdtKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn khachPhaiTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthaidh;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox9;
        private RJCodeAdvance.RJControls.RJTextBox tbTimKiemDH;
        private RJCodeAdvance.RJControls.RJComboBox cbNhanVien;
        private RJCodeAdvance.RJControls.RJComboBox cbNgayTao;
        private RJCodeAdvance.RJControls.RJComboBox cbTrangThai;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}