using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BLL
{
    public class DanhSachSanPhamBLL
    {
        private DataTable listsanpham = new DataTable();
        public DataTable Listsanpham { get => listsanpham; set => listsanpham = value; }

        //Khởi tạo danh sách sản phẩm với tất cả sản phẩm trong cơ sở dữ liệu
        public DanhSachSanPhamBLL()
        {
            this.Listsanpham.Columns.Add("anh", typeof(Image));
            this.Listsanpham.Columns.Add("MaSP", typeof(string));
            this.Listsanpham.Columns.Add("TenSP", typeof(string));
            this.Listsanpham.Columns.Add("DanhMuc", typeof(string));
            this.Listsanpham.Columns.Add("TonKho", typeof(int));
            List<SanPham> listAllSanPham = DatabaseAccess.GetAllSanPham();
            try
            {
                foreach (SanPham sp in listAllSanPham)
                {
                    string urlImg = DatabaseAccess.GetAvatarURLSanPham(sp.MaSP);
                    if (urlImg != "")
                    {
                        try
                        {
                            this.Listsanpham.Rows.Add(Image.FromFile(urlImg), sp.MaSP, sp.TenSP, sp.MaDM, sp.TonKho);
                        }
                        catch
                        {
                            this.Listsanpham.Rows.Add(null, sp.MaSP, sp.TenSP, sp.MaDM, sp.TonKho);
                        }
                    }
                    else
                    {
                        // Không tìm thấy url ảnh đại diện sẽ gán ảnh đại diện bằng null
                        this.Listsanpham.Rows.Add(null, sp.MaSP, sp.TenSP, sp.MaDM, sp.TonKho);
                    }
                }
            } catch (Exception e)
            {
                MessageBox.Show("Lỗi hàm khởi tạo DanhSachSanPhamBLL: " + e);
            }
            
        }

        /*Tạo data cho các combobox*/
        public List<string> getDanhMuc()
        {
            List<string> listDanhMuc = new List<string>();
            listDanhMuc.AddRange(DatabaseAccess.GetAllDanhMuc());
            listDanhMuc.Sort();
            listDanhMuc.Insert(0, "Tất cả");
            return listDanhMuc;
        }
        public List<string> getTrangThai()
        {
            List<string> listTrangThai = new List<string>();
            listTrangThai.Add("Tất cả");
            listTrangThai.Add("Mở bán");
            listTrangThai.Add("Dừng bán");
            return listTrangThai;
        }
        public List<string> getSapXep()
        {
            List<string> listSapXep = new List<string>();
            listSapXep.Add("Mặc định");
            listSapXep.Add("A - Z");
            listSapXep.Add("Z - A");
            return listSapXep;
        }
    }
}
