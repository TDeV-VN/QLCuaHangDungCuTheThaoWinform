USE QuanLyCuaHangDungCuTheThao;
GO

CREATE FUNCTION generateDanhMucSanPhamCode()
RETURNS VARCHAR(5)
AS
BEGIN
  DECLARE @last_code VARCHAR(5)
  DECLARE @new_code VARCHAR(5)
  DECLARE @counter VARCHAR(3)

  -- Lấy mã sản phẩm cuối cùng
  SET @last_code = (SELECT MAX(MaDM) FROM DanhMucSanPham)
  -- Nếu chưa có mã sản phẩm nào
  IF (@last_code IS NULL)
  BEGIN
    SET @new_code = 'DM001'
  END
  ELSE
  BEGIN
    -- Tăng số thứ tự
    SET @counter = SUBSTRING(@last_code, 3, 5) + 1
    -- Định dạng số thứ tự
	SET @last_code = 'DM'
	DECLARE @remain_num int
	--Tính số lượng số 0 còn thiếu
	SET @remain_num = 3 - LEN(@counter)
	WHILE(@remain_num != 0)
	BEGIN
		SET @remain_num = @remain_num - 1
		SET @last_code = @last_code + '0' 
	END

    SET @new_code = CONCAT(@last_code, @counter)
  END
  
  RETURN @new_code
END
GO

CREATE FUNCTION generateSanPhamCode()
RETURNS VARCHAR(7)
AS
BEGIN
  DECLARE @last_code VARCHAR(7)
  DECLARE @new_code VARCHAR(7)
  DECLARE @counter VARCHAR(5)

  -- Lấy mã sản phẩm cuối cùng
  SET @last_code = (SELECT MAX(MaSP) FROM SanPham)
  -- Nếu chưa có mã sản phẩm nào
  IF (@last_code IS NULL)
  BEGIN
    SET @new_code = 'SP00001'
  END
  ELSE
  BEGIN
    -- Tăng số thứ tự
    SET @counter = SUBSTRING(@last_code, 3, 7) + 1
    -- Định dạng số thứ tự
	SET @last_code = 'SP'
	DECLARE @remain_num int
	--Tính số lượng số 0 còn thiếu
	SET @remain_num = 5 - LEN(@counter)
	WHILE(@remain_num != 0)
	BEGIN
		SET @remain_num = @remain_num - 1
		SET @last_code = @last_code + '0' 
	END

    SET @new_code = CONCAT(@last_code, @counter)
  END
  
  RETURN @new_code
END
GO

CREATE FUNCTION generateTaiKhoanCode()
RETURNS VARCHAR(5)
AS
BEGIN
  DECLARE @last_code VARCHAR(5)
  DECLARE @new_code VARCHAR(5)
  DECLARE @counter VARCHAR(3)

  -- Lấy mã sản phẩm cuối cùng
  SET @last_code = (SELECT MAX(MaNV) FROM TaiKhoan)
  -- Nếu chưa có mã sản phẩm nào
  IF (@last_code IS NULL)
  BEGIN
    SET @new_code = 'NV001'
  END
  ELSE
  BEGIN
    -- Tăng số thứ tự
    SET @counter = SUBSTRING(@last_code, 3, 5) + 1
    -- Định dạng số thứ tự
	SET @last_code = 'NV'
	DECLARE @remain_num int
	--Tính số lượng số 0 còn thiếu
	SET @remain_num = 3 - LEN(@counter)
	WHILE(@remain_num != 0)
	BEGIN
		SET @remain_num = @remain_num - 1
		SET @last_code = @last_code + '0' 
	END

    SET @new_code = CONCAT(@last_code, @counter)
  END
  
  RETURN @new_code
END
GO

