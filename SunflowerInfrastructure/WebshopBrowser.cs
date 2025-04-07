using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunflowerInfrastructure
{
    public class WebshopBrowser : DriverUser
    {
        private string HEADER_CSS = ".header-links";
        private string HEADER_MENU_CSS = ".header-menu";
        private string DIGITAL_DOWNLOADS_PAGE_CSS = ".category-page";
        private string PANEL = "#guide-content";

        public WebshopBrowser(IWebDriver driver) : base(driver)
        {
            Driver.Navigate().GoToUrl("https://demowebshop.tricentis.com");
        }

        private IWebElement Header => Driver.FindElement(By.CssSelector(HEADER_CSS));
        private IWebElement HeaderMenu => Driver.FindElement(By.CssSelector(HEADER_MENU_CSS));
        private IWebElement DigitalDownloads => Driver.FindElement(By.CssSelector(DIGITAL_DOWNLOADS_PAGE_CSS));

        public Header GetHeader()
        {
            return new Header(Driver, Header);
        }

        public HeaderMenu GetHeaderMenu()
        {
            return new HeaderMenu(Driver, HeaderMenu);
        }

        public DigitalDownloadsPage GetDigitalDownloads()
        {
            return new DigitalDownloadsPage(Driver, DigitalDownloads);
        }

        public void CloseDriver()
        {
            Driver.Close();
        }
    }
}
