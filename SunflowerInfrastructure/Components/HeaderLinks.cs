using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunflowerInfrastructure
{
    public class HeaderLinks : ElementUser
    {
        private const string REGISTER_CSS = ".ico-register";
        private const string ACCOUNT_CSS = ".account";
        private const string SHOPPING_CART_CSS = ".header-links #topcartlink";
        public HeaderLinks(IWebDriver driver, IWebElement mainElement) : base(driver, mainElement) { }

        private IWebElement Register => MainElement.FindElement(By.CssSelector(REGISTER_CSS));
        private IWebElement Account => Driver.FindElement(By.CssSelector(ACCOUNT_CSS));
        private IWebElement ShoppingCart => Driver.FindElement(By.CssSelector(SHOPPING_CART_CSS));

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
