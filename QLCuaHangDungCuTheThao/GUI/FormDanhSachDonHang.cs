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
        //static private QLCuaHangDungCuTheThao qlCuaHangDungCuTheThao = new QLCuaHangDungCuTheThao();

        public FormDanhSachDonHang()
        {
            InitializeComponent();
            GrVDanhSach.AutoGenerateColumns = false;
            GrVDanhSach.DataSource = danhSachDonHangBLL.ListDonHang;
        }
        public Panel PanelPageDanhSachDonHang
        {
            get
            {
                TaoDataChoComboBox();
                //Hai dòng dưới không hoạt động đúng mong muốn
                lbSoLuongDonHang.Text = DanhSachDonHangBLL.LaySoLuongDonHangHomNay().ToString() + " đơn hàng";
                lbTongTienCacDonHang.Text = DanhSachDonHangBLL.LayTongTienHomNay().ToString("N0") + " VNĐ";
                LoadDanhSach();
                return panelPageDanhSachDonHang;
            }
        }

        /*-----------------------------------------------SỰ KIỆN------------------------------------------------*/

        // ngăn chặn tự động chọn dòng đầu tiên trong danh sách
        private void yourDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            GrVDanhSach.ClearSelection();
        }

        private void btTaoDonHang_Click(object sender, EventArgs e)
        {
            //qlCuaHangDungCuTheThao.btTabPageTaoDon_Click(null, null);
        }

        /*----------------------------------------------- HẾT SỰ KIỆN------------------------------------------------*/

        private void LoadDanhSach()
        {


            GrVDanhSach.AutoGenerateColumns = false;
        }

        //Tạo data cho combobox
        private void TaoDataChoComboBox()
        {
            //Tạo data cho combobox ngày tạo
            List<string> listNgayTao = new List<string>();
            listNgayTao.Add("Tất cả");
            listNgayTao.Add("Hôm nay");
            listNgayTao.Add("Hôm qua");
            listNgayTao.Add("Tuần này");
            listNgayTao.Add("Tháng này");
            cbNgayTao.DataSource = listNgayTao;
            cbNgayTao.SelectedItem = "Tất cả";


            //Tạo data cho combobox trạng thái
            List<string> listTrangThai = new List<string>();
            listTrangThai.Add("Tất cả");
            listTrangThai.Add("Hoàn thành");
            listTrangThai.Add("Đã hủy");

            cbTrangThai.DataSource = listTrangThai;

            //Tạo data cho combobox nhân viên
            List<string> listNhanVien = new List<string>();
            listNhanVien.Add("Tất cả");
            listNhanVien.Add("Nguyễn Văn A");
            listNhanVien.Add("Nguyễn Văn B");
            listNhanVien.Add("Nguyễn Văn C");
            listNhanVien.Add("Nguyễn Văn D");
            cbNhanVien.DataSource = listNhanVien;
        }


    }
}
