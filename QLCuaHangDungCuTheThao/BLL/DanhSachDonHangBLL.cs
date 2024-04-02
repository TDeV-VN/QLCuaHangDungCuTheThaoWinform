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
            return 3;
        }

        public static long LayTongTienHomNay()
        {
            return 1000000;
        }

    }
}
