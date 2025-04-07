using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunflowerInfrastructure
{
    public class RegistrationResultPage : DriverUser
    {
        private string CONTINUE_BUTTON_CSS = ".register-continue-button";

        public RegistrationResultPage(IWebDriver driver) : base(driver) { }
        private IWebElement ContinueButton => Driver.FindElement(By.CssSelector(CONTINUE_BUTTON_CSS));

        public WebshopPage ClickOnContinueButton()
        {
            ContinueButton.Click();
            return new WebshopPage(Driver);
        }

    }
}
