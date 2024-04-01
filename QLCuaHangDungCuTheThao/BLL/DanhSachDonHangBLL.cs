using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class DanhSachDonHangBLL
    {
        private List<HoaDon> listDonHang = new List<HoaDon>();

        public List<HoaDon> ListDonHang { get => listDonHang; set => listDonHang = value; }


        //Khởi tạo danh sách đơn hàng với tất cả các đơn hàng trong cơ sở dữ liệu
        public DanhSachDonHangBLL()
        {
            this.ListDonHang = DatabaseAccess.GetAllHoaDon();
        }

        //Thêm một đơn hàng vào danh sách
        public bool ThemDonHang(HoaDon donHang)
        {
            this.ListDonHang.Add(donHang);
            if (DatabaseAccess.ThemDonHang(donHang))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Xóa một đơn hàng khỏi danh sách
        public bool XoaDonHang(string maHD)
        {
            HoaDon donHang = this.ListDonHang.Find(x => x.MaHD == maHD);
            if (donHang != null)
            {
                this.ListDonHang.Remove(donHang);
            }

            if (DatabaseAccess.XoaDonHang(maHD))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Cập nhật thông tin một đơn hàng
        public bool CapNhatDonHang(HoaDon donHang)
        {
            HoaDon dh = this.ListDonHang.Find(x => x.MaHD == donHang.MaHD);
            if (dh != null)
            {
                dh.SDT = donHang.SDT;
                dh.TienKhachDua = donHang.TienKhachDua;
                dh.TienKhachPhaiTra = donHang.TienKhachPhaiTra;
                dh.TongTienHang = donHang.TongTienHang;
                dh.TraLai = donHang.TraLai;
                dh.GhiChu = donHang.GhiChu;
                dh.ThoiGianLap = donHang.ThoiGianLap;
                dh.TrangThai = donHang.TrangThai;
            }

            if (DatabaseAccess.CapNhatDonHang(donHang))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        //Set lại danh sách với các đơn hàng trong ngày cụ thể
        public void SetListDonHangTheoNgay(string ngay)
        {
            this.ListDonHang = DatabaseAccess.GetHoaDonTheoNgay(ngay);
        }

        //Set lại danh sách các đơn hàng trong khoảng thời gian cụ thể
        public void SetListDonHangTheoKhoangThoiGian(string ngayBatDau, string ngayKetThuc)
        {
            this.ListDonHang = DatabaseAccess.GetHoaDonTheoKhoangThoiGian(ngayBatDau, ngayKetThuc);
        }

        //Set lại danh sách với tất cả các đơn hàng
        public void SetListDonHang()
        {
            this.ListDonHang = DatabaseAccess.GetAllHoaDon();
        }

        //Tìm kiếm đơn hàng theo mã
        public HoaDon TimKiemDonHang(string maHD)
        {
            return this.ListDonHang.Find(x => x.MaHD == maHD);
        }

        //Tìm kiếm đơn hàng theo số điện thoại
        public List<HoaDon> TimKiemDonHangTheoSDT(string sdt)
        {
            return this.ListDonHang.FindAll(x => x.SDT == sdt);
        }

        //Tìm kiếm đơn hàng theo trạng thái
        public List<HoaDon> TimKiemDonHangTheoTrangThai(string trangThai)
        {
            return this.ListDonHang.FindAll(x => x.TrangThai == trangThai);
        }

        //Tìm kiếm đơn hàng theo nhân viên
        public List<HoaDon> TimKiemDonHangTheoNhanVien(string maNV)
        {
            return this.ListDonHang.FindAll(x => x.MaNV == maNV);
        }

    }
}
