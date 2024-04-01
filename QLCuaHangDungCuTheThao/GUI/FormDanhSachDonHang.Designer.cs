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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.GrVDanhSach = new System.Windows.Forms.DataGridView();
            this.MaDH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTaoDH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdtKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khachPhaiTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthaidh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artanPanel1 = new ArtanComponent.ArtanPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btTaoDonHang = new RJCodeAdvance.RJControls.RJButton();
            this.lbTongTienCacDonHang = new System.Windows.Forms.Label();
            this.lbSoLuongDonHang = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelPageDanhSachDonHang.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrVDanhSach)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPageDanhSachDonHang
            // 
            this.panelPageDanhSachDonHang.Controls.Add(this.groupBox2);
            this.panelPageDanhSachDonHang.Controls.Add(this.groupBox1);
            this.panelPageDanhSachDonHang.Location = new System.Drawing.Point(16, 44);
            this.panelPageDanhSachDonHang.Name = "panelPageDanhSachDonHang";
            this.panelPageDanhSachDonHang.Size = new System.Drawing.Size(1188, 698);
            this.panelPageDanhSachDonHang.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.groupBox2.Size = new System.Drawing.Size(1188, 598);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.GrVDanhSach);
            this.groupBox3.Controls.Add(this.artanPanel1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(10, 63);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1168, 532);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // GrVDanhSach
            // 
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
            this.GrVDanhSach.Location = new System.Drawing.Point(3, 61);
            this.GrVDanhSach.Name = "GrVDanhSach";
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            this.GrVDanhSach.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.GrVDanhSach.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.GrVDanhSach.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.GrVDanhSach.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            this.GrVDanhSach.RowTemplate.Height = 30;
            this.GrVDanhSach.Size = new System.Drawing.Size(1162, 468);
            this.GrVDanhSach.TabIndex = 1;
            // 
            // MaDH
            // 
            this.MaDH.DataPropertyName = "MaHD";
            this.MaDH.HeaderText = "HD00000001";
            this.MaDH.Name = "MaDH";
            this.MaDH.Width = 160;
            // 
            // NgayTaoDH
            // 
            this.NgayTaoDH.DataPropertyName = "ThoiGianLap";
            this.NgayTaoDH.HeaderText = "19/03/2004 15:07";
            this.NgayTaoDH.Name = "NgayTaoDH";
            this.NgayTaoDH.Width = 250;
            // 
            // sdtKH
            // 
            this.sdtKH.DataPropertyName = "SDT";
            this.sdtKH.HeaderText = "01234567890";
            this.sdtKH.Name = "sdtKH";
            this.sdtKH.Width = 250;
            // 
            // khachPhaiTra
            // 
            this.khachPhaiTra.DataPropertyName = "TienKhachPhaiTra";
            this.khachPhaiTra.HeaderText = "10,000,000";
            this.khachPhaiTra.Name = "khachPhaiTra";
            this.khachPhaiTra.Width = 300;
            // 
            // trangthaidh
            // 
            this.trangthaidh.DataPropertyName = "TrangThai";
            this.trangthaidh.HeaderText = "Hoan thanh";
            this.trangthaidh.Name = "trangthaidh";
            this.trangthaidh.Width = 200;
            // 
            // artanPanel1
            // 
            this.artanPanel1.BackColor = System.Drawing.Color.White;
            this.artanPanel1.BorderRadius = 30;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btTaoDonHang);
            this.groupBox1.Controls.Add(this.lbTongTienCacDonHang);
            this.groupBox1.Controls.Add(this.lbSoLuongDonHang);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1188, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hôm nay:";
            // 
            // btTaoDonHang
            // 
            this.btTaoDonHang.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btTaoDonHang.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btTaoDonHang.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btTaoDonHang.BorderRadius = 12;
            this.btTaoDonHang.BorderSize = 0;
            this.btTaoDonHang.FlatAppearance.BorderSize = 0;
            this.btTaoDonHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTaoDonHang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btTaoDonHang.ForeColor = System.Drawing.Color.White;
            this.btTaoDonHang.Location = new System.Drawing.Point(1028, 36);
            this.btTaoDonHang.Name = "btTaoDonHang";
            this.btTaoDonHang.Size = new System.Drawing.Size(150, 40);
            this.btTaoDonHang.TabIndex = 1;
            this.btTaoDonHang.Text = "Tạo đơn hàng";
            this.btTaoDonHang.TextColor = System.Drawing.Color.White;
            this.btTaoDonHang.UseVisualStyleBackColor = false;
            // 
            // lbTongTienCacDonHang
            // 
            this.lbTongTienCacDonHang.AutoSize = true;
            this.lbTongTienCacDonHang.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTongTienCacDonHang.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTongTienCacDonHang.Location = new System.Drawing.Point(477, 48);
            this.lbTongTienCacDonHang.Name = "lbTongTienCacDonHang";
            this.lbTongTienCacDonHang.Size = new System.Drawing.Size(144, 25);
            this.lbTongTienCacDonHang.TabIndex = 5;
            this.lbTongTienCacDonHang.Text = "10,000,000 VNĐ";
            this.lbTongTienCacDonHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbSoLuongDonHang
            // 
            this.lbSoLuongDonHang.AutoSize = true;
            this.lbSoLuongDonHang.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSoLuongDonHang.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbSoLuongDonHang.Location = new System.Drawing.Point(162, 48);
            this.lbSoLuongDonHang.Name = "lbSoLuongDonHang";
            this.lbSoLuongDonHang.Size = new System.Drawing.Size(118, 25);
            this.lbSoLuongDonHang.TabIndex = 3;
            this.lbSoLuongDonHang.Text = "14 đơn hàng";
            this.lbSoLuongDonHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(314, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 40);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tổng tiền:";
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrVDanhSach)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPageDanhSachDonHang;
        private System.Windows.Forms.Label label1;
        private RJCodeAdvance.RJControls.RJButton btTaoDonHang;
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
    }
}