using OpenQA.Selenium;

namespace SunflowerInfrastructure.Inputs
{
    public class RadioInput : ElementUser
    {
        public RadioInput(IWebDriver driver, IWebElement mainElement) : base(driver, mainElement) { }

        public void SetInput() => MainElement.Click();
    }
}
