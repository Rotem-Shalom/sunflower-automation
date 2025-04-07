using OpenQA.Selenium;
using SunflowerInfrastructure.Components;

namespace SunflowerInfrastructure
{
    public class DigitalDownloadsPage : DriverUser
    {
        private const string PRODUCT_GRID_CSS = ".product-grid";
        public DigitalDownloadsPage(IWebDriver driver) : base(driver) { }
        public ProductGrid GetProductGrid => new ProductGrid(Driver, Driver.FindElement(By.CssSelector(PRODUCT_GRID_CSS)));
    }
}
