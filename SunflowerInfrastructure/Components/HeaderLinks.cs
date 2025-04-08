using OpenQA.Selenium;

namespace SunflowerInfrastructure
{
    public class HeaderLinks : ElementUser
    {
        private const string REGISTER_CSS = ".ico-register";
        private const string ACCOUNT_CSS = ".account";
        private const string SHOPPING_CART_CSS = ".header-links #topcartlink";
        public HeaderLinks(IWebDriver driver, IWebElement mainElement) : base(driver, mainElement) { }

        private IWebElement Register => Waiters.FindAndWaitForElement(Driver, MainElement, By.CssSelector(REGISTER_CSS));
        private IWebElement Account => Waiters.FindAndWaitForElement(Driver, MainElement, By.CssSelector(ACCOUNT_CSS));
        private IWebElement ShoppingCart => Waiters.FindAndWaitForElement(Driver, MainElement, By.CssSelector(SHOPPING_CART_CSS));

        public string GetAccountText() => Account.Text;

        public RegistrationPage ClickOnRegister()
        {
            Register.Click();
            return new RegistrationPage(Driver);
        }

        public ShoppingCartPage ClickOnShoppingCart()
        {
            ShoppingCart.Click();
            return new ShoppingCartPage(Driver);
        }
    }
}
