﻿using System;
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

        //Tạo data cho combobox nhân viên         
        public static List<string> GetDSTenNhanVien() 
        {
            return new List<string> { "Nguyễn Văn A", "Nguyễn Văn B", "Nguyễn Văn C" };
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
