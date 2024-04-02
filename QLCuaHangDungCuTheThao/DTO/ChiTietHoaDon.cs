using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHoaDon
    {
        private string maHD;
        private string maSP;
        private int soLuong;
        private long donGia;
        private long thanhTien;

        public string MaHD { get => maHD; set => maHD = value; }
        public string MaSP { get => maSP; set => maSP = value; }
        public int SoLuong { get => soLuong; set { soLuong = value; thanhTien = soLuong * donGia; } }
        public long DonGia { get => donGia; set => donGia = value; }
        public long ThanhTien { get => thanhTien;}

        public ChiTietHoaDon(string maHD, string maSP, int soLuong, long donGia)
        {
            this.MaHD = maHD;
            this.MaSP = maSP;
            this.SoLuong = soLuong;
            this.DonGia = donGia;
            this.thanhTien = soLuong * donGia;
        }

    }
}
