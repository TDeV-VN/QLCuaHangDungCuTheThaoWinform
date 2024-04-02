using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GeneralBLL
    {
        // Lấy SanPham từ DAL bằng mã sản phẩm
        public static SanPham GetSanPham(string maSP)
        {
            SanPham sp = DatabaseAccess.GetSanPham(maSP);
            return sp;          
        }


    }
}
