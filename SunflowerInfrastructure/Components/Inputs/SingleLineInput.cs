using OpenQA.Selenium;

namespace SunflowerInfrastructure.Inputs
{
    public class SingleLineInput : ElementUser
    {
        public SingleLineInput(IWebDriver driver, IWebElement mainElement) : base(driver, mainElement) { }

        public void SetInput(string text) => MainElement.SendKeys(text);
    }
}
