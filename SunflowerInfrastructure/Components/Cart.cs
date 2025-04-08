using OpenQA.Selenium;

namespace SunflowerInfrastructure
{
    public class Cart : ElementUser
    {
        private const string CART_NAME_CSS = ".product-name";
        public Cart(IWebDriver driver, IWebElement mainElement) : base(driver, mainElement) { }

        public string GetCartName => Waiters.FindAndWaitForElement(Driver, MainElement, By.CssSelector(CART_NAME_CSS)).Text;
    }
}
