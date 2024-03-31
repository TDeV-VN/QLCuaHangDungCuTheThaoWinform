public class DanhMucSanPham {
    public string MaDM{get; set;}
    public string TenDM{get; set;}
    public string MoTa{get; set;}

    public DanhMucSanPham(string MaDM, string TenDM, string MoTa) {
        // Co le khong can nhap khoa chinh vi trong sql da tao ma tu dong
        this.MaDM = MaDM;
        this.TenDM = TenDM;
        this.MoTa = MoTa;
    }
}