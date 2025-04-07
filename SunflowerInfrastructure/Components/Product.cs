using OpenQA.Selenium;

namespace SunflowerInfrastructure
{
    public class Product : ElementUser
    {
        private const string ADD_TO_CART_BUTTON_CSS = ".product-box-add-to-cart-button";
        private const string PRODUCT_NAME_CSS = ".product-title";
        public Product(IWebDriver driver, IWebElement mainElement) : base(driver, mainElement) { }

        private IWebElement AddToCartButton => MainElement.FindElement(By.CssSelector(ADD_TO_CART_BUTTON_CSS));

        public string GetProductName => MainElement.FindElement(By.CssSelector(PRODUCT_NAME_CSS)).Text;

        public void ClickOnAddToCart() => AddToCartButton.Click();
    }
}
