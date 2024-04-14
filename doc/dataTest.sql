--thêm tài khoản nhân viên
EXEC addTaiKhoan N'Lê Ngọc Mạnh Hùng', 'lengocmanhhung', '123456' ;
EXEC addTaiKhoan N'Nguyễn Thúc Thùy Tiên', 'nguyenthucthuytien', '456789';
EXEC addTaiKhoan N'Nguyễn Văn A', 'nguyenvana', 'nguyenvana@123';
EXEC addTaiKhoan N'Trần Thị B', 'tranthib', 'tranthib@123';
EXEC addTaiKhoan N'Lê Hoàng C', 'lehoangc', 'lehoangc@123';
GO
--thêm danh mục sản phẩm
EXEC addDanhMucSanPham N'Bóng đá', N'Dụng cụ liên quan đến bóng đá';
EXEC addDanhMucSanPham N'Cầu lông', N'Dụng cụ liên quan đến cầu lông';
EXEC addDanhMucSanPham N'Bóng rổ', N'Dụng cụ liên quan đến bóng rổ';
EXEC addDanhMucSanPham N'Bơi', N'Dụng cụ liên quan đến bơi';
EXEC addDanhMucSanPham N'Yoga', N'Dụng cụ liên quan đến yoga';
GO
-- thêm sản phẩm
EXEC addSanPham 'DM001', N'Bóng đá Nike', 35, 120000, 180000, 1, N'Bóng đá chính hãng của Nike';
EXEC addSanPham 'DM002', N'Vợt cầu lông Victor', 28, 180000, 270000, 1, N'Vợt cầu lông cao cấp của Victor';
EXEC addSanPham 'DM003', N'Giày bóng rổ Nike', 42, 300000, 450000, 1, N'Giày chính hãng Nike dành cho bóng rổ';
EXEC addSanPham 'DM004', N'Áo phao bơi Speedo', 18, 150000, 250000, 1, N'Áo phao bơi an toàn của Speedo';
EXEC addSanPham 'DM005', N'Bình nước yoga', 50, 30000, 50000, 1, N'Bình nước yoga dùng để uống trong luyện tập';
EXEC addSanPham 'DM001', N'Găng tay bóng đá', 60, 60000, 90000, 1, N'Găng tay chống sốc cho người chơi bóng đá';
EXEC addSanPham 'DM002', N'Túi đựng vợt cầu lông', 40, 40000, 60000, 1, N'Túi đựng vợt cầu lông tiện lợi';
EXEC addSanPham 'DM003', N'Quần áo bóng rổ', 30, 150000, 220000, 1, N'Bộ quần áo chính hãng cho người chơi bóng rổ';
EXEC addSanPham 'DM004', N'Bơi cánh bướm', 15, 200000, 350000, 1, N'Dụng cụ tập bơi cánh bướm chuyên nghiệp';
EXEC addSanPham 'DM005', N'Balo đựng dụng cụ yoga', 25, 80000, 120000, 1, N'Balo tiện lợi để mang theo dụng cụ yoga';
EXEC addSanPham 'DM004', N'Kính bơi Speedo', 20, 50000, 80000, 1, N'Kính bơi chính hãng Speedo';
EXEC addSanPham 'DM005', N'Mat yoga Adidas', 25, 70000, 100000, 1, N'Mat yoga cao cấp của Adidas';
EXEC addSanPham 'DM002', N'Vợt cầu lông Li-Ning', 20, 250000, 380000, 1, N'Vợt cầu lông cao cấp của Li-Ning';
EXEC addSanPham 'DM003', N'Áo bóng rổ Adidas', 35, 180000, 280000, 0, N'Áo chính hãng Adidas cho người chơi bóng rổ';
EXEC addSanPham 'DM005', N'Tạ đơn 5kg', 40, 120000, 180000, 1, N'Tạ đơn 5kg dùng cho luyện tập thể dục';
GO
--thêm khách hàng
EXEC addKhachHang '0909828272', N'Nguyễn Thu Thủy';
EXEC addKhachHang '0987654321', N'Nguyễn Thị Ánh';
EXEC addKhachHang '0123456789', N'Trần Văn Bình';
EXEC addKhachHang '0909090909', N'Lê Thị Chi';
EXEC addKhachHang '0888888888', N'Phạm Văn Đông';
GO
--thêm hóa đơn
-- Hóa đơn 1
EXEC addHoaDon 'NV001', '0987654321', 'Tiền mặt', 10, '3-2-2024', 200000, 200000, 200000, 0, N'Ghi chú cho hóa đơn 1', 1;
EXEC addChiTietHoaDon 'HD00000001', 'SP00004', 2, 80000, 160000;
EXEC addChiTietHoaDon 'HD00000001', 'SP00005', 1, 100000, 100000;
GO
-- Hóa đơn 2
EXEC addHoaDon 'NV002', '0123456789', N'Tiền mặt', 5, '4-13-2024', 300000, 300000, 300000, 0, N'Ghi chú cho hóa đơn 2', 1;
EXEC addChiTietHoaDon 'HD00000002', 'SP00006', 1, 270000, 270000;
GO
-- Hóa đơn 3
EXEC addHoaDon 'NV003', '0909090909', N'Chuyển khoản', 15, '4-13-2024', 500000, 500000, 500000, 0, N'Ghi chú cho hóa đơn 3', 1;
EXEC addChiTietHoaDon 'HD00000003', 'SP00007', 1, 220000, 220000;
GO
-- Hóa đơn 4
EXEC addHoaDon 'NV001', '0888888888', N'Tiền mặt', 0, '4-13-2024', 400000, 400000, 400000, 0, N'Ghi chú cho hóa đơn 4', 1;
EXEC addChiTietHoaDon 'HD00000004', 'SP00008', 1, 450000, 450000;
GO
-- Hóa đơn 5
EXEC addHoaDon 'NV002', '0987654321', N'Tiền mặt', 0, '4-2-2024', 600000, 600000, 600000, 0, N'Ghi chú cho hóa đơn 5', 1;
EXEC addChiTietHoaDon 'HD00000005', 'SP00009', 1, 180000, 180000;
GO
-- Hóa đơn 6
EXEC addHoaDon 'NV003', '0123456789', N'Chuyển khoản', 20, '3-7-2024', 800000, 800000, 800000, 0, N'Ghi chú cho hóa đơn 6', 1;
EXEC addChiTietHoaDon 'HD00000006', 'SP00010', 2, 100000, 200000;
GO
-- Hóa đơn 7
EXEC addHoaDon 'NV001', '0909090909', N'Tiền mặt', 0, '2-23-2024', 1000000, 1000000, 1000000, 0, N'Ghi chú cho hóa đơn 7', 1;
EXEC addChiTietHoaDon 'HD00000007', 'SP00011', 1, 90000, 90000;
GO
-- Hóa đơn 8
EXEC addHoaDon 'NV002', '0888888888', N'Tiền mặt', 10, '4-13-2024', 1200000, 1200000, 1200000, 0, N'Ghi chú cho hóa đơn 8', 1;
EXEC addChiTietHoaDon 'HD00000008', 'SP00012', 1, 60000, 60000;
GO
-- Hóa đơn 9
EXEC addHoaDon 'NV003', '0987654321', N'Chuyển khoản', 5, '2-23-2024', 1500000, 1500000, 1500000, 0, N'Ghi chú cho hóa đơn 9', 1;
EXEC addChiTietHoaDon 'HD00000009', 'SP00013', 3, 220000, 660000;
GO


