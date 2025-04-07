using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SunflowerInfrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunflowerTest
{
    public class TestBase
    {
        private IWebDriver Driver;
        protected WebshopBrowser page;

        [TestInitialize]
        public void setUp()
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("https://demowebshop.tricentis.com");
            page = new WebshopBrowser(Driver);
        }

        [TestCleanup]
        public void ClosePage()
        {
            page.CloseDriver();
        }

    }
}
