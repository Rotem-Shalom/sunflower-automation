using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SunflowerInfrastructure;
using SunflowerTest.Utils;
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
        protected WebshopPage page;

        [TestInitialize]
        public void setUp()
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl(Consts.WEB_ADDRESS);
            page = new WebshopPage(Driver);
        }

        [TestCleanup]
        public void ClosePage()
        {
            Driver.Close();
        }

    }
}
