using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DatabaseAccess
    {
        private static string connectionString = @"Data Source=Tien-laptop;Initial Catalog=QuanLyCuaHangDungCuTheThao;Integrated Security=True;Trust Server Certificate=True";

        // Tạo kết nối đến cơ sở dữ liệu
       /* public static Connection GetConnection()
        {
            return new (connectionString);
        }*/

        // Lấy tất cả các đơn hàng từ cơ sở dữ liệu
        public static List<HoaDon> GetAllHoaDon()
        {
            List<HoaDon> listDonHang = new List<HoaDon>();

            listDonHang.Add(new HoaDon("HD001", "NV001", "0123456789", "Tiền mặt", 10000000, "2021-12-12", 10000000, 10000000, 10000000, 10000000, "Ghi chú 1"));
            listDonHang.Add(new HoaDon("HD002", "NV002", "0123456789", "Tiền mặt", 0, "2021-12-12", 10000000, 100000, 100000, 0, "Ghi chú 2"));
            listDonHang.Add(new HoaDon("HD003", "NV003", "0123456789", "Tiền mặt", 0, "2021-12-12", 100000, 100000, 100000, 0, "Ghi chú 3"));

            return listDonHang;


        }

        // Lấy thông tin một sản phẩm từ cơ sở dữ liệu
        public static SanPham GetSanPham(string maSP)
        {
            //test
            SanPham sp = new SanPham("SP00001", "DM001", "Áo thun nam", 100, 10000000, 15000000, true, "Áo thun nam màu đen");

            return sp;
        }

        // Lấy thông tin tất cả các sản phẩm từ cơ sở dữ liệu
        public static List<SanPham> GetAllSanPham()
        {
            List<SanPham> listSanPham = new List<SanPham>();

            return listSanPham;
        }

        public static string AutoGenerateMaHD()
        {
            Random random = new Random();
            string randomString = "HD" + random.Next(0, 99999999).ToString("D8");
            return randomString;
        }

        // Thêm một đơn hàng và các chi tiết hóa đơn cảu nó vào cơ sở dữ liệu
        public static bool ThemDonHang(HoaDon hoaDon, List<ChiTietHoaDon> listChiTietHD)
        {
            return true;
        }

        public static List<string> GetAllDanhMuc()
        {
            List<string> listDanhMuc = new List<string>();
            listDanhMuc.Add("Áo thun");
            listDanhMuc.Add("Quần dài");

            return listDanhMuc;
        }

        public static List<string> GetDSTenNhanVien()
        {
            List<string> listTenNhanVien = new List<string>();
            listTenNhanVien.Add("Nguyễn Văn A");
            listTenNhanVien.Add("Nguyễn Văn B");
            listTenNhanVien.Add("Nguyễn Văn C");

            return listTenNhanVien;
        }

    }
}
