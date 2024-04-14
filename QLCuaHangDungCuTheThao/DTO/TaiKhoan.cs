public class TaiKhoan {
    private string maNV;
    private string tenNV;
    private string username;
    private string password;
    private bool role;
    private bool trangThai;
    
    public string MaNV { get => maNV; set => maNV = value; }
    public string TenNV { get => tenNV; set => tenNV = value; }
    public string Username { get => username; set => username = value; }
    public string Password { get => password; set => password = value; }
    public bool Role { get => role; set => role = value; }
    public bool TrangThai { get => trangThai; set => trangThai = value; }

    public TaiKhoan(string maNV, string tenNV, string username, string password, bool role, bool trangThai)
    {
        this.MaNV = maNV;
        this.TenNV = tenNV;
        this.Username = username;
        this.Password = password;
        this.Role = role;
        this.TrangThai = trangThai;
    }
}