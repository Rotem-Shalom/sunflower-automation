using Microsoft.VisualStudio.TestTools.UnitTesting;
using SunflowerInfrastructure;
using SunflowerTest.Utils;

namespace SunflowerTest
{
    [TestClass]
    public class UnitTest1 : TestBase
    {

        [TestMethod]
        public void TestMethod1()
        {
            string email = Generators.GenerateRandomEmail();
            WebshopHomePage webshop = TestHelper.RegisterToWebshop(page, email);
            Assert.AreEqual(email, webshop.GetHeaderLinks.GetAccountText());
            string productName = TestHelper.AddRandomProductToCart(page);
            string cartName = webshop.GetHeaderLinks.ClickOnShoppingCart().GetFirstCartName;
            Assert.AreEqual(productName, cartName);
        }
    }
}
