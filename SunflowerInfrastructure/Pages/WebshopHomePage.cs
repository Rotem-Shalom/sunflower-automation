using OpenQA.Selenium;

namespace SunflowerInfrastructure
{
    public class WebshopHomePage : DriverUser
    {
        private const string HEADER_LINKS_CSS = ".header-links";
        private const string HEADER_MENU_CSS = ".header-menu";

        public WebshopHomePage(IWebDriver driver) : base(driver) { }

        private IWebElement HeaderLinks => Driver.FindElement(By.CssSelector(HEADER_LINKS_CSS));
        private IWebElement HeaderMenu => Driver.FindElement(By.CssSelector(HEADER_MENU_CSS));


        public HeaderLinks GetHeaderLinks => new HeaderLinks(Driver, HeaderLinks);
        public HeaderMenu GetHeaderMenu => new HeaderMenu(Driver, HeaderMenu);

    }
}
