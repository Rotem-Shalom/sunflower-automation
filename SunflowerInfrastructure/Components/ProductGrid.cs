using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace SunflowerInfrastructure.Components
{
    public class ProductGrid : ElementUser
    {
        private const string PRODUCT_CSS = ".product-item";

        public ProductGrid(IWebDriver driver, IWebElement mainElement) : base(driver, mainElement) { }

        public List<Product> GetProducts => Driver.FindElements(By.CssSelector(PRODUCT_CSS)).Select(product => new Product(Driver, product)).ToList();

        public Product GetFirstProduct() => GetProducts.FirstOrDefault();

    }
}
