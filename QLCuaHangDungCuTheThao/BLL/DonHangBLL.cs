using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Printing;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web.WebSockets;
using System.Windows.Forms;
using DAL;
using DTO;
using System.Text.RegularExpressions;

namespace BLL
{
    public class DonHangBLL
    {
        private List<ChiTietHoaDon> listChiTietHD;
        private HoaDon hoaDon;
        private int diemTichLuy;


        public List<ChiTietHoaDon> ListChiTietHD { get => listChiTietHD; set => listChiTietHD = value; }
        public HoaDon HoaDon { get => hoaDon; set => hoaDon = value; }

        public DonHangBLL()
        {
            this.ListChiTietHD = new List<ChiTietHoaDon>();
            this.HoaDon = new HoaDon(AutoGenerateMaHD());
        }

        //sinh tự động mã đơn hàng
        private string AutoGenerateMaHD()
        {
            return DatabaseAccess.AutoGenerateMaHD();
        }

        //Thêm ChiTietHoaDon vào danh sách
        public bool ThemChiTietHoaDon(string masp)
        {
            //Kiểm tra sản phẩm đã có trong danh sách chưa, nếu đã có thì cộng số lượng thêm 1, cập nhật tiền và return false
            if (GetChiTietHoaDon(masp) != null)
            {
                UpdateSoLuongChiTietHoaDon(masp, GetChiTietHoaDon(masp).SoLuong + 1);
                return false;
            }
            SanPham sp = DatabaseAccess.GetSanPham(masp);            
            ChiTietHoaDon cthd = new ChiTietHoaDon(HoaDon.MaHD, sp.MaSP, 1, sp.GiaBan);
            ListChiTietHD.Add(cthd);
            UpdateSoLuongChiTietHoaDon(masp, 1); //để cập nhật tiền
            return true;
        }

        // Gợi ý sản phẩm khi tìm kiếm sản phẩm
        public static DataTable LoadResults_For_SearchSPTextbox(string text)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MaSP");
            dt.Columns.Add("TenSP");
            return DatabaseAccess.findSanPhamByUncompletedString(text);
        }

        //Lấy chi tiết hóa đơn trong listChiTietHD
        public ChiTietHoaDon GetChiTietHoaDon(string maSP)
        {
            return ListChiTietHD.Find(x => x.MaSP == maSP);
        }

        //Update số lượng
        public void UpdateSoLuongChiTietHoaDon(string maSP, string soLuongMoi)
        {
            for (int i = 0; i < listChiTietHD.Count(); i++)
            {
                if (listChiTietHD[i].MaSP == maSP)
                {
                    listChiTietHD[i].SoLuong = int.Parse(soLuongMoi);
                    hoaDon.TongTienHang = listChiTietHD.Sum(cthd => cthd.DonGia * cthd.SoLuong);
                    hoaDon.TienKhachPhaiTra = hoaDon.TongTienHang - hoaDon.ChietKhau;
                }
            }
        }
        public void UpdateSoLuongChiTietHoaDon(string maSP, int soLuongMoi)
        {
            for (int i = 0; i < listChiTietHD.Count(); i++)
            {
                if (listChiTietHD[i].MaSP == maSP)
                {
                    listChiTietHD[i].SoLuong = soLuongMoi;
                    hoaDon.TongTienHang = listChiTietHD.Sum(cthd => cthd.DonGia * cthd.SoLuong);
                    hoaDon.TienKhachPhaiTra = hoaDon.TongTienHang - hoaDon.ChietKhau;
                }
            }
        }

        public void nhapSDT(string sdt)
        {
            hoaDon.SDT = sdt;
            diemTichLuy =  DatabaseAccess.layDiem(sdt);
            if (diemTichLuy == -1)
            {
                diemTichLuy = 0;
                hoaDon.ChietKhau = 0;
                DatabaseAccess.themKhachHang(sdt);
            } else
            {
                tinhChietKhau();
            }

        }

        public void tinhChietKhau()
        {
            if (diemTichLuy >= 10)
            {
                hoaDon.ChietKhau = hoaDon.TongTienHang * (diemTichLuy/10)/100 ;
                if (hoaDon.ChietKhau > hoaDon.TongTienHang * 10 / 100)
                {
                    hoaDon.ChietKhau = hoaDon.TongTienHang * 10 / 100;
                }
            }
            else
            {
                hoaDon.ChietKhau = 0;
            }
            hoaDon.TienKhachPhaiTra = hoaDon.TongTienHang - hoaDon.ChietKhau;
        }

