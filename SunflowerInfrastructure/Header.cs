using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunflowerInfrastructure
{
    public class Header : ElementUser
    {
        private string REGISTER_CSS = ".ico-register";
        private string REGISTERATION_PAGE_CSS = ".registration-page";
        private string ACCOUNT_CSS = ".account";
        private string SHOPPING_CART_CSS = ".header-links #topcartlink";
        private string SHOPPING_CART_PAGE_CSS = ".shopping-cart-page";
        public Header(IWebDriver driver, IWebElement mainElement) : base(driver, mainElement) { }
        private IWebElement Register => MainElenent.FindElement(By.CssSelector(REGISTER_CSS));
        private IWebElement RegisterationPage => Driver.FindElement(By.CssSelector(REGISTERATION_PAGE_CSS));
        private IWebElement Account => Driver.FindElement(By.CssSelector(ACCOUNT_CSS));
        private IWebElement ShoppingCart => Driver.FindElement(By.CssSelector(SHOPPING_CART_CSS));
        private IWebElement ShoppingCartPage => Driver.FindElement(By.CssSelector(SHOPPING_CART_PAGE_CSS));

        public RegisterationPage ClickOnRegister()
        {
            Register.Click();
            return new RegisterationPage(Driver, RegisterationPage);
        }

        public ShoppingCartPage ClickOnShoppingCart()
        {
            ShoppingCart.Click();
            return new ShoppingCartPage(Driver, ShoppingCartPage);
        }

        public string GetAccountText()
        {
            return Account.Text;
        }
    }
}
