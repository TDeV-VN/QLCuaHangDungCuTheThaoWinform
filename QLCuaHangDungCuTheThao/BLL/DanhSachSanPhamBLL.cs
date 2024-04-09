using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;
using System.Drawing;

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

            this.listsanpham.Rows.Add(Image.FromFile("E:\\AnhDungCuTheThao\\anhGiay.png"), "SP00001", "Áo thể thao nam", "Áo", 100);
            this.listsanpham.Rows.Add(Image.FromFile("E:\\AnhDungCuTheThao\\anhGiay.png"), "SP00002", "Áo thể thao nam", "Áo", 100);
        }

        /*Tạo data cho các combobox*/
        public List<string> getDanhMuc()
        {
            List<string> listDanhMuc = new List<string>();
            listDanhMuc.Add("Tất cả");
            listDanhMuc.AddRange(DatabaseAccess.GetAllDanhMuc());
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
