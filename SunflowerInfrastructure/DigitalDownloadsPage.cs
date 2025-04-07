using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunflowerInfrastructure
{
    public class DigitalDownloadsPage: ElementUser
    {
        private string PRODUCT_CSS = ".product-item";
        public DigitalDownloadsPage(IWebDriver driver, IWebElement mainElement) : base(driver, mainElement) { }
        private List<Product> Products => MainElenent.FindElements(By.CssSelector(PRODUCT_CSS)).Select(product => new Product(Driver, product)).ToList();

        public string CliclOnAddToCardInRandomProduct()
        {
            Product product = Products.FirstOrDefault();
            product.ClickOnAddToCart();
            return product.GetProductName;
        }
    }
}
