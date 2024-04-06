using Newtonsoft.Json;
using RestSharp;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using DTO;

using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using System.Collections.Generic;
using System.Web.UI;
using System.Net.NetworkInformation;
namespace BLL
{
    public class Payment
    {
        private static long soTaiKhoan;
        private static string tenTaiKhoan;
        private static int nganHangId;

        public Payment(int soTienCanThanhToan, string noiDungChuyenKhoan, long soTaiKhoan, string tenTaiKhoan, int nganHangId)
        {
            Payment.soTaiKhoan = soTaiKhoan;
            Payment.tenTaiKhoan = tenTaiKhoan;
            Payment.nganHangId = nganHangId;
        }
        /*

        // Phạm vi truy cập và dịch vụ Google Sheets API
        static readonly string[] Scopes = { SheetsService.Scope.SpreadsheetsReadonly };
        static readonly string ApplicationName = "Google Sheet Reader"; // Tên ứng dụng
        static readonly string SpreadsheetId = "15xjV2QyUFhOiX4nLgWPMClhsVVfBa68ThVriRZPTKI0";//"YOUR_SPREADSHEET_ID"; // ID của Google Spreadsheet
        static readonly string SheetName = "Trang tính1";// Tên của Sheet
        static string credentialsFile = "E:\\TH CNPM\\LearnWinform\\KetNoiGoogleSheet\\assets\\qlcuahangdungcuthethao-googlesheet-connect-key.json"; //lấy từ google developer console
        static SheetsService service; // Đối tượng dịch vụ Sheets

        */

        /* TẠO QR CODE THANH TOÁN VIETQR
        https://laptrinhvb.net/bai-viet/chuyen-de-csharp/---Csharp----Huong-dan-tao-ma-VietQR-Payment-API-Winform/ac2fb7d424117fd9.html
        https://vietqr.io/danh-sach-api/link-tao-ma-nhanh/
         */
        public Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
            return image;
        }

        public Image CreatePaymentQR(int soTienCanThanhToan, string noiDungChuyenKhoan)
        {
            var apiRequest = new ApiRequestQRCode();
            apiRequest.acqId = nganHangId;
            apiRequest.accountNo = soTaiKhoan;
            apiRequest.accountName = tenTaiKhoan;
            apiRequest.amount = soTienCanThanhToan;
            apiRequest.addInfo = noiDungChuyenKhoan;
            apiRequest.format = "text"; 
            apiRequest.template = "compact2"; //compact, compact2, print
            var jsonRequest = JsonConvert.SerializeObject(apiRequest);
            
            var client = new RestClient("https://api.vietqr.io/v2/generate");
            var request = new RestRequest();

            request.Method = Method.Post;
            request.AddHeader("Accept", "application/json");
            request.AddParameter("application/json", jsonRequest, ParameterType.RequestBody);

            var response = client.Execute(request);
            var content = response.Content; // Dữ liệu trả về từ API
            var dataResult = JsonConvert.DeserializeObject<ApiResponse>(content);

            var image = Base64ToImage(dataResult.data.qrDataURL.Replace("data:image/png;base64,", ""));
            return image;
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

        

        /*KẾT NỐI GOOGLE SHEET KIỂM TRA GIAO DỊCH*//*
        private void InitializeGoogleSheetsAPI()
        {
            GoogleCredential credential;
            using (var stream = new FileStream(credentialsFile, FileMode.Open, FileAccess.Read))
            {
                credential = GoogleCredential.FromStream(stream)
                    .CreateScoped(Scopes);
            }

            // Tạo dịch vụ Google Sheets API.
            service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
        }

        private IList<IList<Object>> ReadDataFromGoogleSheet()
        {
            // Định nghĩa yêu cầu để đọc dữ liệu từ Google Sheet
            SpreadsheetsResource.ValuesResource.GetRequest request =
                service.Spreadsheets.Values.Get(SpreadsheetId, SheetName);

            // Thực thi yêu cầu để đọc dữ liệu
            ValueRange response = request.Execute();

            // Xử lý dữ liệu
            IList<IList<Object>> values = response.Values;
            return values;
        }

        // Xác thực dữ liệu giao dịch
        public bool CheckTransaction()
        {
            // Khởi tạo dịch vụ Google Sheets API
            InitializeGoogleSheetsAPI();

            // Đọc dữ liệu từ Google Sheet
            var values = ReadDataFromGoogleSheet();

            // Kiểm tra
            string soTienDaThanhToan = values[1][2].ToString().Replace(".", "");
            string noiDungDaChuyenKhoan = values[1][1].ToString();
            if (values.Count > 0 && noiDungDaChuyenKhoan == noiDungChuyenKhoan && soTienDaThanhToan == soTienCanThanhToan.ToString())
            {
                return true;
            }

            return false;
        }   
        *//*KẾT NỐI GOOGLE SHEET KIỂM TRA GIAO DỊCH*/

        
    }
}