CREATE FUNCTION generateHoaDonCode()
RETURNS VARCHAR(10)
AS
BEGIN
  DECLARE @last_code VARCHAR(10)
  DECLARE @new_code VARCHAR(10)
  DECLARE @counter VARCHAR(8)

  -- Lấy mã sản phẩm cuối cùng
  SET @last_code = (SELECT MAX(MaHD) FROM HoaDon)
  -- Nếu chưa có mã sản phẩm nào
  IF (@last_code IS NULL)
  BEGIN
    SET @new_code = 'HD00000001'
  END
  ELSE
  BEGIN
    -- Tăng số thứ tự
    SET @counter = SUBSTRING(@last_code, 3, 10) + 1
    -- Định dạng số thứ tự
	SET @last_code = 'HD'
	DECLARE @remain_num int
	--Tính số lượng số 0 còn thiếu
	SET @remain_num = 8 - LEN(@counter)
	WHILE(@remain_num != 0)
	BEGIN
		SET @remain_num = @remain_num - 1
		SET @last_code = @last_code + '0' 
	END

    SET @new_code = CONCAT(@last_code, @counter)
  END
  
  RETURN @new_code
END
GO

CREATE PROC addTaiKhoan @ten NVARCHAR(50), @username VARCHAR(50), @pass VARCHAR(50)
AS
BEGIN
--Them tai khoan nhan vien mac dinh loai la nhan vien (0) va trang thai la hoat dong (1)
INSERT INTO TaiKhoan VALUES(dbo.generateTaiKhoanCode(), @ten, @username, @pass, 0, 1)
END
GO

CREATE PROC addHoaDon @maNV VARCHAR(5), @sdt VARCHAR(12), @phuongThuc NVARCHAR(20), @chietKhau TINYINT, @ngayLap DATETIME, @tienKhachPhaiTra MONEY, @tienKhachDua MONEY, @tongTien MONEY, @traLai MONEY, @note NTEXT, @trangThai BIT
AS
BEGIN
INSERT INTO HoaDon VALUES(dbo.generateHoaDonCode(), @maNV, @sdt, @phuongThuc, @chietKhau, @ngayLap, @tienKhachPhaiTra, @tienKhachDua, @tongTien, @traLai, @note, @trangThai)
END
GO

CREATE PROC addSanPham @maDM VARCHAR(5), @tenSP NVARCHAR(50), @tonKho SMALLINT, @giaNhap MONEY, @giaBan MONEY, @moBan BIT, @moTa NTEXT
AS
BEGIN
INSERT INTO SanPham VALUES(dbo.generateSanPhamcode(), @maDM, @tenSP, @tonKho, @giaNhap, @giaBan, @moBan, @moTa)
END
GO

CREATE PROC addHinhAnhSanPham @maSP VARCHAR(7), @imageURL VARCHAR(893), @avatar BIT
AS
BEGIN
INSERT INTO HinhAnhSanPham VALUES(@maSP, @imageURL, @avatar)
END
GO

CREATE PROC addDanhMucSanPham @ten NVARCHAR(50), @moTa NTEXT
AS
BEGIN
INSERT INTO DanhMucSanPham VALUES(dbo.generateDanhMucSanPhamcode(), @ten, @moTa)
END
GO

CREATE PROC addKhachHang @sdt VARCHAR(12), @tenKH NVARCHAR(50)
AS
BEGIN
INSERT INTO KhachHang VALUES(@sdt, @tenKH, 0)
END
GO


CREATE PROC addChiTietHoaDon @maHD VARCHAR(12), @maSP VARCHAR(7), @soLuong SMALLINT, @donGia MONEY, @thanhTien MONEY
AS
BEGIN
INSERT INTO ChiTietHoaDon VALUES(@maHD, @maSP, @soLuong, @donGia, @thanhTien)
END
GO
-- Lấy các hóa đơn ngày hôm nay
CREATE PROC getHoaDonToday 
AS
BEGIN
	SELECT COUNT(MaHD) FROM HoaDon WHERE CONVERT(DATE, ThoiGianLap) = CONVERT(DATE,GETDATE(), 101) AND TrangThai = 1
END
GO
-- Lấy doanh thu ngày hôm nay
CREATE PROC getRevenueToday
AS
BEGIN
	SELECT SUM(TienKhachPhaiTra) FROM HoaDon WHERE CONVERT(DATE, ThoiGianLap) = CONVERT(DATE,GETDATE(), 101) AND TrangThai = 1
END
GO

CREATE PROC findSanPhamByUncompletedString @str NVARCHAR(50)
AS
BEGIN
	SELECT * FROM SanPham WHERE MaSP LIKE '%' + @str + '%' OR TenSP LIKE '%' + @str + '%'
END
