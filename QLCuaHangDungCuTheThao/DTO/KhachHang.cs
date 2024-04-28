public class KhachHang {
    private string sdt;
    private string tenKH; //Bỏ
    private int diemUuDai;

    public string SDT { get => sdt; set => sdt = value; }
    public string TenKH { get => tenKH; set => tenKH = value; }
    public int DiemUuDai { get => diemUuDai; set => diemUuDai = value; }

    public KhachHang(string SDT, string TenKH) {
        this.SDT = SDT;
        this.TenKH = TenKH;
        this.DiemUuDai = 0;    
    }
}