        public bool tinhTienThua(string tienKhachDua)
        {
            //Kiểm tra định dạng (ràng buộc chuỗi chỉ được bắt đầu bằng chữ số,
            //thể chứa dấu phẩy và khoảng trắng, kết thúc bằng chữ số hoặc khoảng trắng
            //hoặc "VNĐ" hoặc "VND", ngoài ra không chứa chữ nào khác)
            var regex = new Regex(@"^\d[\d,\s]*((VNĐ|VND)|\d|\s)?$");
            bool checkFormat = regex.IsMatch(tienKhachDua);
            if (!checkFormat) return false;

            //Chuyển đổi sang int
            regex = new Regex(@"[^\d]");
            string cleanedInput = regex.Replace(tienKhachDua, ""); // Loại bỏ tất cả các ký tự không phải là chữ số
            if (int.TryParse(cleanedInput, out int result))
            {
                hoaDon.TienKhachDua = result;
                hoaDon.TraLai = hoaDon.TienKhachDua - hoaDon.TienKhachPhaiTra;
                return true;
                //test
                MessageBox.Show(hoaDon.TraLai.ToString());
            }
            else
            {
                return false;
            }     
        }

        public bool TaoDonHang(string maNV, string ghiChu, string pttt)
        {
            hoaDon.MaNV = maNV;
            hoaDon.GhiChu = ghiChu;
            hoaDon.PhuongThucThanhToan = pttt;
            hoaDon.ThoiGianLap = DateTime.Now.ToString();
            //Thêm hóa đơn vào database
            if (DatabaseAccess.ThemDonHang(hoaDon, listChiTietHD))
            {
                diemTichLuy += hoaDon.TongTienHang / 100000;
                //Cập nhật điểm tích lũy
                DatabaseAccess.capNhatDiem(hoaDon.SDT, diemTichLuy);
                return true;
            }
            return false;
        }

