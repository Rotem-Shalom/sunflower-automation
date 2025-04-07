using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class ControlPanel : ElementUser
    {
        private string BUTTON = "#guide-button";
        public ControlPanel(IWebDriver driver, IWebElement mainElement) : base(driver, mainElement) { }

        public void ClockOnbutton()
        {
            MainElenent.FindElement(By.CssSelector(BUTTON)).Click();
        }

    }
}
