using OpenQA.Selenium;
using SunflowerInfrastructure.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunflowerInfrastructure
{
    public class DigitalDownloadsPage: DriverUser
    {
        private string PRODUCT_GRID_CSS = ".product-grid";
        public DigitalDownloadsPage(IWebDriver driver) : base(driver) { }
        public ProductGrid GetProductGrid => new ProductGrid(Driver, Driver.FindElement(By.CssSelector(PRODUCT_GRID_CSS)));

    }
}
