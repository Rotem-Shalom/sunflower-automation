using OpenQA.Selenium;
using SunflowerInfrastructure.Components;

namespace SunflowerInfrastructure
{
    public class RegistrationPage : DriverUser
    {
        private const string REGISTER_CSS = ".registration-page";

        public RegistrationPage(IWebDriver driver) : base(driver) { }

        public Register GetRegister => new Register(Driver, Driver.FindElement(By.CssSelector(REGISTER_CSS)));
    }
}
