using Microsoft.VisualStudio.TestTools.UnitTesting;
using SunflowerInfrastructure;
using SunflowerTest.Utils;
using System;

namespace SunflowerTest
{
    [TestClass]
    public class UnitTest1 : TestBase
    {

        [TestMethod]
        public void TestMethod1()
        {
            RegisterationPage rp = page
                .GetHeader()
                .ClickOnRegister();
            string email = Generators.GenerateRandomEmail();
            rp.SetGender(Gender.male);
            rp.SetFirstName("hello");
            rp.SetLastName("world");
            rp.SetEmail(email);
            rp.SetPassword("123456");
            rp.SetConfirmPassword("123456");
            WebshopBrowser wb= rp.ClickOnRegister().ClickOnContinueButton();
            string account = wb.GetHeader().GetAccountText();
            Assert.AreEqual(email, account);
            wb.GetHeaderMenu().ClickOnDigitalDownloads();
            string productName = wb.GetDigitalDownloads().CliclOnAddToCardInRandomProduct();
            string cartName = wb.GetHeader().ClickOnShoppingCart().GetFirsCartName();
            Assert.AreEqual(productName, cartName);

            //ClosePage();
        }
    }
}
