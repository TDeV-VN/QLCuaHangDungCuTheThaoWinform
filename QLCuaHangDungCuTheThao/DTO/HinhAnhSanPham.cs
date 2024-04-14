public class HinhAnhSanPham {
    private string maSP;
    private string imageURL;
    private bool avatar;
    public string MaSP { get => maSP; set => maSP = value; }
    public string ImageURL { get => imageURL; set => imageURL = value; }
    public bool Avatar { get => avatar; set => avatar = value; }

    public HinhAnhSanPham(string MaSP, string ImageURL, bool avatar) {
        this.MaSP = MaSP;
        this.ImageURL = ImageURL;
        this.Avatar = avatar;
    }
}