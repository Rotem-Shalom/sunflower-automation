using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SunflowerInfrastructure;
using SunflowerTest.Utils;

namespace SunflowerTest
{
    public class TestBase
    {
        private IWebDriver Driver;
        protected WebshopHomePage page;

        [TestInitialize]
        public void setUp()
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl(Consts.WEB_ADDRESS);
            page = new WebshopHomePage(Driver);
        }

        [TestCleanup]
        public void ClosePage()
        {
            Driver.Close();
        }

    }
}
