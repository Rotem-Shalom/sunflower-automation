using OpenQA.Selenium;

namespace SunflowerInfrastructure
{
    public class ElementUser : DriverUser
    {
        protected IWebElement MainElement;
        public ElementUser(IWebDriver driver, IWebElement element) : base(driver)
        {
            MainElement = element;
        }
    }
}
