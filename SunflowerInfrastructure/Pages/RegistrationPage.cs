using OpenQA.Selenium;
using SunflowerInfrastructure.Components;

namespace SunflowerInfrastructure
{
    public class RegistrationPage : DriverUser
    {
        private const string REGISTER_CSS = ".registration-page";

        public RegistrationPage(IWebDriver driver) : base(driver) { }

        private IWebElement RegisterComponent => Waiters.FindAndWaitForElement(Driver, By.CssSelector(REGISTER_CSS));

        public Register GetRegister => new Register(Driver, RegisterComponent);
    }
}
