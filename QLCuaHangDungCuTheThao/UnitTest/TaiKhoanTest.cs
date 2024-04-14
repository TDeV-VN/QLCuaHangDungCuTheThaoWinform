﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using BLL;
using System.Data;

namespace UnitTest
{
    public class HoTro
    {
        public static bool soSanhDataTable(DataTable t1, DataTable t2)
        {
            if (t1 == null)
                return false;
            if (t2 == null)
                return false;
            if (t1.Rows.Count != t2.Rows.Count)
                return false;

            if (t1.Columns.Count != t2.Columns.Count)
                return false;

            if (t1.Columns.Cast<DataColumn>().Any(dc => !t2.Columns.Contains(dc.ColumnName)))
            {
                return false;
            }

            for (int i = 0; i <= t1.Rows.Count - 1; i++)
            {
                if (t1.Columns.Cast<DataColumn>().Any(dc1 => t1.Rows[i][dc1.ColumnName].ToString() != t2.Rows[i][dc1.ColumnName].ToString()))
                {
                    return false;
                }
            }

            return true;
        }
    }

    [TestFixture]
    public class TaiKhoanTest
    {
        [Test]
        public void testGuiOTP()
        {
            string email = "thanhtien.z8436@gmail.com";
            string result = TaiKhoanBLL.guiOTP(email);
            Assert.IsNotNull(result);
        }
    }
}
