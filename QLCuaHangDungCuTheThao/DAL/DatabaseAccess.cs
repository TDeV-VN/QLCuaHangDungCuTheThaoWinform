using System;
using System.Collections.Generic;
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

        public static string getTenDanhMucByMaDM(string maDM)
        {
            connect();
            SqlCommand cmd = new SqlCommand("Select TenDM From DanhMucSanPham Where MaDM = @maDM", conn);
            cmd.Parameters.AddWithValue("@maDM", maDM);
            string tenDM = Convert.ToString(cmd.ExecuteScalar());
            conn.Close();
            return tenDM;
        }

        public static List<string> getAllNonAvatarURLSanPham(string maSP)
        {
            connect();
            List<string> listURL = new List<string>();
            SqlCommand cmd = new SqlCommand("Select ImageURL From HinhAnhSanPham Where Avatar = 0 and MaSP = @maSP", conn);
            cmd.Parameters.AddWithValue("@maSP", maSP);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                listURL.Add(dr["ImageURL"].ToString());
            }
            return listURL;
        }

        public static void deleteImage(string maSP, string URL)
        {
            connect();
            SqlCommand cmd = new SqlCommand("Delete HinhAnhSanPham Where MaSP = @maSP and ImageURL = @imageURL", conn);
            cmd.Parameters.AddWithValue("@maSP", maSP);
            cmd.Parameters.AddWithValue("@imageURL", URL);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void deleteAvatar(string maSP)
        {
            connect();
            SqlCommand cmd = new SqlCommand("Delete HinhAnhSanPham Where Avatar = 1 and MaSP = @maSP", conn);
            cmd.Parameters.AddWithValue("@maSP", maSP);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static string checkAvatar(string maSP)
        {
            connect();
            SqlCommand cmd = new SqlCommand("Select ImageURL From HinhAnhSanPham Where Avatar = 1 and MaSP = @maSP", conn);
            cmd.Parameters.AddWithValue("@maSP", maSP);
            if (cmd.ExecuteScalar() == null) 
            {
                return "";       
            }
            return cmd.ExecuteScalar().ToString();
        }

        public static bool addAvatar(string maSP, string URL)
        {
            try
            {
                connect();
                SqlCommand cmd = new SqlCommand("Insert into HinhAnhSanPham values(@maSP, @imageURL, 1)", conn);
                cmd.Parameters.AddWithValue("@maSP", maSP);
                cmd.Parameters.AddWithValue("@imageURL", URL);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                conn.Close();
                return false;
            }
        }

        public static void updateAvatar(string maSP, string URL)
        {
            connect();
            SqlCommand cmd = new SqlCommand("Update HinhAnhSanPham Set Avatar = 1 Where MaSP = @maSP and ImageURL = @imageURL", conn);
            cmd.Parameters.AddWithValue("@maSP", maSP);
            cmd.Parameters.AddWithValue("@imageURL", URL);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static bool addImage(string maSP, string[] URL)
        {
            connect();
            try
            {
                foreach(string url in URL)
                {
                    SqlCommand cmd = new SqlCommand("Insert into HinhAnhSanPham values(@maSP, @imageURL, 0)", conn);
                    cmd.Parameters.AddWithValue("@maSP", maSP);
                    cmd.Parameters.AddWithValue("@imageURL", url);
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                conn.Close();
                return false;
            }
            conn.Close();
            return true;
        }

        public static void updateProduct(SanPham product)
        {
            try
            {
                connect();
                SqlCommand cmd = new SqlCommand("Update SanPham Set TenSP = @tenSP, MaDM = @maDM, GiaNhap = @giaNhap, GiaBan = @giaBan, TonKho = @tonKho, MoTa = @moTa, MoBan = @moBan Where MaSP = @maSP;", conn);
                cmd.Parameters.AddWithValue("@maSP", product.MaSP);
                cmd.Parameters.AddWithValue("@tenSP", product.TenSP);
                cmd.Parameters.AddWithValue("@maDM", product.MaDM);
                cmd.Parameters.AddWithValue("@giaNhap", Convert.ToDecimal(product.GiaNhap));
                cmd.Parameters.AddWithValue("@giaBan", Convert.ToDecimal(product.GiaBan));
                cmd.Parameters.AddWithValue("@tonKho", product.TonKho);
                cmd.Parameters.AddWithValue("@moBan", product.MoBan);
                cmd.Parameters.AddWithValue("@moTa", product.MoTa);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                conn.Close();
            }
            
        }


        // Lấy tất cả các đơn hàng từ cơ sở dữ liệu
        public static List<HoaDon> GetAllHoaDon()
        {
            //
            try
            {
                connect();
                List<HoaDon> listHoaDon = new List<HoaDon>();
                SqlCommand cmd = new SqlCommand("Select * From HoaDon", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    listHoaDon.Add(new HoaDon(Convert.ToString(reader[0]), Convert.ToString(reader[1]), Convert.ToString(reader[2]), Convert.ToString(reader[3]), Convert.ToInt32(reader[4]), Convert.ToDateTime(reader[5]), Convert.ToInt32(reader[6]), Convert.ToInt32(reader[7]), Convert.ToInt32(reader[8]), Convert.ToInt32(reader[9]), Convert.ToString(reader[10])));
                }
                conn.Close();
                return listHoaDon;
            }catch
            {
                conn.Close();
                return null;
            }
            

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
                    cmdCTHD.Parameters.AddWithValue("@maHD", hoaDon.MaHD);
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
                return false;
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

        public static void getListDanhMuc(DataTable lst)
        {
            connect();
            SqlCommand cmd = new SqlCommand("Select * From DanhMucSanPham", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(lst);
            conn.Close();
        }

        public static List<string> GetDSTenNhanVien() // lấy danh sách mã nhân viên
        {
            connect();
            List<string> listTenNhanVien = new List<string>();
            SqlCommand cmd = new SqlCommand("Select MaNV From TaiKhoan", conn);
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
            try{
                connect();
                SqlCommand cmd = new SqlCommand("Select DiemUuDai From KhachHang Where SDT = @sdt", conn);
                cmd.Parameters.AddWithValue("@sdt", sdt);
                if (cmd.ExecuteScalar() != null)
                {
                    int diem = Convert.ToInt32(cmd.ExecuteScalar());
                    conn.Close();
                    return diem;
                }
                else
                {
                    conn.Close();
                    return -1;
                }
            }
            catch
            {
                conn.Close();
                return -1;
            }
        }

        //Thêm khách hàng mới vào cơ sở dữ liệu
        public static void themKhachHang(string sdt)
        {
            try
            {
                connect();
                SqlCommand cmd = new SqlCommand("addKhachHang", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sdt", sdt);
                cmd.Parameters.AddWithValue("@tenKH", "");
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                conn.Close();
            }
        }

        //Cập nhật điểm tích lũy của khách hàng
        public static void capNhatDiem(string sdt, int diem)
        {
            try
            {
                connect();
                SqlCommand cmd = new SqlCommand("Update KhachHang Set DiemUuDai = @diem Where SDT = @sdt", conn);
                cmd.Parameters.AddWithValue("@diem", diem);
                cmd.Parameters.AddWithValue("@sdt", sdt);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                conn.Close();
            }
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
            return 8471739304;
        }

        public static bool kiemTraEmail(string email)
        {
            try
            {
                connect();
                SqlCommand cmd = new SqlCommand("Select MaNV From TaiKhoan Where Email = @email", conn);
                cmd.Parameters.AddWithValue("@email", email);
                if(cmd.ExecuteScalar() == null)
                {
                    conn.Close();
                    return false;
                }
                else
                {
                    conn.Close();
                    return true;
                }
            }
            catch
            {
                conn.Close();
                return false;
            }
        }

        public static string layMatKhau(string email)
        {
            try
            {
                connect();
                SqlCommand cmd = new SqlCommand("Select Pass From TaiKhoan Where Email = @email", conn);
                cmd.Parameters.AddWithValue("@email", email);
                if (cmd.ExecuteScalar() == null)
                {
                    conn.Close();
                    return "";
                }
                else
                {
                    string password = Convert.ToString(cmd.ExecuteScalar());
                    conn.Close();
                    return password;
                }
            }
            catch
            {
                conn.Close();
                return "";
            }
        }

        public static string layEmail(string maNV)
        {
            try
            {
                connect();
                SqlCommand cmd = new SqlCommand("Select Email From TaiKhoan Where MaNV = @maNV", conn);
                cmd.Parameters.AddWithValue("@maNV", maNV);
                if (cmd.ExecuteScalar() == null)
                {
                    conn.Close();
                    return "";
                }
                else
                {
                    string email = Convert.ToString(cmd.ExecuteScalar());
                    conn.Close();
                    return email;
                }
            }
            catch
            {
                conn.Close();
                return "";
            }
        }

        public static bool datLaiMatKhau(string email, string matKhau)
        {
            try
            {
                connect();
                SqlCommand cmd = new SqlCommand("Update TaiKhoan Set Pass = @pass Where Email = @email", conn);
                cmd.Parameters.AddWithValue("@pass", matKhau);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                conn.Close();
                return false;
            }
        }
        
        public static bool getRole(string email)
        {
            try
            {
                connect();
                SqlCommand cmd = new SqlCommand("Select TypeAcc From TaiKhoan Where Email = @email", conn);
                cmd.Parameters.AddWithValue("@email", email);
                bool role = Convert.ToBoolean(cmd.ExecuteScalar());
                conn.Close();
                return role;
            }
            catch
            {
                conn.Close();
                return false;
            }
        }

        public static string getMaNV(string email)
        {
            try
            {
                connect();
                SqlCommand cmd = new SqlCommand("Select MaNV From TaiKhoan Where Email = @email", conn);
                cmd.Parameters.AddWithValue("@email", email);
                string maNV = Convert.ToString(cmd.ExecuteScalar());
                conn.Close();
                return maNV;
            }
            catch
            {
                conn.Close();
                return "";
            }
        }

        public static bool kiemTraTrangThaiTaiKhoan(string email)
        {
            try
            {
                connect();
                SqlCommand cmd = new SqlCommand("Select TrangThai From TaiKhoan Where Email = @email", conn);
                cmd.Parameters.AddWithValue("@email", email);
                bool trangThai = Convert.ToBoolean(cmd.ExecuteScalar());
                conn.Close();
                return trangThai;
            }
            catch
            {
                conn.Close();
                return false;
            }
        }

        // Lấy danh sách tài khoản từ cơ sở dữ liệu
        public static List<TaiKhoan> layDanhSachTaiKhoan()
        {
            List<TaiKhoan> result = new List<TaiKhoan>();
            try
            {
                connect();
                SqlCommand cmd = new SqlCommand("Select * From TaiKhoan", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(new TaiKhoan(Convert.ToString(reader["MaNV"]), Convert.ToString(reader["Email"]), Convert.ToBoolean(reader["TypeAcc"]), Convert.ToBoolean(reader["TrangThai"])));
                }
            }
            catch { }
            finally
            {
                conn.Close();
            }
            return result;
        }

        public static bool capNhatTaiKhoan(TaiKhoan taiKhoan)
        {
            try
            {
                connect();
                SqlCommand cmd = new SqlCommand("Update TaiKhoan Set Email = @email, TypeAcc = @typeAcc, TrangThai = @trangThai Where MaNV = @maNV", conn);
                cmd.Parameters.AddWithValue("@email", taiKhoan.Email);
                cmd.Parameters.AddWithValue("@typeAcc", taiKhoan.Role);
                cmd.Parameters.AddWithValue("@trangThai", taiKhoan.TrangThai);
                cmd.Parameters.AddWithValue("@maNV", taiKhoan.MaNV);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public static bool themTaiKhoan(TaiKhoan taiKhoan)
        {
            try
            {
                connect();
                SqlCommand cmd = new SqlCommand("Insert into TaiKhoan values(@maNV, @tenNV, @email,@matKhau, @typeAcc, @trangThai)", conn);
                cmd.Parameters.AddWithValue("@maNV", taiKhoan.MaNV);
                cmd.Parameters.AddWithValue("@email", taiKhoan.Email);
                cmd.Parameters.AddWithValue("@typeAcc", taiKhoan.Role);
                cmd.Parameters.AddWithValue("@trangThai", taiKhoan.TrangThai);
                cmd.Parameters.AddWithValue("@tenNV", "");
                cmd.Parameters.AddWithValue("@matKhau", taiKhoan.Password);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                //test
                MessageBox.Show("Lôi: " + e);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
