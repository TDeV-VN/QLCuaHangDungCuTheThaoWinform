﻿using Newtonsoft.Json;
using RestSharp;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using DTO;
using DAL;
using System.Windows.Forms;
namespace BLL
{
    public class Payment
    {
        private static long soTaiKhoan = DatabaseAccess.laySoTaiKhoan();
        private static string tenTaiKhoan = DatabaseAccess.layTenTaiKhoan();
        private static int nganHangId = DatabaseAccess.layNganHangId();


        /* TẠO QR CODE THANH TOÁN VIETQR
        https://laptrinhvb.net/bai-viet/chuyen-de-csharp/---Csharp----Huong-dan-tao-ma-VietQR-Payment-API-Winform/ac2fb7d424117fd9.html
        https://vietqr.io/danh-sach-api/link-tao-ma-nhanh/
         */
        private static Image base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
            return image;
        }

        public static Image createPaymentQR(int soTienCanThanhToan, string noiDungChuyenKhoan)
        {
            try
            {
                var apiRequest = new ApiRequestQRCode();
                apiRequest.acqId = nganHangId;
                apiRequest.accountNo = soTaiKhoan;
                apiRequest.accountName = tenTaiKhoan;
                apiRequest.amount = soTienCanThanhToan;
                apiRequest.addInfo = noiDungChuyenKhoan;
                apiRequest.format = "text"; 
                apiRequest.template = "qr_only"; //compact, compact2, print, qr_only
                var jsonRequest = JsonConvert.SerializeObject(apiRequest);
            
                var client = new RestClient("https://api.vietqr.io/v2/generate");
                var request = new RestRequest();

                request.Method = Method.Post;
                request.AddHeader("Accept", "application/json");
                request.AddParameter("application/json", jsonRequest, ParameterType.RequestBody);

                var response = client.Execute(request);
                var content = response.Content; // Dữ liệu trả về từ API
                var dataResult = JsonConvert.DeserializeObject<ApiResponse>(content);

                var image = base64ToImage(dataResult.data.qrDataURL.Replace("data:image/png;base64,", ""));
                return image;
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi tạo mã QR: " + ex);
            }
            
            return null;
        }
        /* TẠO QR CODE THANH TOÁN VIETQR */

        // Lấy danh sách ngân hàng được VietQR hỗ trợ
        public Bank getbanks()
        {
            using (WebClient client = new WebClient())
            {
                var htmlData = client.DownloadData("https://api.vietqr.io/v2/banks");
                var bankRawJson = Encoding.UTF8.GetString(htmlData);
                var listBankData = JsonConvert.DeserializeObject<Bank>(bankRawJson);
                return listBankData;
            }
        }       
    }
}
