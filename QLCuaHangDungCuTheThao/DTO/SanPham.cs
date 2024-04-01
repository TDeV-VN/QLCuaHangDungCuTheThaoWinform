public class SanPham {
    private string maSP;
    private string maDM;
    private string tenSP;
    private int tonKho;
    private long giaNhap;
    private long giaBan;
    private bool moBan;
    private string moTa;

    public string MaSP { get => maSP; set => maSP = value; }
    public string MaDM { get => maDM; set => maDM = value; }
    public string TenSP { get => tenSP; set => tenSP = value; }
    public int TonKho { get => tonKho; set => tonKho = value; }
    public long GiaNhap { get => giaNhap; set => giaNhap = value; }
    public long GiaBan { get => giaBan; set => giaBan = value; }
    public bool MoBan { get => moBan; set => moBan = value; }
    public string MoTa { get => moTa; set => moTa = value; }

    public SanPham(string MaSP, string MaDM, string TenSP, int TonKho, long GiaNhap, long GiaBan, bool MoBan, string MoTa) {
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