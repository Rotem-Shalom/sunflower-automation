using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunflowerInfrastructure
{
    public class RegisterationResultPage : ElementUser
    {
        private string CONFIRM_BUTTON_CSS = ".register-continue-button";
        //private string WEBSHOP_PAGE_CSS = ".master-wrapper-page";

        public RegisterationResultPage(IWebDriver driver, IWebElement mainElement) : base(driver, mainElement) { }
        private IWebElement ConfirmButton => MainElenent.FindElement(By.CssSelector(CONFIRM_BUTTON_CSS));

        public WebshopBrowser ClickOnContinueButton()
        {
            ConfirmButton.Click();
            return new WebshopBrowser(Driver);
        }

    }
}
