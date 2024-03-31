public class TaiKhoan {
    public string MaNV{get; set;}
    public string Username{get; set;}
    public string Pass{get; set;}
    public boolean TypeAcc{get; set;}
    public boolean TrangThai{get; set;}
    public TaiKhoan(string MaNV, string Username, string Pass) {
        this.MaNV = MaNV;
        this.Username = Username;
        this.Pass = Pass;
        this.TypeAcc = false; //  true with admin, false with clerk
        this.TrangThai = true; // true with active, false with inactive
    }
}