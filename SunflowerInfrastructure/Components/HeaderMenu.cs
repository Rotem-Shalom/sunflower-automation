using OpenQA.Selenium;
using SunflowerInfrastructure.Enums;
using System.Collections.Generic;
using System.Linq;

namespace SunflowerInfrastructure
{
    public class HeaderMenu : ElementUser
    {
        private const string TOP_MENU_OPTIONS_CSS = ".top-menu a";
        public HeaderMenu(IWebDriver driver, IWebElement mainElement) : base(driver, mainElement) { }

        private List<IWebElement> MenuOptions => MainElement.FindElements(By.CssSelector(TOP_MENU_OPTIONS_CSS)).ToList();

        public IWebElement GetOption(string optionText) => MenuOptions
                .FirstOrDefault(option => option.Text.Equals(optionText));

        public DigitalDownloadsPage ClickOnOption()
        {
            this.GetOption(HeaderMenuOptions.DIGITAL_DOWNLANDS).Click();
            return new DigitalDownloadsPage(Driver);
        }
    }
}
