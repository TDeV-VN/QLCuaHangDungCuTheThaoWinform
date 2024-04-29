﻿using System;
using System.Net.Mail;
using System.Net;
using DAL;

namespace BLL
{
    public class TaiKhoanBLL
    {
        private static TaiKhoan taiKhoan = new TaiKhoan();
        public static TaiKhoan TaiKhoan { get => taiKhoan; set => taiKhoan = value; }

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
                MailAddress mail = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        //kiểm tra email có tồn tại trong hệ thống không
        public static bool kiemTraEmailTonTai(string email)
        {
            return DatabaseAccess.kiemTraEmail(email);
        }
    }
}
