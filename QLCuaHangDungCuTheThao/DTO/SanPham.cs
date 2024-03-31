public class SanPham {
    public string MaSP{get; set;}
    public string MaDM{get; set;}
    public string TenSP{get; set;}
    public int TonKho{get; set;}
    public double GiaNhap{get; set;}
    public double GiaBan{get; set;}
    public boolean MoBan{get; set;}
    public string MoTa{get; set;}

    public SanPham(string MaSP, string MaDM, string TenSP, int TonKho, double GiaNhap, double GiaBan, boolean MoBan, string MoTa) {
        this.MaSP = MaSP;
        this.MaDM = MaDM;
        this.TenSP = TenSP;
        this.TonKho = TonKho; 
        this.GiaNhap = GiaNhap; 
        this.GiaBan = GiaBan; 
        this.MoBan = MoBan;
        this.MoTa = MoTa;
    }
}