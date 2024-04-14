using BLL;
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
    public partial class FormDanhSachDonHang : Form
    {
        DanhSachDonHangBLL danhSachDonHangBLL = new DanhSachDonHangBLL();
        public FormDanhSachDonHang()
        {
            InitializeComponent();
            tbTimKiemDH.Focus();
            GrVDanhSach.AutoGenerateColumns = false;
            GrVDanhSach.DataSource = danhSachDonHangBLL.ListDonHang;
        }
        public Panel PanelPageDanhSachDonHang
        {
            get
            {
                TaoDataChoComboBox();
                return panelPageDanhSachDonHang;
            }
        }

        /*-----------------------------------------------SỰ KIỆN------------------------------------------------*/

        // ngăn chặn tự động chọn dòng đầu tiên trong danh sách
        private void yourDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            GrVDanhSach.ClearSelection();
        }

/*        private void btTaoDonHang_Click(object sender, EventArgs e)
        {
            QLCuaHangDungCuTheThao qLCuaHangDungCuTheThao = new QLCuaHangDungCuTheThao();
            qLCuaHangDungCuTheThao.btTabPageTaoDon_Click(null, null);
        }*/

        /*----------------------------------------------- HẾT SỰ KIỆN------------------------------------------------*/

        public void setLbSoLuong_TongTien()
        {
            lbSoLuongDonHang.Text = DanhSachDonHangBLL.LaySoLuongDonHangHomNay().ToString() + " đơn hàng";
            lbTongTienCacDonHang.Text = DanhSachDonHangBLL.LayTongTienHomNay().ToString("N0") + " VNĐ";
        }

        private void TaoDataChoComboBox()
        {
            cbNgayTao.DataSource = DanhSachDonHangBLL.GetDSNgayTao();
            cbNgayTao.SelectedItem = "Tất cả";
            cbTrangThai.DataSource = DanhSachDonHangBLL.GetDSTrangThai();
            cbTrangThai.SelectedItem = "Tất cả";
            cbNhanVien.DataSource = DanhSachDonHangBLL.GetDSTenNhanVien();

            cbNhanVien.SelectedItem = "Tất cả";
        }
    }
}
