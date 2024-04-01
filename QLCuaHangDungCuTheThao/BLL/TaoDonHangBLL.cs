using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TaoDonHangBLL
    {
        public static string AutoGenerateMaHD()
        {
            string topMaHD = DAL.DatabaseAccess.GetTopMaHD();
            if (topMaHD == "")
            {
                return "HD00000001";
            }
            else
            {
                int number = int.Parse(topMaHD.Substring(2)) + 1;
                string newMaHD = "HD" + number.ToString("00000000");
                return newMaHD;
            }
        }

    }
}
