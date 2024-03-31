public class KhachHang {
    public string SDT{get; set;}
    public string TenKH{get; set;}
    public int DiemUuDai{get; set;}

    public KhachHang(string SDT, string TenKH) {
        this.SDT = SDT;
        this.TenKH = TenKH;
        this.DiemUuDai = 0;    
    }
}