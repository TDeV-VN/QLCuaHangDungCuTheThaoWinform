using BLL;
using System;
using System.Drawing;
using System.Windows.Documents;
using System.Windows.Forms;

namespace GUI
{
    public partial class QLCuaHangDungCuTheThao : Form
    {
        //public static QLCuaHangDungCuTheThao instance { get; private set; } // dùng để gọi các hàng của form này ở những form khác mà không cần khởi tạo đối tượng cũng không cần static
        public QLCuaHangDungCuTheThao()
        {
            InitializeComponent();
            //instance = this;
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
        private void btHuongDan_Click(object sender, EventArgs e)
        {

        }

        /*sự kiện các button tabpage được click*/
        public void Form_Load(object sender, EventArgs e)
        {
            btTabPageTongQuan_Click(sender, e);
            panelMenuQLTaiKhoan.Visible = false;
            formDangNhap.ShowDialog();
            dangNhap();
        }

        private void btSportShop_Click(object sender, EventArgs e)
        {
            btTabPageTongQuan_Click(sender, e);
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
            panelPageTaoDonHang = formTaoDonHang.PanelPageTaoDonHang;
            panelPageTaoDonHang.Location = new Point(227, 68);
            this.Controls.Add(panelPageTaoDonHang);
        }

        private void btTabPageDanhSachDH_Click(object sender, EventArgs e)
        {
            CapNhatViTriLbPageHeader("Danh sách đơn hàng");
            RemoveAllPagePanel();
            panelPageDanhSachDonHang = formDanhSachDonHang.PanelPageDanhSachDonHang;
            panelPageDanhSachDonHang.Location = new Point(227, 68);
            formDanhSachDonHang.setLbSoLuong_TongTien();
            this.Controls.Add(panelPageDanhSachDonHang);
        }

        private void btTabPageDanhSachSP_Click(object sender, EventArgs e)
        {
            CapNhatViTriLbPageHeader("Danh sách sản phẩm");
            RemoveAllPagePanel();
            panelPageDanhSachSanPham = formDanhSachSanPham.PanelPageDanhSachSanPham;
            panelPageDanhSachSanPham.Location = new Point(227, 68);
            this.Controls.Add(panelPageDanhSachSanPham);
        }

        private void btTabPageDanhMucSP_Click(object sender, EventArgs e)
        {
            CapNhatViTriLbPageHeader("Danh mục sản phẩm");
            RemoveAllPagePanel();
            panelPageDanhMucSanPham = formDanhMucSanPham.PanelPageDanhMucSanPham;
            panelPageDanhMucSanPham.Location = new Point(227, 68);
            this.Controls.Add(panelPageDanhMucSanPham);
        }

        private void btTabPageKhachHang_Click(object sender, EventArgs e)
        {
            CapNhatViTriLbPageHeader("Khách hàng");
            RemoveAllPagePanel();
            panelPageKhachHang = formKhachHang.PanelPageKhachHang;
            panelPageKhachHang.Location = new Point(227, 68);
            this.Controls.Add(panelPageKhachHang);
        }

        private void btTabPagePhieuThu_Click(object sender, EventArgs e)
        {
            CapNhatViTriLbPageHeader("Phiếu thu");
            RemoveAllPagePanel();
            panelPagePhieuThu = formPhieuThu.PanelPagePhieuThu;
            panelPagePhieuThu.Location = new Point(227, 68);
            this.Controls.Add(panelPagePhieuThu);
        }

        private void btTabPagePhieuChi_Click(object sender, EventArgs e)
        {
            CapNhatViTriLbPageHeader("Phiếu chi");
            RemoveAllPagePanel();
            panelPagePhieuChi = formPhieuChi.PanelPagePhieuChi;
            panelPagePhieuChi.Location = new Point(227, 68);
            this.Controls.Add(panelPagePhieuChi);
        }

        private void btTabPageSoQuy_Click(object sender, EventArgs e)
        {
            CapNhatViTriLbPageHeader("Sổ quỹ");
            RemoveAllPagePanel();
            panelPageSoQuy = formSoQuy.PanelPageSoQuy;
            panelPageSoQuy.Location = new Point(227, 68);
            this.Controls.Add(panelPageSoQuy);
        }

        private void btTabPageBaoCao_Click(object sender, EventArgs e)
        {
            CapNhatViTriLbPageHeader("Báo cáo");
            RemoveAllPagePanel();
            panelPageBaoCao = formBaoCao.PanelPageBaoCao;
            panelPageBaoCao.Location = new Point(227, 68);
            this.Controls.Add(panelPageBaoCao);
        }


        //sự kiện click vào group tài khoản trên header
        private void btIconUser_Click(object sender, EventArgs e)
        {
            panelMenuQLTaiKhoan.Visible = !panelMenuQLTaiKhoan.Visible;
            if (TaiKhoanBLL.TaiKhoan.MaNV == "")
            {
                btDangNhap.Enabled = true;
                btDoiMK.Visible = false;
                btDangXuat.Visible = false;
                btDangNhap.Text = "Đăng nhập";
            } else
            {
                btDangNhap.Enabled = false;
                btDoiMK.Visible = true;
                btDangXuat.Visible = true;
                btDangNhap.Text = TaiKhoanBLL.TaiKhoan.MaNV;
            }
        }

        private void btIconUser_text_Click(object sender, EventArgs e)
        {
            btIconUser_Click(null, null);
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            formDangNhap = new FormDangNhap();
            formDangNhap.ShowDialog();
            dangNhap();
            btIconUser_Click(sender, e);
            btTabPageTongQuan_Click(sender, e);
        }

        private void btDoiMK_Click(object sender, EventArgs e)
        {
            formDangNhap = new FormDangNhap();
            formDangNhap.lbQuenMK_LinkClicked(sender, null);
            formDangNhap.ShowDialog();
            dangNhap();
            btIconUser_Click(sender, e);
            btTabPageTongQuan_Click(sender, e);
        }

        private void btDangXuat_Click(object sender, EventArgs e)
        {
            TaiKhoanBLL.TaiKhoan = new TaiKhoan();
            dangNhap();
            btIconUser_Click(sender, e);
            btTabPageTongQuan_Click(sender, e);
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

        private void dangNhap()
        {
            if (TaiKhoanBLL.TaiKhoan.MaNV != "") //Đã đăng nhập
            {
                //Kích hoạt tất cả chức năng
                foreach (Control control in panel1.Controls)
                {
                    if (control.Name.Equals("btSportShop") || control.Name.Equals("panelTongQuan1")) continue;
                    control.Enabled = true;
                }
                iconPictureBox3.IconColor = Color.WhiteSmoke;
                iconPictureBox8.IconColor = Color.WhiteSmoke;
                iconPictureBox4.IconColor = Color.WhiteSmoke;
                iconPictureBox6.IconColor = Color.WhiteSmoke;
                iconPictureBox5.IconColor = Color.WhiteSmoke;

                if (TaiKhoanBLL.TaiKhoan.Role == true) //Quan ly
                {
                    btTabPageQuanLy.Enabled = true;
                    iconPictureBox5.IconColor = Color.WhiteSmoke;
                }
                else //Nhan vien
                {
                    btTabPageQuanLy.Enabled = false;
                    iconPictureBox5.IconColor = Color.FromArgb(12, 14, 16);
                }

            }
            else //Chưa đăng nhập
            {
                //Vô hiệu hóa tất cả chức năng
                foreach (Control control in panel1.Controls)
                {
                    if (control.Name.Equals("btSportShop") || control.Name.Equals("panelTongQuan1")) continue;
                    control.Enabled = false;
                }
                iconPictureBox3.IconColor = Color.FromArgb(12, 14, 16);
                iconPictureBox8.IconColor = Color.FromArgb(12, 14, 16);
                iconPictureBox4.IconColor = Color.FromArgb(12, 14, 16);
                iconPictureBox6.IconColor = Color.FromArgb(12, 14, 16);
                iconPictureBox5.IconColor = Color.FromArgb(12, 14, 16);
            }
        }


        /*-----------------------------------------------HẾT CÁC HÀM XỬ LÝ------------------------------------------------*/
    }
}

