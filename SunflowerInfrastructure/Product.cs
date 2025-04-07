using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunflowerInfrastructure
{
    public class Product: ElementUser
    {
        private string ADD_TO_CART_BUTTON_CSS = ".product-box-add-to-cart-button";
        private string PRODUCT_NAME_CSS = ".product-title";
        public Product(IWebDriver driver, IWebElement mainElement) : base(driver, mainElement) { }
        private IWebElement AddToCartButton => MainElenent.FindElement(By.CssSelector(ADD_TO_CART_BUTTON_CSS));
        public string GetProductName => MainElenent.FindElement(By.CssSelector(PRODUCT_NAME_CSS)).Text;

        public void ClickOnAddToCart()
        {
            AddToCartButton.Click();
        }
    }
}
