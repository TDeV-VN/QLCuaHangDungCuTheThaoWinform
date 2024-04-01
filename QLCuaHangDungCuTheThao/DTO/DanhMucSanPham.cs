public class DanhMucSanPham {
    private string maDM;
    private string tenDM;
    private string moTa;

    public string MaDM { get => maDM; set => maDM = value; }
    public string TenDM { get => tenDM; set => tenDM = value; }
    public string MoTa { get => moTa; set => moTa = value; }

    public DanhMucSanPham(string MaDM, string TenDM, string MoTa) {
        this.MaDM = MaDM;
        this.TenDM = TenDM;
        this.MoTa = MoTa;
    }
}