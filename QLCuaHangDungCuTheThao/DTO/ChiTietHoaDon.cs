public class ChiTietHoaDon {
    public string MaHD{get; set;}
    public string MaSP{get; set;}
    public int SoLuong{get; set;}
    public double DonGia{get; set;}
    public double ThanhTien{get; set;}

    public ChiTietHoaDon(string MaHD, string MaSP, string SoLuong, string DonGia, double ThanhTien) {
        this.MaHD = MaHD;
        this.MaSP = MaSP;
        this.SoLuong = SoLuong;
        this.DonGia = DonGia;
        this.ThanhTien = ThanhTien;
    }
}