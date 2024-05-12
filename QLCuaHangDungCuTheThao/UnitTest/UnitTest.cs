using NUnit.Framework;
using BLL;

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

    }
}
