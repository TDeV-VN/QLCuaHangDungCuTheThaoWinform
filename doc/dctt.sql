﻿CREATE DATABASE QuanLyCuaHangDungCuTheThao;
GO
USE QuanLyCuaHangDungCuTheThao;
GO
CREATE TABLE DanhMucSanPham(
  MaDM VARCHAR(5),
  TenDM NVARCHAR(50),
  MoTa NTEXT,
  CONSTRAINT PK_DanhMucSanPham PRIMARY KEY(MaDM)
);
GO

CREATE TABLE SanPham(
  MaSP VARCHAR(7),
  MaDM VARCHAR(5),
  TenSP NVARCHAR(50),
  TonKho SMALLINT,
  GiaNhap MONEY,
  GiaBan MONEY,
  MoBan BIT,
  MoTa NTEXT,
  CONSTRAINT PK_SanPham PRIMARY KEY(MaSP),
  CONSTRAINT FK_SanPham_DanhMucSanPham FOREIGN KEY(MaDM) REFERENCES DanhMucSanPham(MaDM)
);
GO

CREATE TABLE HinhAnhSanPham(
  MaSP VARCHAR(7),
  ImageURL VARCHAR(893),
  Avatar BIT, -- 1 là ảnh đại diện, 0 là ảnh thường
  CONSTRAINT PK_HinhAnhSanPham PRIMARY KEY(MaSP, ImageURL),
  CONSTRAINT FK_HinhAnhSanPham_SanPham FOREIGN KEY(MaSP) REFERENCES SanPham(MaSP)
);
GO

CREATE TABLE KhachHang(
  SDT VARCHAR(12),
  TenKH NVARCHAR(50),
  DiemUuDai SMALLINT,
  CONSTRAINT PK_KhachHang PRIMARY KEY(SDT)
);
GO

CREATE TABLE TaiKhoan(
  MaNV VARCHAR(5),
  TenNV NVARCHAR(50),
  Username VARCHAR(50),
  Pass VARCHAR(50),
  TypeAcc BIT,
  TrangThai BIT,
  CONSTRAINT PK_TaiKhoan PRIMARY KEY(MaNV)
);

CREATE TABLE HoaDon(
  MaHD VARCHAR(10),
  MaNV VARCHAR(5),
  SDT VARCHAR(12),
  PhuongThucThanhToan NVARCHAR(20),
  ChietKhau TINYINT,
  ThoiGianLap DATETIME,
  TienKhachPhaiTra MONEY, 
  TienKhachDua MONEY,
  TongTienHang MONEY,
  TraLai MONEY,
  GhiChu NTEXT,
  TrangThai BIT, -- 1 là "Hoàn Thành", 2 là "Đã Hủy"
  CONSTRAINT PK_HoaDon PRIMARY KEY(MaHD),
  CONSTRAINT FK_HoaDon_TaiKhoan FOREIGN KEY(MaNV) REFERENCES TaiKhoan(MaNV),
  CONSTRAINT FK_HoaDon_KhachHang FOREIGN KEY(SDT) REFERENCES KhachHang(SDT)
);
GO

CREATE TABLE ChiTietHoaDon(
  MaHD VARCHAR(10),
  MaSP VARCHAR(7),
  SoLuong SMALLINT,
  DonGia MONEY, 
  ThanhTien MONEY,
  CONSTRAINT PK_ChiTietHoaDon PRIMARY KEY(MaHD, MaSP),
  CONSTRAINT FK_ChiTietHoaDon_HoaDon FOREIGN KEY(MaHD) REFERENCES HoaDon(MaHD),
  CONSTRAINT FK_ChiTietHoaDon_SanPham FOREIGN KEY(MaSP) REFERENCES SanPham(MaSP)
);
GO
