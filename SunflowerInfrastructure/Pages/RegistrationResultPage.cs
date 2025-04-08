using OpenQA.Selenium;

namespace SunflowerInfrastructure
{
    public class RegistrationResultPage : DriverUser
    {
        private const string CONTINUE_BUTTON_CSS = ".register-continue-button";

        public RegistrationResultPage(IWebDriver driver) : base(driver) { }

        private IWebElement ContinueButton => Waiters.FindAndWaitForElement(Driver, By.CssSelector(CONTINUE_BUTTON_CSS));

        public WebshopHomePage ClickOnContinueButton()
        {
            ContinueButton.Click();
            return new WebshopHomePage(Driver);
        }
    }
}
