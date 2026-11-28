using Microsoft.VisualStudio.TestTools.UnitTesting;
using BikeShop.Helpers;

namespace BikeShopTests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string password = "Test123!";
            var result = PasswordHelper.HashPassword(password);
            bool verified = PasswordHelper.VerifyPassword(
                password, result.Hash, result.Salt);
            Assert.IsTrue(verified);
        }
    }
}
