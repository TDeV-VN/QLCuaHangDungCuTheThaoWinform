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
        private List<HoaDon> listDonHang;
        DanhSachDonHangBLL danhSachDonHangBLL = new DanhSachDonHangBLL();

        //dữ liệu test
        private void TaoDuLieuTest()
        {
            listDonHang.Add(new HoaDon("HD001", "NV001", "0123456789", "Tiền mặt", 10000000, "2021-12-12", 10000000, 10000000, 10000000, 10000000, "Ghi chú 1", "Hoàn thành"));
            listDonHang.Add(new HoaDon("HD002", "NV002", "0123456789", "Tiền mặt", 0, "2021-12-12", 10000000, 100000, 100000, 0, "Ghi chú 2", "Đã hủy"));
            listDonHang.Add(new HoaDon("HD003", "NV003", "0123456789", "Tiền mặt", 0, "2021-12-12", 100000, 100000, 100000, 0, "Ghi chú 3", "Hoàn thành"));
        }
        public FormDanhSachDonHang()
        {
            InitializeComponent();
            this.listDonHang = danhSachDonHangBLL.ListDonHang;
            GrVDanhSach.DataSource = listDonHang;
            FormDanhSachDonHang_Load(this, null);
            LoadDanhSach();
        }
        public Panel PanelPageDanhSachDonHang
        {
            get
            {
                return panelPageDanhSachDonHang;
            }
        }

        public void FormDanhSachDonHang_Load(object sender, EventArgs e)
        {
        }

        private void LoadDanhSach()
        {
            TaoDuLieuTest();
        }

    }
}
