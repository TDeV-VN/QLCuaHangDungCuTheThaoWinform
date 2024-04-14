using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class DanhSachDonHangBLL
    {
        private List<HoaDon> listDonHang = new List<HoaDon>();

        public List<HoaDon> ListDonHang { get => listDonHang; set => listDonHang = value; }


        //Khởi tạo danh sách đơn hàng với tất cả các đơn hàng trong cơ sở dữ liệu
        public DanhSachDonHangBLL()
        {
            this.ListDonHang = DatabaseAccess.GetAllHoaDon();
        }

        public static int LaySoLuongDonHangHomNay()
        {
            return DatabaseAccess.laySoLuongDonHangHomNay();
        }

        public static long LayTongTienHomNay()
        {
            return DatabaseAccess.layDoanhThuHomNay() ;
        }

        //Tạo data cho combobox nhân viên         
        public static List<string> GetDSTenNhanVien() 
        {
            List<string> listTenNhanVien = new List<string>();
            listTenNhanVien.AddRange(DatabaseAccess.GetDSTenNhanVien());
            listTenNhanVien.Sort();
            listTenNhanVien.Insert(0, "Tất cả");
            return listTenNhanVien;
        }

        //Tạo data cho combobox ngày tạo
        public static List<string> GetDSNgayTao()
        {
            List<string> listNgayTao = new List<string>();
            listNgayTao.Add("Tất cả");
            listNgayTao.Add("Hôm nay");
            listNgayTao.Add("Hôm qua");
            listNgayTao.Add("Tuần này");
            listNgayTao.Add("Tháng này");
            return listNgayTao;
        }

        //Tạo data cho combobox trạng thái
        public static List<string> GetDSTrangThai()
        {
            List<string> listTrangThai = new List<string>();
            listTrangThai.Add("Tất cả");
            listTrangThai.Add("Hoàn thành");
            listTrangThai.Add("Đã hủy");
            return listTrangThai;
        }


    }
}
