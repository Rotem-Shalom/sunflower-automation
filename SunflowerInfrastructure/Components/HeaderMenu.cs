using OpenQA.Selenium;
using SunflowerInfrastructure.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunflowerInfrastructure
{
    public class HeaderMenu : ElementUser
    {
        private string TOP_MENU_OPTIONS_CSS = ".top-menu a";
        public HeaderMenu(IWebDriver driver, IWebElement mainElement) : base(driver, mainElement) { }
        private List<IWebElement> MenuOptions => MainElenent.FindElements(By.CssSelector(TOP_MENU_OPTIONS_CSS)).ToList();
        public IWebElement GetOption(string optionText) => MenuOptions
                .FirstOrDefault(option => option.Text.Equals(optionText));

        public DigitalDownloadsPage ClickOnOption(string headerMenuOption)
        {
            this.GetOption(headerMenuOption).Click();
            return new DigitalDownloadsPage(Driver);
        }
    }
}
