using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using BLL;

namespace UnitTest
{
    [TestFixture]
    public class TaiKhoanTest
    {
        [Test]
        public void TestGuiOTP()
        {
            string email = "thanhtien.z8436@gmail.com";
            string result = TaiKhoanBLL.guiOTP(email);
            Assert.IsNotNull(result);
        }
    }
}
