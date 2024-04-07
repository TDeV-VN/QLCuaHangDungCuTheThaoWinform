using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using DTO;
using System.Windows.Forms;

namespace DAL
{
    public class DatabaseAccess
    {
        static string connectionString = @"Data Source=Tien-laptop;Initial Catalog=QuanLyCuaHangDungCuTheThao;Integrated Security=True;Trust Server Certificate=True";

        // Tạo kết nối đến cơ sở dữ liệu
       /* public static Connection GetConnection()
        {
            return new (connectionString);
        }*/

        // Lấy tất cả các đơn hàng từ cơ sở dữ liệu
        public static List<HoaDon> GetAllHoaDon()
        {
            /*List<HoaDon> listDonHang = new List<HoaDon>();

            listDonHang.Add(new HoaDon("HD001", "NV001", "0123456789", "Tiền mặt", 10000000, "2021-12-12", 10000000, 10000000, 10000000, 10000000, "Ghi chú 1"));
            listDonHang.Add(new HoaDon("HD002", "NV002", "0123456789", "Tiền mặt", 0, "2021-12-12", 10000000, 100000, 100000, 0, "Ghi chú 2"));
            listDonHang.Add(new HoaDon("HD003", "NV003", "0123456789", "Tiền mặt", 0, "2021-12-12", 100000, 100000, 100000, 0, "Ghi chú 3"));

            return listDonHang;*/

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM HoaDon";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    List<HoaDon> listDonHang = new List<HoaDon>();
                    /*while (reader.Read())
                    {
                        HoaDon hoaDon = new HoaDon();
                        hoaDon.MaHD = reader["MaHD"].ToString();
                        hoaDon.MaNV = reader["MaNV"].ToString();
                        hoaDon.SDT = reader["SDT"].ToString();
                        hoaDon.HinhThucThanhToan = reader["HinhThucThanhToan"].ToString();
                        hoaDon.TongTien = Convert.ToInt32(reader["TongTien"]);
                        hoaDon.NgayLap = reader["NgayLap"].ToString();
                        hoaDon.TienKhachDua = Convert.ToInt32(reader["TienKhachDua"]);
                        hoaDon.TienThua = Convert.ToInt32(reader["TienThua"]);
                        hoaDon.TienConLai = Convert.ToInt32(reader["TienConLai"]);
                        hoaDon.GhiChu = reader["GhiChu"].ToString();
                        listDonHang.Add(hoaDon);
                    }*/
                    return listDonHang;
                }
            }catch(SqlException ex)
            {
                MessageBox.Show(ex + "Loi");
                return null;
            }
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

    }
}