--thêm hình ảnh sản phẩm TIẾN
exec addHinhAnhSanPham 'SP00001', 'E:\imgWinform\banhnike.webp', 1;
exec addHinhAnhSanPham 'SP00001', 'E:\imgWinform\banhnike2.jpeg', 0;
exec addHinhAnhSanPham 'SP00002', 'E:\imgWinform\votvictor.png', 1;
exec addHinhAnhSanPham 'SP00003', 'E:\imgWinform\giaynikebongro.jpeg', 1;
exec addHinhAnhSanPham 'SP00004', 'E:\imgWinform\aophao.jpeg', 1;
exec addHinhAnhSanPham 'SP00005', 'E:\imgWinform\binhnuocyoga.png', 1;
exec addHinhAnhSanPham 'SP00006', 'E:\imgWinform\gangtaybongda.jpeg', 1;
exec addHinhAnhSanPham 'SP00007', 'E:\imgWinform\tuidungcau.webp', 1;
exec addHinhAnhSanPham 'SP00008', 'E:\imgWinform\aobongro.jpeg', 1;
exec addHinhAnhSanPham 'SP00009', 'E:\imgWinform\doboicanhbuom.jpeg', 1;
exec addHinhAnhSanPham 'SP00010', 'E:\imgWinform\balodungdoyoga.jpeg', 1;
exec addHinhAnhSanPham 'SP00011', 'E:\imgWinform\kinhboi.jpeg', 1;
exec addHinhAnhSanPham 'SP00012', '', 1;
exec addHinhAnhSanPham 'SP00013', 'E:\imgWinform\votlining.jpeg', 1;
exec addHinhAnhSanPham 'SP00014', 'E:\imgWinform\aobongro.jpeg', 1;
exec addHinhAnhSanPham 'SP00015', 'E:\imgWinform\ta.jpeg', 1;
----------------------------------------------------------------------------