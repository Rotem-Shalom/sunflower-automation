using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace SunflowerInfrastructure
{
    public class DriverUser
    {
        protected IWebDriver Driver { get; private set; }
        protected Actions Actions { get; set; }

        public DriverUser(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}
