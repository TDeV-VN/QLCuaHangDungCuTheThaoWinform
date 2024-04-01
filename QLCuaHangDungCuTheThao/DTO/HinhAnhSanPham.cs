public class HinhAnhSanPham {
    private string maSP;
    private string ImageURL;

    public string MaSP { get => maSP; set => maSP = value; }
    public string ImageURL1 { get => ImageURL; set => ImageURL = value; }

    public HinhAnhSanPham(string MaSP, string ImageURL) {
        this.MaSP = MaSP;
        this.ImageURL = ImageURL;
    }
}