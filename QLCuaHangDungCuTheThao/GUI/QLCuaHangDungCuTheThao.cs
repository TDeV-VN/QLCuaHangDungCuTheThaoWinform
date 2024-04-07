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
    public partial class QLCuaHangDungCuTheThao : Form
    {
        public QLCuaHangDungCuTheThao()
        {
            InitializeComponent();
            Form_Load(this, EventArgs.Empty);
        }
        
        static private FormDanhSachDonHang formDanhSachDonHang = new FormDanhSachDonHang();
        static private FormTongQuan formTongQuan = new FormTongQuan();
        static private FormTaoDonHang formTaoDonHang = new FormTaoDonHang();
        static private FormDanhSachSanPham formDanhSachSanPham = new FormDanhSachSanPham();
        static private FormDanhMucSanPham formDanhMucSanPham = new FormDanhMucSanPham();
        static private FormKhachHang formKhachHang = new FormKhachHang();
        static private FormPhieuThu formPhieuThu = new FormPhieuThu();
        static private FormPhieuChi formPhieuChi = new FormPhieuChi();
        static private FormSoQuy formSoQuy = new FormSoQuy();
        static private FormBaoCao formBaoCao = new FormBaoCao();
        static private FormDangNhap formDangNhap = new FormDangNhap();

        static private Panel panelPageTongQuan = formTongQuan.PanelPageTongQuan;
        static private Panel panelPageTaoDonHang = formTaoDonHang.PanelPageTaoDonHang;
        static private Panel panelPageDanhSachDonHang = formDanhSachDonHang.PanelPageDanhSachDonHang;
        static private Panel panelPageDanhSachSanPham = formDanhSachSanPham.PanelPageDanhSachSanPham;
        static private Panel panelPageDanhMucSanPham = formDanhMucSanPham.PanelPageDanhMucSanPham;
        static private Panel panelPageKhachHang = formKhachHang.PanelPageKhachHang;
        static private Panel panelPagePhieuThu = formPhieuThu.PanelPagePhieuThu;
        static private Panel panelPagePhieuChi = formPhieuChi.PanelPagePhieuChi;
        static private Panel panelPageSoQuy = formSoQuy.PanelPageSoQuy;
        static private Panel panelPageBaoCao = formBaoCao.PanelPageBaoCao;



        /*--------------------------------------------------SỰ KIỆN---------------------------------------------------*/
        /*sự kiện các button tabpage được click*/
        public void Form_Load(object sender, EventArgs e)
        {
            btTabPageTongQuan_Click(sender, e);
        }
        private void btSportShop_Click(object sender, EventArgs e)
        {
            btTabPageTongQuan_Click(sender, e);
            //test
            formDangNhap.Show();
        }
        private void btTabPageTongQuan_Click(object sender, EventArgs e)
        {
            CapNhatViTriLbPageHeader("Tổng quan");
            RemoveAllPagePanel();
            panelPageTongQuan.Location = new Point(227, 68);
            this.Controls.Add(panelPageTongQuan);

        }

        public void btTabPageTaoDon_Click(object sender, EventArgs e)
        {
            CapNhatViTriLbPageHeader("Tạo đơn hàng");
            RemoveAllPagePanel();
            panelPageTaoDonHang.Location = new Point(227, 68);
            this.Controls.Add(panelPageTaoDonHang);
        }

        private void btTabPageDanhSachDH_Click(object sender, EventArgs e)
        {
            CapNhatViTriLbPageHeader("Danh sách đơn hàng");
            RemoveAllPagePanel();
            panelPageDanhSachDonHang.Location = new Point(227, 68);
            formDanhSachDonHang.setLbSoLuong_TongTien();
            this.Controls.Add(panelPageDanhSachDonHang);
        }

        private void btTabPageDanhSachSP_Click(object sender, EventArgs e)
        {
            CapNhatViTriLbPageHeader("Danh sách sản phẩm");
            RemoveAllPagePanel();
            panelPageDanhSachSanPham.Location = new Point(227, 68);
            this.Controls.Add(panelPageDanhSachSanPham);
        }

        private void btTabPageDanhMucSP_Click(object sender, EventArgs e)
        {
            CapNhatViTriLbPageHeader("Danh mục sản phẩm");
            RemoveAllPagePanel();
            panelPageDanhMucSanPham.Location = new Point(227, 68);
            this.Controls.Add(panelPageDanhMucSanPham);
        }

        private void btTabPageKhachHang_Click(object sender, EventArgs e)
        {
            CapNhatViTriLbPageHeader("Khách hàng");
            RemoveAllPagePanel();
            panelPageKhachHang.Location = new Point(227, 68);
            this.Controls.Add(panelPageKhachHang);
        }

        private void btTabPagePhieuThu_Click(object sender, EventArgs e)
        {
            CapNhatViTriLbPageHeader("Phiếu thu");
            RemoveAllPagePanel();
            panelPagePhieuThu.Location = new Point(227, 68);
            this.Controls.Add(panelPagePhieuThu);
        }

        private void btTabPagePhieuChi_Click(object sender, EventArgs e)
        {
            CapNhatViTriLbPageHeader("Phiếu chi");
            RemoveAllPagePanel();
            panelPagePhieuChi.Location = new Point(227, 68);
            this.Controls.Add(panelPagePhieuChi);
        }

        private void btTabPageSoQuy_Click(object sender, EventArgs e)
        {
            CapNhatViTriLbPageHeader("Sổ quỹ");
            RemoveAllPagePanel();
            panelPageSoQuy.Location = new Point(227, 68);
            this.Controls.Add(panelPageSoQuy);
        }

        private void btTabPageBaoCao_Click(object sender, EventArgs e)
        {
            CapNhatViTriLbPageHeader("Báo cáo");
            RemoveAllPagePanel();
            panelPageBaoCao.Location = new Point(227, 68);
            this.Controls.Add(panelPageBaoCao);
        }


        //sự kiện click vào group tài khoản trên header
        private void btIconUser_Click(object sender, EventArgs e)
        {

        }

        private void btIconUser_text_Click(object sender, EventArgs e)
        {

        }

        /*------------------------------------------------HẾT CÁC SỰ KIỆN-------------------------------------------------*/

        /*------------------------------------------------CÁC HÀM XỬ LÝ---------------------------------------------------*/
        //đặt lại văn bản và vị trí cho label header
        private void CapNhatViTriLbPageHeader(string vanBanMoi)
        {
            // cập nhật văn bản
            lbPageHeader.Text = vanBanMoi;

            // đặt vị trí trung tâm cố định
            int fixedCenterPosition = 594;
            int labelWidth = lbPageHeader.Width;
            int newLeftPosition = fixedCenterPosition - (labelWidth / 2);

            // vẽ lại vị trí
            lbPageHeader.Left = newLeftPosition;
        }

        //remove tất cả page panel để chuyển page mới
        private void RemoveAllPagePanel()
        {
            this.Controls.Remove(panelPageTongQuan);
            this.Controls.Remove(panelPageTaoDonHang);
            this.Controls.Remove(panelPageDanhSachDonHang);
            this.Controls.Remove(panelPageDanhSachSanPham);
            this.Controls.Remove(panelPageDanhMucSanPham);
            this.Controls.Remove(panelPageKhachHang);
            this.Controls.Remove(panelPagePhieuThu);
            this.Controls.Remove(panelPagePhieuChi);
            this.Controls.Remove(panelPageSoQuy);
            this.Controls.Remove(panelPageBaoCao);
        }

        /*-----------------------------------------------HẾT CÁC HÀM XỬ LÝ------------------------------------------------*/
    }
}

