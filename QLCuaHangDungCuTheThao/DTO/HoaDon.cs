public class HoaDon {
    private string maHD;
    private string maNV;
    private string sdt;
    private string phuongThucThanhToan;
    private long chietKhau;
    private string thoiGianLap;
    private long tienKhachPhaiTra;
    private long tienKhachDua;
    private long tongTienHang;
    private long traLai;
    private string ghiChu;
    private string trangThai;

    public string MaHD { get => maHD; set => maHD = value; }
    public string MaNV { get => maNV; set => maNV = value; }
    public string SDT { get => sdt; set => sdt = value; }
    public string PhuongThucThanhToan { get => phuongThucThanhToan; set => phuongThucThanhToan = value; }
    public long ChietKhau { get => chietKhau; set => chietKhau = value; }
    public string ThoiGianLap { get => thoiGianLap; set => thoiGianLap = value; }
    public long TienKhachPhaiTra { get => tienKhachPhaiTra; set => tienKhachPhaiTra = value; }
    public long TienKhachDua { get => tienKhachDua; set => tienKhachDua = value; }
    public long TongTienHang { get => tongTienHang; set => tongTienHang = value; }
    public long TraLai { get => traLai; set => traLai = value; }
    public string GhiChu { get => ghiChu; set => ghiChu = value; }
    public string TrangThai { get => trangThai; set => trangThai = value; }

    public HoaDon(string MaHD, string MaNV, string SDT, string PhuongThucThanhToan, int ChietKhau, string ThoiGianLap, long TienKhachPhaiTra, long TienKhachDua, long TongTienHang, long TraLai, string GhiChu) {
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
        this.TrangThai = "Hoàn thành";
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

    public HoaDon(string MaHD)
    {
        this.MaHD = MaHD; 
    }
}