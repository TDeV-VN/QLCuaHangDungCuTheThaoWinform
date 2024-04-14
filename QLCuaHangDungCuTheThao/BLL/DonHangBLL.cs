using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web.WebSockets;
using DAL;
using DTO;

namespace BLL
{
    public class DonHangBLL
    {
        private List<ChiTietHoaDon> listChiTietHD;
        private HoaDon hoaDon;


        public List<ChiTietHoaDon> ListChiTietHD { get => listChiTietHD; set => listChiTietHD = value; }
        public HoaDon HoaDon { get => hoaDon; set => hoaDon = value; }

        public DonHangBLL()
        {
            this.ListChiTietHD = new List<ChiTietHoaDon>();
            this.HoaDon = new HoaDon(AutoGenerateMaHD());
        }

        //sinh tự động mã đơn hàng
        private string AutoGenerateMaHD()
        {
            return DatabaseAccess.AutoGenerateMaHD();
        }

        //Thêm ChiTietHoaDon vào danh sách
        public bool ThemChiTietHoaDon(string masp)
        {
            //Kiểm tra sản phẩm đã có trong danh sách chưa, nếu đã có thì cộng số lượng thêm 1, cập nhật tiền và return false
            if (GetChiTietHoaDon(masp) != null)
            {
                UpdateSoLuongChiTietHoaDon(masp, GetChiTietHoaDon(masp).SoLuong + 1);
                return false;
            }
            SanPham sp = DatabaseAccess.GetSanPham(masp);
            ChiTietHoaDon cthd = new ChiTietHoaDon(HoaDon.MaHD, sp.MaSP, 1, sp.GiaBan);
            ListChiTietHD.Add(cthd);
            UpdateSoLuongChiTietHoaDon(masp, 1); //để cập nhật tiền
            return true;
        }

        // Gợi ý sản phẩm khi tìm kiếm sản phẩm
        public static DataTable LoadResults_For_SearchSPTextbox(string text)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MaSP");
            dt.Columns.Add("TenSP");
            return DatabaseAccess.findSanPhamByUncompletedString(text);
        }

        //Lấy chi tiết hóa đơn trong listChiTietHD
        public ChiTietHoaDon GetChiTietHoaDon(string maSP)
        {
            return ListChiTietHD.Find(x => x.MaSP == maSP);
        }

        //Update số lượng
        public void UpdateSoLuongChiTietHoaDon(string maSP, string soLuongMoi)
        {
            for (int i = 0; i < listChiTietHD.Count(); i++)
            {
                if (listChiTietHD[i].MaSP == maSP)
                {
                    listChiTietHD[i].SoLuong = int.Parse(soLuongMoi);
                    hoaDon.TongTienHang = listChiTietHD.Sum(cthd => cthd.DonGia * cthd.SoLuong);
                    hoaDon.TienKhachPhaiTra = hoaDon.TongTienHang - hoaDon.ChietKhau;
                }
            }
        }
        public void UpdateSoLuongChiTietHoaDon(string maSP, int soLuongMoi)
        {
            for (int i = 0; i < listChiTietHD.Count(); i++)
            {
                if (listChiTietHD[i].MaSP == maSP)
                {
                    listChiTietHD[i].SoLuong = soLuongMoi;
                    hoaDon.TongTienHang = listChiTietHD.Sum(cthd => cthd.DonGia * cthd.SoLuong);
                    hoaDon.TienKhachPhaiTra = hoaDon.TongTienHang - hoaDon.ChietKhau;
                }
            }
        }

        // Nhập sdt
        public void NhapSDT(string sdt)
        {
            hoaDon.SDT = sdt;
        }

        public bool TaoDonHang()
        {
            // test start
            HoaDon hd = new HoaDon(AutoGenerateMaHD(), "NV001", "09098282727", "chuyển khoản", 25, "2023-4-2", 9000000, 10000000, 9000000, 1000000, "Đan lưới màu Hồng");
            List<ChiTietHoaDon> cthd = new List<ChiTietHoaDon>();
            cthd.Add(new ChiTietHoaDon(AutoGenerateMaHD(), "SP00001", 3, 3000000));
            DatabaseAccess.ThemDonHang(hd, cthd);
            // test end
            return false;
        }

        public void InHoaDon()
        {
            //In hóa đơn
        }

        //Xóa chi tiết hóa đơn
        public void XoaChiTietHoaDon(string maSP)
        {
            ChiTietHoaDon cthd = GetChiTietHoaDon(maSP);
            UpdateSoLuongChiTietHoaDon(maSP, 0);
            listChiTietHD.Remove(cthd);
        }
    }
}
