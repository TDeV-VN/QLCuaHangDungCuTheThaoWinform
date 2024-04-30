using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class XemChiTietSPBLL
    {
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
    }
}
