public class HinhAnhSanPham {
    public string MaSP{get; set;}
    public string ImageURL{get; set;}

    public HinhAnhSanPham(string MaSP, string ImageURL) {
        this.MaSP = MaSP;
        this.ImageURL = ImageURL;
    }
}