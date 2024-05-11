using System;
using System.Net.Mail;
using System.Net;
using DAL;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace BLL
{
    public class TaiKhoanBLL
    {
        private static TaiKhoan taiKhoan = new TaiKhoan();
        private static List<TaiKhoan> danhSach = new List<TaiKhoan>();
        public static TaiKhoan TaiKhoan { get => taiKhoan; set => taiKhoan = value; }
        public static List<TaiKhoan> DanhSach { get => danhSach; set => danhSach = value; }

        private static String randomCode;
        public static String to;

        public static string guiOTP(string email)
        {
            try
            {
                String from, pass, messageBody;
                Random rand = new Random();
                randomCode = (rand.Next(999999)).ToString();
                MailMessage message = new MailMessage();
                to = (email).ToString();
                from = "sportshoptdtu@gmail.com";
                pass = "agtmgguxvnmdnhuy"; //Mật khẩu ứng dụng tạo trên gmail
                messageBody = "Mã xác thực để đặt lại mật khẩu tài khoản Sport Shop của bạn: " + randomCode + "\nMã này chỉ có hiệu lực trong 5 phút.";
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = messageBody;
                message.Subject = "ĐẶT LẠI MẬT KHẨU SPORT SHOP";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);
                smtp.Send(message);
                return randomCode;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private string maHoaMatKhau(string matKhau)
        {
            return "pass";
        }

        //kiểm tra định dạng email
        public static bool kiemTraDinhDangEmail(string email)
        {
            try
            {
                string pattern = @"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$";
                Regex regex = new Regex(pattern);
                return regex.IsMatch(email);
            }
            catch (FormatException)
            {
                return false;
            }
        }

        //kiểm tra email có tồn tại trong hệ thống không
        public static bool kiemTraEmailTonTai(string email)
        {
            taiKhoan.Email = email;
            return DatabaseAccess.kiemTraEmail(taiKhoan.Email);
        }

        //Băm mật khẩu
        public static string hashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }

        //Kiểm tra mật khẩu đăng nhập
        public static bool verifyPassword(string enteredPassword)
        {
            string storedHash = DatabaseAccess.layMatKhau(TaiKhoan.Email);
            string enteredHash = hashPassword(enteredPassword);
            return enteredHash == storedHash;
        }

        public static bool datLaiMatKhau(string matKhau)
        {
            if (DatabaseAccess.datLaiMatKhau(TaiKhoan.Email, hashPassword(matKhau)))
            {
                return true;
            }
            return false;
        }
        public static bool dangNhap()
        {
            taiKhoan.TrangThai = DatabaseAccess.kiemTraTrangThaiTaiKhoan(taiKhoan.Email);
            taiKhoan.Role = DatabaseAccess.getRole(taiKhoan.Email);
            taiKhoan.MaNV = DatabaseAccess.getMaNV(taiKhoan.Email);
            if (taiKhoan.TrangThai)
            {
                return true;
            } else
            {
                taiKhoan = new TaiKhoan();
            }
            return false;
        }

        public static void layDanhSach()
        {
            danhSach = DatabaseAccess.layDanhSachTaiKhoan();
        }
    }
}
