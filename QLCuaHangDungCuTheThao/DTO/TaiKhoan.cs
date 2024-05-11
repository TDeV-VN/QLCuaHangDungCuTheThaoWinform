public class TaiKhoan {
    private string maNV;
    private string tenNV;
    private string email;
    private string password;
    private bool role;
    private bool trangThai;
    
    public string MaNV { get => maNV; set => maNV = value; }
    public string TenNV { get => tenNV; set => tenNV = value; }
    public string Email { get => email; set => email = value; }
    public string Password { get => password; set => password = value; }
    public bool Role { get => role; set => role = value; }
    public bool TrangThai { get => trangThai; set => trangThai = value; }

    public TaiKhoan(string maNV, string tenNV, string email, string password, bool role, bool trangThai)
    {
        this.MaNV = maNV;
        this.TenNV = tenNV;
        this.Email = email;
        this.Password = password;
        this.Role = role;
        this.TrangThai = trangThai;
    }

    public TaiKhoan(string maNV, string email, bool role, bool trangThai)
    {
        this.MaNV = maNV;
        this.Email = email;
        this.Role = role;
        this.TrangThai = trangThai;
    }

    public TaiKhoan()
    {
        this.role = false;
        this.email = "";
        this.maNV = "";
        this.password = "";
        this.trangThai = false;
    }
}