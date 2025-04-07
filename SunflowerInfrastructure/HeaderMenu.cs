using OpenQA.Selenium;
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

        public IWebElement GetOption(string optionText)
        {
            foreach (IWebElement op in MenuOptions)
            {
                string la = op.Text;
                if (la==optionText)
                {
                    la = optionText;
                }
            }
            return MenuOptions
                .FirstOrDefault(option => option.Text.Equals(optionText));
        }
        public void ClickOnDigitalDownloads()
        {
            this.GetOption("DIGITAL DOWNLOADS").Click();

        }
    }
}
