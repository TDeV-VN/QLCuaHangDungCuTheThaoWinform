public class HoaDon {
    public string MaHD{get; set;}
    public string MaNV{get; set;}
    public string SDT{get; set;}
    public string PhuongThucThanhToan{get; set;}
    public int ChietKhau{get; set;}
    public string ThoiGianLap{get; set;}
    public double TienKhachPhaiTra{get; set;}
    public double TienKhachDua{get; set;}
    public double TongTienHang{get; set;}
    public double TraLai{get; set;}
    public string GhiChu{get; set;} 

    public HoaDon(string MaHD, string MaNV, string SDT, string PhuongThucThanhToan, int ChietKhau, string ThoiGianLap, double TienKhachPhaiTra, double TienKhachDua, double TongTienHang, double TraLai, string GhiChu) {
        this.MaHD = MaHD;
        this.MaNV = MaNV;
        this.SDT = SDT;
        this.PhuongThucThanhToan = PhuongThucThanhToan; 
        this.ChietKhau = ChietKhau;
        this.ThoiGianLap = ThoiGianLap; 
        this.TienKhachPhaiTra = TienKhachPhaiTra; 
        this.TienKhachDua = TienKhachDua; 
        this.TongTienHang = TongTienHang; 
        this.TraLai = TraLai; 
        this.GhiChu = GhiChu;
    }

    public HoaDon(string MaHD, string MaNV, string SDT, string PhuongThucThanhToan, string ThoiGianLap, string GhiChu) {
        this.MaHD = MaHD;
        this.MaNV = MaNV;
        this.SDT = SDT;
        this.PhuongThucThanhToan = PhuongThucThanhToan;
        this.ThoiGianLap = ThoiGianLap; 
        this.GhiChu = GhiChu;
        //ChietKhau, TienKhachPhaiTRa, TienKhachDua,... chua ton tai khi tao HoaDon
    }
}