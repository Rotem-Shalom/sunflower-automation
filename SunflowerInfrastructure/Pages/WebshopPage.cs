using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunflowerInfrastructure
{
    public class WebshopPage : DriverUser
    {
        private string HEADER_LINKS_CSS = ".header-links";
        private string HEADER_MENU_CSS = ".header-menu";

        public WebshopPage(IWebDriver driver) : base(driver) { }

        private IWebElement HeaderLinks => Driver.FindElement(By.CssSelector(HEADER_LINKS_CSS));
        private IWebElement HeaderMenu => Driver.FindElement(By.CssSelector(HEADER_MENU_CSS));

        
        public HeaderLinks GetHeaderLinks => new HeaderLinks(Driver, HeaderLinks);
        public HeaderMenu GetHeaderMenu=> new HeaderMenu(Driver, HeaderMenu);

    }
}
