namespace GUI
{
    partial class FormDanhSachSanPham
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelPageDanhSachSanPham = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btXoaSP = new FontAwesome.Sharp.IconButton();
            this.btThemSP = new RJCodeAdvance.RJControls.RJButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbTrangThai = new RJCodeAdvance.RJControls.RJComboBox();
            this.cbSapXep = new RJCodeAdvance.RJControls.RJComboBox();
            this.cbDanhMuc = new RJCodeAdvance.RJControls.RJComboBox();
            this.iconPictureBox9 = new FontAwesome.Sharp.IconPictureBox();
            this.tbTimKiem = new RJCodeAdvance.RJControls.RJTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.GrVDanhSach = new System.Windows.Forms.DataGridView();
            this.chon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.anh = new System.Windows.Forms.DataGridViewImageColumn();
            this.Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TonKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artanPanel1 = new ArtanComponent.ArtanPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkBChonTatCa = new System.Windows.Forms.CheckBox();
            this.panelPageDanhSachSanPham.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox9)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrVDanhSach)).BeginInit();
            this.artanPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPageDanhSachSanPham
            // 
            this.panelPageDanhSachSanPham.Controls.Add(this.groupBox2);
            this.panelPageDanhSachSanPham.Location = new System.Drawing.Point(5, 50);
            this.panelPageDanhSachSanPham.Name = "panelPageDanhSachSanPham";
            this.panelPageDanhSachSanPham.Size = new System.Drawing.Size(1188, 698);
            this.panelPageDanhSachSanPham.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cbTrangThai);
            this.groupBox2.Controls.Add(this.cbSapXep);
            this.groupBox2.Controls.Add(this.cbDanhMuc);
            this.groupBox2.Controls.Add(this.iconPictureBox9);
            this.groupBox2.Controls.Add(this.tbTimKiem);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.groupBox2.Size = new System.Drawing.Size(1188, 698);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btXoaSP);
            this.panel1.Controls.Add(this.btThemSP);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1168, 42);
            this.panel1.TabIndex = 8;
            // 
            // btXoaSP
            // 
            this.btXoaSP.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btXoaSP.IconColor = System.Drawing.Color.Black;
            this.btXoaSP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btXoaSP.IconSize = 30;
            this.btXoaSP.Location = new System.Drawing.Point(1126, 2);
            this.btXoaSP.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.btXoaSP.Name = "btXoaSP";
            this.btXoaSP.Size = new System.Drawing.Size(40, 40);
            this.btXoaSP.TabIndex = 1;
            this.btXoaSP.UseVisualStyleBackColor = true;
            this.btXoaSP.Click += new System.EventHandler(this.btXoaSP_Click);
            // 
            // btThemSP
            // 
            this.btThemSP.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btThemSP.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btThemSP.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btThemSP.BorderRadius = 12;
            this.btThemSP.BorderSize = 0;
            this.btThemSP.FlatAppearance.BorderSize = 0;
            this.btThemSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThemSP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btThemSP.ForeColor = System.Drawing.Color.White;
            this.btThemSP.Location = new System.Drawing.Point(963, 0);
            this.btThemSP.Name = "btThemSP";
            this.btThemSP.Size = new System.Drawing.Size(150, 40);
            this.btThemSP.TabIndex = 0;
            this.btThemSP.Text = "Thêm sản phẩm";
            this.btThemSP.TextColor = System.Drawing.Color.White;
            this.btThemSP.UseVisualStyleBackColor = false;
            this.btThemSP.Click += new System.EventHandler(this.btThemSP_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(969, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "Sắp xếp theo tên:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(751, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Trạng thái:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(530, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Danh mục:";
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbTrangThai.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbTrangThai.BorderSize = 2;
            this.cbTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbTrangThai.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbTrangThai.ForeColor = System.Drawing.Color.DimGray;
            this.cbTrangThai.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbTrangThai.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbTrangThai.ListTextColor = System.Drawing.Color.DimGray;
            this.cbTrangThai.Location = new System.Drawing.Point(754, 127);
            this.cbTrangThai.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Padding = new System.Windows.Forms.Padding(2);
            this.cbTrangThai.Size = new System.Drawing.Size(200, 30);
            this.cbTrangThai.TabIndex = 1;
            this.cbTrangThai.Texts = "";
            // 
            // cbSapXep
            // 
            this.cbSapXep.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbSapXep.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbSapXep.BorderSize = 2;
            this.cbSapXep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbSapXep.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbSapXep.ForeColor = System.Drawing.Color.DimGray;
            this.cbSapXep.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbSapXep.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbSapXep.ListTextColor = System.Drawing.Color.DimGray;
            this.cbSapXep.Location = new System.Drawing.Point(972, 127);
            this.cbSapXep.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbSapXep.Name = "cbSapXep";
            this.cbSapXep.Padding = new System.Windows.Forms.Padding(2);
            this.cbSapXep.Size = new System.Drawing.Size(200, 30);
            this.cbSapXep.TabIndex = 0;
            this.cbSapXep.Texts = "";
            // 
            // cbDanhMuc
            // 
            this.cbDanhMuc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbDanhMuc.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbDanhMuc.BorderSize = 2;
            this.cbDanhMuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbDanhMuc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbDanhMuc.ForeColor = System.Drawing.Color.DimGray;
            this.cbDanhMuc.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbDanhMuc.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbDanhMuc.ListTextColor = System.Drawing.Color.DimGray;
            this.cbDanhMuc.Location = new System.Drawing.Point(532, 127);
            this.cbDanhMuc.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbDanhMuc.Name = "cbDanhMuc";
            this.cbDanhMuc.Padding = new System.Windows.Forms.Padding(2);
            this.cbDanhMuc.Size = new System.Drawing.Size(200, 30);
            this.cbDanhMuc.TabIndex = 2;
            this.cbDanhMuc.Texts = "";
            // 
            // iconPictureBox9
            // 
            this.iconPictureBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox9.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.iconPictureBox9.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.iconPictureBox9.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconPictureBox9.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.iconPictureBox9.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox9.Location = new System.Drawing.Point(13, 119);
            this.iconPictureBox9.Margin = new System.Windows.Forms.Padding(0);
            this.iconPictureBox9.Name = "iconPictureBox9";
            this.iconPictureBox9.Size = new System.Drawing.Size(32, 33);
            this.iconPictureBox9.TabIndex = 4;
            this.iconPictureBox9.TabStop = false;
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.BackColor = System.Drawing.SystemColors.Window;
            this.tbTimKiem.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbTimKiem.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.tbTimKiem.BorderRadius = 12;
            this.tbTimKiem.BorderSize = 2;
            this.tbTimKiem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbTimKiem.Location = new System.Drawing.Point(48, 118);
            this.tbTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbTimKiem.Multiline = false;
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbTimKiem.PasswordChar = false;
            this.tbTimKiem.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbTimKiem.PlaceholderText = "Tìm kiếm theo mã / tên sản phẩm";
            this.tbTimKiem.Size = new System.Drawing.Size(351, 32);
            this.tbTimKiem.TabIndex = 3;
            this.tbTimKiem.Texts = "";
            this.tbTimKiem.UnderlinedStyle = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.GrVDanhSach);
            this.groupBox3.Controls.Add(this.artanPanel1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(10, 173);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1168, 522);
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
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrVDanhSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.GrVDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrVDanhSach.ColumnHeadersVisible = false;
            this.GrVDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chon,
            this.anh,
            this.Ma,
            this.Ten,
            this.DanhMuc,
            this.TonKho});
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GrVDanhSach.DefaultCellStyle = dataGridViewCellStyle19;
            this.GrVDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrVDanhSach.GridColor = System.Drawing.Color.White;
            this.GrVDanhSach.Location = new System.Drawing.Point(3, 61);
            this.GrVDanhSach.MultiSelect = false;
            this.GrVDanhSach.Name = "GrVDanhSach";
            this.GrVDanhSach.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrVDanhSach.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.GrVDanhSach.RowHeadersVisible = false;
            this.GrVDanhSach.RowHeadersWidth = 51;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            this.GrVDanhSach.RowsDefaultCellStyle = dataGridViewCellStyle21;
            this.GrVDanhSach.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.GrVDanhSach.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.GrVDanhSach.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            this.GrVDanhSach.RowTemplate.Height = 30;
            this.GrVDanhSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrVDanhSach.Size = new System.Drawing.Size(1162, 458);
            this.GrVDanhSach.TabIndex = 1;
            this.GrVDanhSach.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.yourDataGridView_DataBindingComplete);
            // 
            // chon
            // 
            this.chon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.chon.DataPropertyName = "chon";
            this.chon.FillWeight = 152.2843F;
            this.chon.HeaderText = "Chọn";
            this.chon.MinimumWidth = 6;
            this.chon.Name = "chon";
            this.chon.Width = 50;
            // 
            // anh
            // 
            this.anh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.anh.DataPropertyName = "anh";
            this.anh.FillWeight = 152.2843F;
            this.anh.HeaderText = "Ảnh";
            this.anh.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.anh.MinimumWidth = 6;
            this.anh.Name = "anh";
            this.anh.ReadOnly = true;
            this.anh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.anh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.anh.Width = 70;
            // 
            // Ma
            // 
            this.Ma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Ma.DataPropertyName = "MaSP";
            this.Ma.FillWeight = 237.8799F;
            this.Ma.HeaderText = "Mã sản phẩm";
            this.Ma.MinimumWidth = 6;
            this.Ma.Name = "Ma";
            this.Ma.ReadOnly = true;
            this.Ma.Width = 140;
            // 
            // Ten
            // 
            this.Ten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ten.DataPropertyName = "TenSP";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Ten.DefaultCellStyle = dataGridViewCellStyle16;
            this.Ten.FillWeight = 19.18386F;
            this.Ten.HeaderText = "Tên sản phẩm";
            this.Ten.MinimumWidth = 6;
            this.Ten.Name = "Ten";
            this.Ten.ReadOnly = true;
            // 
            // DanhMuc
            // 
            this.DanhMuc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DanhMuc.DataPropertyName = "DanhMuc";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DanhMuc.DefaultCellStyle = dataGridViewCellStyle17;
            this.DanhMuc.FillWeight = 19.18386F;
            this.DanhMuc.HeaderText = "Danh mục";
            this.DanhMuc.MinimumWidth = 6;
            this.DanhMuc.Name = "DanhMuc";
            this.DanhMuc.ReadOnly = true;
            this.DanhMuc.Width = 200;
            // 
            // TonKho
            // 
            this.TonKho.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TonKho.DataPropertyName = "TonKho";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TonKho.DefaultCellStyle = dataGridViewCellStyle18;
            this.TonKho.FillWeight = 19.18386F;
            this.TonKho.HeaderText = "Tồn kho";
            this.TonKho.MinimumWidth = 6;
            this.TonKho.Name = "TonKho";
            this.TonKho.ReadOnly = true;
            this.TonKho.Width = 125;
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
            this.artanPanel1.Location = new System.Drawing.Point(3, 16);
            this.artanPanel1.Name = "artanPanel1";
            this.artanPanel1.Size = new System.Drawing.Size(1162, 45);
            this.artanPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 602F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.chkBChonTatCa, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1162, 45);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(50, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ảnh";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(120, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã sản phẩm";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(260, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(602, 45);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên sản phẩm";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(862, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 45);
            this.label4.TabIndex = 3;
            this.label4.Text = "Danh mục";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(1062, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 45);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tồn kho";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkBChonTatCa
            // 
            this.chkBChonTatCa.AutoSize = true;
            this.chkBChonTatCa.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkBChonTatCa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkBChonTatCa.Location = new System.Drawing.Point(0, 0);
            this.chkBChonTatCa.Margin = new System.Windows.Forms.Padding(0);
            this.chkBChonTatCa.Name = "chkBChonTatCa";
            this.chkBChonTatCa.Size = new System.Drawing.Size(50, 45);
            this.chkBChonTatCa.TabIndex = 5;
            this.chkBChonTatCa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkBChonTatCa.UseVisualStyleBackColor = true;
            // 
            // FormDanhSachSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 798);
            this.Controls.Add(this.panelPageDanhSachSanPham);
            this.Name = "FormDanhSachSanPham";
            this.Text = "FormDanhSachSanPham";
            this.panelPageDanhSachSanPham.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox9)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrVDanhSach)).EndInit();
            this.artanPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPageDanhSachSanPham;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private RJCodeAdvance.RJControls.RJComboBox cbTrangThai;
        private RJCodeAdvance.RJControls.RJComboBox cbSapXep;
        private RJCodeAdvance.RJControls.RJComboBox cbDanhMuc;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox9;
        private RJCodeAdvance.RJControls.RJTextBox tbTimKiem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView GrVDanhSach;
        private ArtanComponent.ArtanPanel artanPanel1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chon;
        private System.Windows.Forms.DataGridViewImageColumn anh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn DanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TonKho;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkBChonTatCa;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btXoaSP;
        private RJCodeAdvance.RJControls.RJButton btThemSP;
    }
}