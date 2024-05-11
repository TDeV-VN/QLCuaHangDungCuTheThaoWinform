using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace BLL
{
    public class XemChiTietSPBLL
    {
        private List<String> maHDs = new List<String>();
        public static bool xoa = false; //xác định sản phẩm có bị xóa không để refresh lại danh sách sản phẩm
        private List<ChiTietHoaDon> chiTietHoaDons;
        private DataTable listDanhMuc;
        private SanPham product;
        public DataTable ListDanhMuc { get => listDanhMuc; set => listDanhMuc = value; }
        public SanPham Product { get => product; set => product = value; }
        public XemChiTietSPBLL(string maSP)
        {
            ListDanhMuc = new DataTable();
            DatabaseAccess.getListDanhMuc(listDanhMuc);
            Product = DatabaseAccess.GetSanPham(maSP);
        }
        public string getTenDanhMucByMaDM(string maDM)
        {
            return DatabaseAccess.getTenDanhMucByMaDM(maDM);
        }

        public List<string> getAllNonAvatarURLSanPham(string maSP)
        {
            return DatabaseAccess.getAllNonAvatarURLSanPham(maSP);
        }

        public string getAvatarURLSanPham(string maSP)
        {
            return DatabaseAccess.GetAvatarURLSanPham(maSP);
        }

        public bool layChiTietHoaDon(string maSP)
        {
            chiTietHoaDons = DatabaseAccess.layChiTietHoaDon(maSP);
            return chiTietHoaDons.Count > 0 ? true : false;
        }

        public bool xoaSanPhamDaBan()
        {
            getMaHDs();
            foreach (string mahd in maHDs)
            {
                if (!DatabaseAccess.xoaChiTietHoaDon(mahd)) return false;
                if (!DatabaseAccess.xoaHoaDon(mahd)) return false;
            }
            if (!DatabaseAccess.xoaHinhAnhSanPham(product.MaSP)) return false;
            if (!DatabaseAccess.xoaSanPham(product.MaSP)) return false;
            xoa = true;
            return true;
        }

        public bool xoaSanPhamChuaBan()
        {
            if (!DatabaseAccess.xoaHinhAnhSanPham(product.MaSP)) return false;
            if (!DatabaseAccess.xoaSanPham(product.MaSP)) return false;
            xoa = true;
            return true;
        }

        //lấy danh sách mã hóa đơn từ danh sách chi tiết hóa đơn, trùng thì bỏ qua
        public List<String> getMaHDs()
        {
            foreach (ChiTietHoaDon cthd in chiTietHoaDons)
            {
                if (!maHDs.Contains(cthd.MaHD))
                {
                    maHDs.Add(cthd.MaHD);
                }
            }
            return maHDs;
        }


    }
}
