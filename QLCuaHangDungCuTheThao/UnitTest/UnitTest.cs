using NUnit.Framework;
using BLL;
using DAL;

namespace UnitTest
{
    [TestFixture]
    public class UnitTest
    {
        [Test]
        public void testGuiOTP()
        {
            string email = "thanhtien.z8436@gmail.com";
            string result = TaiKhoanBLL.guiOTP(email);
            Assert.IsNotNull(result);
        }

        [Test]
        public void testHashPassword()
        {
            string password = "123456";
            string result = TaiKhoanBLL.hashPassword(password);
            Assert.AreNotEqual(password, result);
        }

        [Test]
        public void testReadDataFromGoogleSheet()
        {
            string result = Payment.readDataFromGoogleSheet(0, 0);
            Assert.IsNotNull(result);
        }

        [Test]
        public void testKiemTraTinhNangXacThucGiaoDich()
        {
            Assert.IsTrue(DatabaseAccess.kiemTraTinhNangXacThucGiaoDich());
        }

        [Test]
        public void testLayNganHangId()
        {
            int result = DatabaseAccess.layNganHangId();
            Assert.IsTrue(result != 0);
        }

        [Test]
        public void testLaySoTaiKhoan()
        {
            long result = DatabaseAccess.laySoTaiKhoan();
            Assert.IsTrue(result != 0);
        }

        [Test]
        public void testLayDiaChi()
        {
            string result = DatabaseAccess.layDiaChiCH();
            Assert.IsTrue(result != "");
        }

        [Test]
        public void testLaySdtCH()
        {
            string result = DatabaseAccess.laySdtCH();
            Assert.IsTrue(result != "");
        }

        [Test]
        public void testLayEmailCH()
        {
            string result = DatabaseAccess.layEmailCH();
            Assert.IsTrue(result != "");
        }
    }
}
