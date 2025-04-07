using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunflowerInfrastructure.Components
{
    public class ProductGrid : ElementUser
    {
        private string PRODUCT_CSS = ".product-item";
        public ProductGrid(IWebDriver driver, IWebElement mainElement) : base(driver, mainElement) { }
        public List<Product> GetProducts => Driver.FindElements(By.CssSelector(PRODUCT_CSS)).Select(product => new Product(Driver, product)).ToList();
        public Product GetFirstProduct() => GetProducts.FirstOrDefault();

    }
}
