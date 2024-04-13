public class HinhAnhSanPham {
    private string maSP;
    private string imageURL;
    private string avatar;
    public string MaSP { get => maSP; set => maSP = value; }
    public string ImageURL { get => imageURL; set => imageURL = value; }
    public string Avatar { get => avatar; set => imageURL = value; }

    public HinhAnhSanPham(string MaSP, string ImageURL, string avatar) {
        this.MaSP = MaSP;
        this.ImageURL = ImageURL;
        this.Avatar = avatar;
    }
}