using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace DAL
{
    public class DatabaseAccess
    {
        static string connectionString = @"";

        // Tạo kết nối đến cơ sở dữ liệu
       /* public static Connection GetConnection()
        {
            return new (connectionString);
        }*/

        // Lấy tất cả các đơn hàng từ cơ sở dữ liệu
        public static List<HoaDon> GetAllHoaDon()
        {
            List<HoaDon> listDonHang = new List<HoaDon>();


            return listDonHang;
        }

        // Thêm một đơn hàng vào cơ sở dữ liệu
        public static bool ThemDonHang(HoaDon hoaDon)
        {

            return true;
        }

        // Xóa một đơn hàng khỏi cơ sở dữ liệu
        public static bool XoaDonHang(string maHD)
        {

            return true;
        }

        // Cập nhật thông tin một đơn hàng trong cơ sở dữ liệu
        public static bool CapNhatDonHang(HoaDon hoaDon)
        {

            return true;
        }

        // Lấy thông tin một đơn hàng từ cơ sở dữ liệu
        public static HoaDon GetHoaDon(string maHD)
        {


            return null;
        }

        // Lấy các hóa đơn theo ngày
        public static List<HoaDon> GetHoaDonTheoNgay(string ngay)
        {
            List<HoaDon> listDonHang = new List<HoaDon>();

            return listDonHang;
        }

        // Lấy các hóa đơn theo tháng
        public static List<HoaDon> GetHoaDonTheoThang(string thang)
        {
            List<HoaDon> listDonHang = new List<HoaDon>();

            return listDonHang;
        }

        // Lấy các hóa đơn thoe khoảng thời gian
        public static List<HoaDon> GetHoaDonTheoKhoangThoiGian(string ngayBatDau, string ngayKetThuc)
        {
            List<HoaDon> listDonHang = new List<HoaDon>();

            return listDonHang;
        }



        // Lấy thông tin một sản phẩm từ cơ sở dữ liệu
        public static SanPham GetSanPham(string maSP)
        {


            return null;
        }

        // Lấy thông tin tất cả các sản phẩm từ cơ sở dữ liệu
        public static List<SanPham> GetAllSanPham()
        {
            List<SanPham> listSanPham = new List<SanPham>();

            return listSanPham;
        }



        // Lấy mã một nhân viên bằng sdt từ cơ sở dữ liệu
        public static string GetMaNV(string sdt)
        {
            return "NV001";
        }

        //BO Lấy thông tin một nhân viên từ cơ sở dữ liệu
        public static TaiKhoan GetNhanVien(string maNV)
        {
            return null;
        }

        //BO Lấy thông tin tất cả các nhân viên từ cơ sở dữ liệu
        public static List<TaiKhoan> GetAllNhanVien()
        {
            List<TaiKhoan> listNhanVien = new List<TaiKhoan>();

            return listNhanVien;
        }


        // Lấy thông tin một khách hàng từ cơ sở dữ liệu
        public static KhachHang GetKhachHang(string sdt)
        {
            return null;
        }

        // Lấy thông tin tất cả các khách hàng từ cơ sở dữ liệu
        public static List<KhachHang> GetAllKhachHang()
        {
            List<KhachHang> listKhachHang = new List<KhachHang>();

            return listKhachHang;
        }





        // Lấy thông tin tất cả các danh mục sản phẩm từ cơ sở dữ liệu
        public static List<DanhMucSanPham> GetAllDanhMucSanPham()
        {
            List<DanhMucSanPham> listDanhMucSanPham = new List<DanhMucSanPham>();

            return listDanhMucSanPham;
        }

        // Lấy thông tin một danh mục sản phẩm từ cơ sở dữ liệu
        public static DanhMucSanPham GetDanhMucSanPham(string maDM)
        {
            return null;
        }

        // Lấy mã hóa đơn đầu tiên sau khi sắp xếp giảm dần
        public static string GetTopMaHD()
        {
            
            return "HD00000999";
        }

    }
}