        public void veHoaDon(System.Drawing.Printing.PrintPageEventArgs e, float pageWidth, float pageHeight)
        {

            
            const int LINE_SPACE = 10;
            const int MARGIN_TOP = 10;
            const int MARGIN_LEFT = 10;
            const int MARGIN_RIGHT = 10;
            const int DONGIA_SL_SPACE = 200;
            Font font = new Font("Arial", 10);
            Font fontBold = new Font("Arial", 10, FontStyle.Bold);
            Font fontItalic = new Font("Arial", 10, FontStyle.Italic);
            SolidBrush brush = new SolidBrush(Color.Black);
            float x;
            float y;
            string now = DateTime.Now.ToString(); //Thời gian hiện tại
            const string storeName = "Sport Shop";
            string goodbye = "Cảm ơn quý khách. Hẹn gặp lại!";
            //Các biến cần thiết
            string storeAddress = "19 Nguyễn Hữu Thọ, Quận 7, TP.HCM";
            string title = "Hóa đơn bán hàng";
            string storePhone = "0123456789";
            string storeEmail = "sportshoptdtu@gmail.com";
            string billCode = hoaDon.MaHD;
            string billDate = hoaDon.ThoiGianLap;
            string staffCode = TaiKhoanBLL.TaiKhoan.MaNV;
            string customerPhone = hoaDon.SDT;          
            int tongTien = hoaDon.TongTienHang;
            int chietKhau = hoaDon.ChietKhau;
            int tienKhachPhaiTra = hoaDon.TienKhachPhaiTra;
            int tienKhachDua = hoaDon.TienKhachDua;
            int tienThua = hoaDon.TraLai;
            string paymentMethod = hoaDon.PhuongThucThanhToan; //"Tiền mặt"/ "Chuyển khoản"
            string note = hoaDon.GhiChu;

            string tenSP = "Sản phẩm test";
            string maSP = "SP000";
            int soLuong = 1;
            int donGia = 100000000;
            int thanhTien = 100000000;

            Image paymentQR = null;
            try
            {
                paymentQR = Payment.createPaymentQR(tienKhachPhaiTra, billCode);

            }
            catch 
            { 
                MessageBox.Show("Lỗi tạo mã QR");
            }

            // Vẽ thời gian in
            SizeF nowSize = e.Graphics.MeasureString(now, font); // Tính toán kích thước của chuỗi
            x = pageWidth - nowSize.Width - MARGIN_RIGHT;
            y = MARGIN_TOP;
            e.Graphics.DrawString(now, font, brush, x, y);

            //Vẽ tên cửa hàng
            SizeF storeNameSize = e.Graphics.MeasureString(storeName, fontBold);
            x = ((pageWidth - storeNameSize.Width) / 2);
            y = y + MARGIN_TOP + LINE_SPACE;
            e.Graphics.DrawString(storeName, fontBold, brush, x, y);

            //Vẽ địa chỉ cửa hàng
            SizeF storeAddressSize = e.Graphics.MeasureString(storeAddress, font);
            x = (pageWidth - storeAddressSize.Width) / 2;
            y = y + MARGIN_TOP + LINE_SPACE;
            e.Graphics.DrawString(storeAddress, font, brush, x, y);

            //Vẽ email cửa hàng
            storeEmail = "Email: " + storeEmail;
            SizeF storeEmailSize = e.Graphics.MeasureString(storeEmail, font);
            x = (pageWidth - storeEmailSize.Width) / 2;
            y = y + MARGIN_TOP + LINE_SPACE;
            e.Graphics.DrawString(storeEmail, font, brush, x, y);

            //Vẽ số điện thoại cửa hàng
            storePhone = "SĐT: " + storePhone;
            SizeF storePhoneSize = e.Graphics.MeasureString(storePhone, font);
            x = (pageWidth - storePhoneSize.Width) / 2;
            y = y + MARGIN_TOP + LINE_SPACE;
            e.Graphics.DrawString(storePhone, font, brush, x, y);

            //Vẽ đường thẳng nét đứt
            Pen dashedPen = new Pen(Color.Black, 1);
            dashedPen.DashPattern = new float[] { 4.0F, 4.0F }; //{Độ dài nét đứt, khoảng cách}
            float x1 = MARGIN_LEFT;
            y = y + storePhoneSize.Height + LINE_SPACE;
            float x2 = pageWidth - MARGIN_RIGHT;
            e.Graphics.DrawLine(dashedPen, x1, y, x2, y);

            //Vẽ tiêu đề hóa đơn
            SizeF titleSize = e.Graphics.MeasureString(title, fontBold);
            x = (pageWidth - titleSize.Width) / 2;
            y = y + LINE_SPACE;
            e.Graphics.DrawString(title, fontBold, brush, x, y);

            //Vẽ mã hóa đơn
            billCode = "Mã hóa đơn: " + billCode;
            SizeF billCodeSize = e.Graphics.MeasureString(billCode, font);
            x = MARGIN_LEFT;
            y = y + titleSize.Height + LINE_SPACE;
            e.Graphics.DrawString(billCode, font, brush, x, y);

            //Vẽ ngày tạo hóa đơn
            billDate = "Ngày tạo: " + billDate;
            SizeF billDateSize = e.Graphics.MeasureString(billDate, font);
            x = pageWidth - billDateSize.Width - MARGIN_RIGHT;
            e.Graphics.DrawString(billDate, font, brush, x, y);

            //Vẽ đường thẳng nét liền đậm
            Pen solidPen = new Pen(Color.Black, 2);
            y = y + billCodeSize.Height + LINE_SPACE;
            e.Graphics.DrawLine(solidPen, x1, y, x2, y);

            //Vẽ mã nhân viên
            staffCode = "Nhân viên: " + staffCode;
            SizeF staffCodeSize = e.Graphics.MeasureString(staffCode, font);
            x = MARGIN_LEFT;
            y = y + LINE_SPACE;
            e.Graphics.DrawString(staffCode, font, brush, x, y);

            //Vẽ số điện thoại khách hàng
            customerPhone = "SĐT KH: " + customerPhone;
            SizeF customerPhoneSize = e.Graphics.MeasureString(customerPhone, font);
            x = pageWidth - customerPhoneSize.Width - MARGIN_RIGHT;
            e.Graphics.DrawString(customerPhone, font, brush, x, y);

            //Vẽ đường thẳng nét đứt
            y = y + customerPhoneSize.Height + LINE_SPACE;
            e.Graphics.DrawLine(dashedPen, x1, y, x2, y);

            //Vẽ tiêu đề bảng hóa đơn
            x = MARGIN_LEFT;
            y = y + LINE_SPACE;
            e.Graphics.DrawString("SL", fontBold, brush, x, y);

            string colName1 = "Đơn giá";
            SizeF colName1Size = e.Graphics.MeasureString(colName1, fontBold);
            x = DONGIA_SL_SPACE + (pageWidth - colName1Size.Width) / 2;
            e.Graphics.DrawString(colName1, fontBold, brush, x, y);

            string colName2 = "Thành tiền";
            SizeF colName2Size = e.Graphics.MeasureString(colName2, fontBold);
            x = pageWidth - colName2Size.Width - MARGIN_RIGHT;
            e.Graphics.DrawString(colName2, fontBold, brush, x, y);

            //Vẽ đường thẳng nét liền đậm
            y = y + colName2Size.Height + LINE_SPACE;
            e.Graphics.DrawLine(solidPen, x1, y, x2, y);

            //Vẽ sản phẩm
            foreach (ChiTietHoaDon cthd in listChiTietHD)
            {
                //Thiết lập thông tin chi tiết hóa đơn
                tenSP = DatabaseAccess.GetSanPham(cthd.MaSP).TenSP;
                maSP = cthd.MaSP;
                soLuong = cthd.SoLuong;
                donGia = cthd.DonGia;
                thanhTien = cthd.ThanhTien;

                //Vẽ thông tin chi tiết hóa đơn
                string tenSP_maSP = tenSP + " - " + maSP;
                x = MARGIN_LEFT;
                y = y + LINE_SPACE;
                e.Graphics.DrawString(tenSP_maSP, font, brush, x, y);

                SizeF tenSP_maSPSize = e.Graphics.MeasureString(tenSP_maSP, font);
                y = y + tenSP_maSPSize.Height + LINE_SPACE;
                e.Graphics.DrawString(soLuong.ToString(), font, brush, x, y);

                SizeF donGiaSize = e.Graphics.MeasureString(donGia.ToString("N0"), font);
                x = DONGIA_SL_SPACE + (pageWidth - donGiaSize.Width) / 2;
                e.Graphics.DrawString(donGia.ToString("N0"), font, brush, x, y);

                SizeF thanTienSize = e.Graphics.MeasureString(thanhTien.ToString("N0"), font);
                x = pageWidth - thanTienSize.Width - MARGIN_RIGHT;
                e.Graphics.DrawString(thanhTien.ToString("N0"), font, brush, x, y);

                //Vẽ đường thẳng nét đứt
                y = y + thanTienSize.Height + LINE_SPACE;
                e.Graphics.DrawLine(dashedPen, x1, y, x2, y);
            }

            //Vẽ tổng tiền
            x = MARGIN_LEFT;
            y = y + LINE_SPACE;
            e.Graphics.DrawString("Tổng tiền:", font, brush, x, y);

            SizeF tongTienSize = e.Graphics.MeasureString(tongTien.ToString("N0"), fontBold);
            x = pageWidth - tongTienSize.Width - MARGIN_RIGHT;
            e.Graphics.DrawString(tongTien.ToString("N0"), font, brush, x, y);

            //Vẽ chiết khấu
            x = MARGIN_LEFT;
            y = y + tongTienSize.Height + LINE_SPACE;
            e.Graphics.DrawString("Chiết khấu:", font, brush, x, y);

            SizeF chietKhauSize = e.Graphics.MeasureString(chietKhau.ToString("N0"), fontBold);
            x = pageWidth - chietKhauSize.Width - MARGIN_RIGHT;
            e.Graphics.DrawString(chietKhau.ToString("N0"), font, brush, x, y);

            //Vẽ tiền khách phải trả
            x = MARGIN_LEFT;
            y = y + chietKhauSize.Height + LINE_SPACE;
            e.Graphics.DrawString("Khách phải trả:", fontBold, brush, x, y);

            SizeF tienKhachPhaiTraSize = e.Graphics.MeasureString(tienKhachPhaiTra.ToString("N0"), fontBold);
            x = pageWidth - tienKhachPhaiTraSize.Width - MARGIN_RIGHT;
            e.Graphics.DrawString(tienKhachPhaiTra.ToString("N0"), fontBold, brush, x, y);

            //Vẽ phương thức thanh toán
            x = MARGIN_LEFT;
            y = y + tienKhachPhaiTraSize.Height + LINE_SPACE;
            e.Graphics.DrawString("Phương thức thanh toán:", font, brush, x, y);

            SizeF paymentMethodSize = e.Graphics.MeasureString(paymentMethod, font);
            x = pageWidth - paymentMethodSize.Width - MARGIN_RIGHT;
            e.Graphics.DrawString(paymentMethod, font, brush, x, y);

            if (paymentMethod == "Tiền mặt")
            {
                //Vẽ tiền khách đưa
                x = MARGIN_LEFT;
                y = y + tienKhachPhaiTraSize.Height + LINE_SPACE;
                e.Graphics.DrawString("Khách đưa:", font, brush, x, y);

                SizeF tienKhachDuaSize = e.Graphics.MeasureString(tienKhachDua.ToString("N0"), fontBold);
                x = pageWidth - tienKhachDuaSize.Width - MARGIN_RIGHT;
                e.Graphics.DrawString(tienKhachDua.ToString("N0"), font, brush, x, y);

                //Vẽ tiền thừa
                x = MARGIN_LEFT;
                y = y + tienKhachDuaSize.Height + LINE_SPACE;
                e.Graphics.DrawString("Trả lại:", font, brush, x, y);

                SizeF tienThuaSize = e.Graphics.MeasureString(tienThua.ToString("N0"), fontBold);
                x = pageWidth - tienThuaSize.Width - MARGIN_RIGHT;
                e.Graphics.DrawString(tienThua.ToString("N0"), font, brush, x, y);
                y = y + tienThuaSize.Height + LINE_SPACE;

                //Vẽ ghi chú
                SizeF noteTitleSize = e.Graphics.MeasureString("Ghi chú: ", font);
                x = MARGIN_LEFT;
                e.Graphics.DrawString("Ghi chú: ", font, brush, x, y);

                SizeF noteSize = e.Graphics.MeasureString(note, fontItalic);
                x = MARGIN_LEFT;
                y = y + noteTitleSize.Height + LINE_SPACE;
                e.Graphics.DrawString(note, fontItalic, brush, x, y);
                y = y + noteSize.Height + LINE_SPACE;
            }
            else
            {
                //Vẽ ghi chú
                SizeF noteTitleSize = e.Graphics.MeasureString("Ghi chú: ", font);
                x = MARGIN_LEFT;
                y = y + paymentMethodSize.Height + LINE_SPACE;
                e.Graphics.DrawString("Ghi chú: ", font, brush, x, y);

                SizeF noteSize = e.Graphics.MeasureString(note, fontItalic);
                x = MARGIN_LEFT;
                y = y + noteTitleSize.Height + LINE_SPACE;
                e.Graphics.DrawString(note, fontItalic, brush, x, y);

                //Vẽ mã QR
                if (paymentQR != null)
                {
                    x = (pageWidth - 100) / 2;
                    y = y + noteSize.Height + LINE_SPACE;
                    Rectangle destRect = new Rectangle((int)x, (int)y, 100, 100); //giới hạn kích thước của ảnh
                    e.Graphics.DrawImage(paymentQR, destRect);
                    y = y + 100 + LINE_SPACE;
                }
                
            }

            //Vẽ cảm ơn
            SizeF goodbyeSize = e.Graphics.MeasureString(goodbye, fontItalic);
            x = (pageWidth - goodbyeSize.Width) / 2;
            e.Graphics.DrawString(goodbye, fontItalic, brush, x, y);
        }

        //Xóa chi tiết hóa đơn
        public void XoaChiTietHoaDon(string maSP)
        {
            ChiTietHoaDon cthd = GetChiTietHoaDon(maSP);
            UpdateSoLuongChiTietHoaDon(maSP, 0);
            listChiTietHD.Remove(cthd);
        }

        //Kiểm tra số điện thoại hợp lệ (bắt đầu bằng số 0, có ít nhất 10 chữ số (không tính khoảng trắng) và chỉ chứa khoảng trắng hoặc chữ số)
        public static bool isValidPhoneNumber(string phoneNumber)
        {
            if (!phoneNumber.StartsWith("0")) return false;

            int digitCount = 0;
            foreach (char c in phoneNumber)
            {
                if (char.IsDigit(c)) digitCount++;
                else if (!char.IsWhiteSpace(c)) return false;
            }

            return digitCount >= 10;
        }

    }
}
