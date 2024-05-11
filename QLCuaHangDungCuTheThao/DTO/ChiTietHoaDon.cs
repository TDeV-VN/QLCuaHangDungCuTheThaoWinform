﻿using System;
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
        private int donGia;
        private int thanhTien;

        public string MaHD { get => maHD; set => maHD = value; }
        public string MaSP { get => maSP; set => maSP = value; }
        public int SoLuong { get => soLuong; set { soLuong = value; thanhTien = soLuong * donGia; } }
        public int DonGia { get => donGia; set => donGia = value; }
        public int ThanhTien { get => thanhTien;}

        public ChiTietHoaDon(string maHD, string maSP, int soLuong, int donGia)
        {
            this.MaHD = maHD;
            this.MaSP = maSP;
            this.SoLuong = soLuong;
            this.DonGia = donGia;
            this.thanhTien = soLuong * donGia;
        }
        public ChiTietHoaDon(string maHD, string maSP, int soLuong, int donGia, int thanhTien)
        {
            this.MaHD = maHD;
            this.MaSP = maSP;
            this.SoLuong = soLuong;
            this.DonGia = donGia;
            this.thanhTien = thanhTien;
        }

    }
}
