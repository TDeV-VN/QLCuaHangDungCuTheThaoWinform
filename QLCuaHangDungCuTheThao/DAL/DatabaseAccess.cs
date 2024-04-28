using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using DTO;
using System.Data;
using System.Windows.Forms;

namespace DAL
{
    public class DatabaseAccess
    {

        private static SqlConnection conn;
        // Tạo kết nối đến cơ sở dữ liệu
        public static void connect()
        {
            //private static string connectionString = @"Data Source=Tien-laptop;Initial Catalog=QuanLyCuaHangDungCuTheThao;Integrated Security=True;Trust Server Certificate=True";
            string connectionString = @"Data Source=tien-laptop;Initial Catalog=QuanLyCuaHangDungCuTheThao;Integrated Security=True;Trust Server Certificate=True";
            conn = new SqlConnection(connectionString);
            conn.Open();
        }
        public static void addDanhMucSanPham(DanhMucSanPham dmsp)
        {
            connect();
            SqlCommand cmd = new SqlCommand("addDanhMucSanPham", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ten", dmsp.TenDM);
            cmd.Parameters.AddWithValue("@moTa", dmsp.MoTa);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void addSanPham(DanhMucSanPham dmsp)
        {
            connect();
            SqlCommand cmd = new SqlCommand("addSanPham", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ten", dmsp.TenDM);
            cmd.Parameters.AddWithValue("@moTa", dmsp.MoTa);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static DataTable selectQuery(string sql)
        {
            connect();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }

        // Lấy tất cả các đơn hàng từ cơ sở dữ liệu
        public static List<HoaDon> GetAllHoaDon()
        {
            connect();
            List<HoaDon> listHoaDon = new List<HoaDon>();
            SqlCommand cmd = new SqlCommand("Select * From HoaDon", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                listHoaDon.Add(new HoaDon(Convert.ToString(reader[0]), Convert.ToString(reader[1]), Convert.ToString(reader[2]), Convert.ToString(reader[3]), Convert.ToInt32(reader[4]), Convert.ToString(reader[5]), Convert.ToInt32(reader[6]), Convert.ToInt32(reader[7]), Convert.ToInt32(reader[8]), Convert.ToInt32(reader[9]), Convert.ToString(reader[10])));
            }
            conn.Close();
            return listHoaDon;

        }



        // Lấy thông tin một sản phẩm từ cơ sở dữ liệu
        public static SanPham GetSanPham(string maSP)
        {
            //test
            //SanPham sp = new SanPham("SP00001", "DM001", "Áo thun nam", 100, 10000000, 15000000, true, "Áo thun nam màu đen");
            connect();
            SqlCommand cmd = new SqlCommand("Select * From SanPham Where MaSP = '" + maSP + "'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            SanPham sp = null;
            if(reader.Read())
            {
                sp = new SanPham(Convert.ToString(reader["MaSP"]), Convert.ToString(reader["MaDM"]), Convert.ToString(reader["TenSP"]), Convert.ToInt32(reader["TonKho"]), Convert.ToInt32(reader["GiaNhap"]), Convert.ToInt32(reader["GiaBan"]), Convert.ToBoolean(reader["MoBan"]), Convert.ToString(reader["MoTa"]));
            }
            conn.Close();
            return sp;
        }

        public static DataTable findSanPhamByUncompletedString(string str)
        {
            connect();
            DataTable listSanPhamResult = new DataTable();  
            listSanPhamResult.Columns.Add("MaSP");
            listSanPhamResult.Columns.Add("TenSP");
            SqlCommand cmd = new SqlCommand("findSanPhamByUncompletedString", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@str", str);
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                listSanPhamResult.Rows.Add(Convert.ToString(reader["MaSP"]), Convert.ToString(reader["TenSP"]));
            }
            conn.Close();
            return listSanPhamResult;
        }

        // Lấy thông tin tất cả các sản phẩm từ cơ sở dữ liệu
        public static List<SanPham> GetAllSanPham()
        {
            connect();
            List<SanPham> listSanPham = new List<SanPham>();    
            SqlCommand cmd = new SqlCommand("Select * From SanPham", conn); 
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                listSanPham.Add(new SanPham(Convert.ToString(reader[0]), Convert.ToString(reader[1]), Convert.ToString(reader[2]), Convert.ToInt32(reader[3]), Convert.ToInt32(reader[4]), Convert.ToInt32(reader[5]), Convert.ToBoolean(reader[6]), Convert.ToString(reader[7])));
            }
            conn.Close();
            return listSanPham;
        }
        //Lấy url của hình đại diện sản phẩm 
        public static string GetAvatarURLSanPham(string maSP)
        {
            connect();
            string query = "Select ImageURL from HinhAnhSanPham where MaSP = '" + maSP + "' and Avatar = 1";
            SqlCommand cmd = new SqlCommand(query, conn);
            string url = Convert.ToString(cmd.ExecuteScalar());
            conn.Close();
            return url;
        }


        public static string AutoGenerateMaHD()
        {
            connect();
            SqlCommand cmd = new SqlCommand("Select dbo.generateHoaDonCode()", conn);
            string key = Convert.ToString(cmd.ExecuteScalar()); 
            conn.Close();
            return key;
        }
        // Cập nhật lại số lượng tồn kho
        public static void updateTonKho(int soLuong, string maSP)
        {
            connect();
            SqlCommand cmd = new SqlCommand("Update SanPham Set TonKho = TonKho + @soLuong  Where MaSP = @maSP", conn);
            cmd.Parameters.AddWithValue("@maSP", maSP);
            cmd.Parameters.AddWithValue("@soLuong", soLuong);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static int laySoLuongDonHangHomNay()
        {
            connect();
            // Gọi đến thủ tục lấy hóa đơn hoàn thành hôm nay
            SqlCommand cmd = new SqlCommand("getHoaDonToday", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        public static int layDoanhThuHomNay()
        {
            connect();
            // Gọi đến thủ tục lấy doanh thu hôm nay
            SqlCommand cmd = new SqlCommand("getRevenueToday", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            // Khi hôm nay không có bất cứ đơn hàng nào thì sẽ trả về doanh thu là 0
            if(DBNull.Value.Equals(cmd.ExecuteScalar()))
            {
                return 0;
            }
            return Convert.ToInt32(cmd.ExecuteScalar());
        }


        // Thêm một đơn hàng và các chi tiết hóa đơn cảu nó vào cơ sở dữ liệu
        public static bool ThemDonHang(HoaDon hoaDon, List<ChiTietHoaDon> listChiTietHD)
        {
            try
            {
                connect();
                // Gọi đến thủ tục add_HoaDon trong SQL để thêm một hóa đơn mới vào CSDL
                SqlCommand cmdHD = new SqlCommand("addHoaDon", conn);
                cmdHD.CommandType = CommandType.StoredProcedure;
                // Truyền các tham số của thủ tục add_HoaDon
                cmdHD.Parameters.AddWithValue("@maNV", hoaDon.MaNV);
                cmdHD.Parameters.AddWithValue("@sdt", hoaDon.SDT);
                cmdHD.Parameters.AddWithValue("@phuongThuc", hoaDon.PhuongThucThanhToan);
                cmdHD.Parameters.AddWithValue("@chietKhau", hoaDon.ChietKhau);
                cmdHD.Parameters.AddWithValue("@ngayLap", hoaDon.ThoiGianLap);
                cmdHD.Parameters.AddWithValue("@tienKhachPhaiTra", hoaDon.TienKhachPhaiTra);
                cmdHD.Parameters.AddWithValue("@tienKhachDua", hoaDon.TienKhachDua);
                cmdHD.Parameters.AddWithValue("@tongTien", hoaDon.TongTienHang);
                cmdHD.Parameters.AddWithValue("@traLai", hoaDon.TraLai);
                cmdHD.Parameters.AddWithValue("@note", hoaDon.GhiChu);
                cmdHD.Parameters.AddWithValue("@trangThai", 1);
                cmdHD.ExecuteNonQuery();

                // Gọi đến thủ tục add_ChiTietHoaDon trong SQL để thêm các chi tiết hóa đơn của hóa đơn bên trên vào CSDL
                SqlCommand cmdCTHD = new SqlCommand("addChiTietHoaDon", conn);
                cmdCTHD.CommandType = CommandType.StoredProcedure;
                foreach (ChiTietHoaDon cthd in listChiTietHD)
                {
                    // Truyền các tham số của thủ tục add_ChiTietHoaDon
                    cmdCTHD.Parameters.AddWithValue("@maHD", cthd.MaHD);
                    cmdCTHD.Parameters.AddWithValue("@maSP", cthd.MaSP);
                    cmdCTHD.Parameters.AddWithValue("@soLuong", cthd.SoLuong);
                    cmdCTHD.Parameters.AddWithValue("@donGia", cthd.DonGia);
                    cmdCTHD.Parameters.AddWithValue("@thanhTien", cthd.ThanhTien);
                    cmdCTHD.ExecuteNonQuery();
                    // Gọi hàm cập nhật lại số lượng tồn kho
                    updateTonKho(cthd.SoLuong * -1, cthd.MaSP);
                }
                conn.Close();
                return true;
            } catch (Exception e)
            {
                MessageBox.Show("Loi: " + e);
                //return false;
                //test
                return true;
            }

            
        }

        public static List<string> GetAllDanhMuc()
        {
            connect();
            List<string> listDanhMuc = new List<string>();
            SqlCommand cmd = new SqlCommand("Select * From DanhMucSanPham", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                listDanhMuc.Add(Convert.ToString(reader[1]));
            }
            conn.Close();
            return listDanhMuc;
        }

        public static List<string> GetDSTenNhanVien()
        {
            connect();
            List<string> listTenNhanVien = new List<string>();
            SqlCommand cmd = new SqlCommand("Select TenNV From TaiKhoan", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                listTenNhanVien.Add(reader.GetString(0));
            }
            conn.Close();
            return listTenNhanVien;
        }

        //Lấy điêm tích lũy của khách hàng
        public static int layDiem(string sdt)
        {
            return 10;
        }

        //Thêm khách hàng mới vào cơ sở dữ liệu
        public static void themKhachHang(string sdt)
        {
            
        }

        //Cập nhật điểm tích lũy của khách hàng
        public static void capNhatDiem(string sdt, int diem)
        {
            
        }

        public static string layTenTaiKhoan()
        {
            return "Nguyễn Văn A";
        }

        public static int layNganHangId()
        {
            return 970422;
        }

        public static long laySoTaiKhoan()
        {
            return 123456789;
        }
    }
}
