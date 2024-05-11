﻿using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormDanhSachSanPham : Form
    {
        DanhSachSanPhamBLL danhSachSanPhamBLL;
        public FormDanhSachSanPham()
        {
            InitializeComponent();
            tbTimKiem.Focus();
            GrVDanhSach.AutoGenerateColumns = false;
            
        }
        public Panel PanelPageDanhSachSanPham
        {
            get
            {
                danhSachSanPhamBLL = new DanhSachSanPhamBLL();
                GrVDanhSach.DataSource = danhSachSanPhamBLL.Listsanpham;
                GrVDanhSach.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                taoDataChoComboBox();
                return panelPageDanhSachSanPham;
            }
        }
        /*-----------------------------------------------SỰ KIỆN------------------------------------------------*/
        // ngăn chặn tự động chọn dòng đầu tiên trong danh sách
        private void yourDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            GrVDanhSach.ClearSelection();
        }

        private void btThemSP_Click(object sender, EventArgs e)
        {
            FormThemSP formThemSP = new FormThemSP();
            formThemSP.ShowDialog();
        }

        private void btXoaSP_Click(object sender, EventArgs e)
        {


        }

        private void GrVDanhSach_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormChiTietSP formChiTietSP = new FormChiTietSP(danhSachSanPhamBLL.Listsanpham.Rows[e.RowIndex]["MaSP"].ToString());
            formChiTietSP.ShowDialog();
            //refresh lại danh sách sản phẩm phòng trường hợp xóa sản phẩm
            if (XemChiTietSPBLL.xoa)
            {
                danhSachSanPhamBLL = new DanhSachSanPhamBLL();
                GrVDanhSach.DataSource = danhSachSanPhamBLL.Listsanpham;
                GrVDanhSach.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                XemChiTietSPBLL.xoa = false;
            }

        }
    /*----------------------------------------------- HẾT SỰ KIỆN------------------------------------------------*/
    private void taoDataChoComboBox()
        {
            cbDanhMuc.DataSource = danhSachSanPhamBLL.getDanhMuc();
            cbDanhMuc.SelectedItem = "Tất cả";
            cbTrangThai.DataSource = danhSachSanPhamBLL.getTrangThai();
            cbTrangThai.SelectedItem = "Tất cả";
            cbSapXep.DataSource = danhSachSanPhamBLL.getSapXep();
            cbSapXep.SelectedItem = "Mặc định";
        }


    }
}
