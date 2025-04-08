using OpenQA.Selenium;
using SunflowerInfrastructure.Components;

namespace SunflowerInfrastructure
{
    public class DigitalDownloadsPage : DriverUser
    {
        private const string PRODUCT_GRID_CSS = ".product-grid";
        public DigitalDownloadsPage(IWebDriver driver) : base(driver) { }
        private IWebElement ProductGrid => Waiters.FindAndWaitForElement(Driver, By.CssSelector(PRODUCT_GRID_CSS));
        public ProductGrid GetProductGrid => new ProductGrid(Driver, ProductGrid);
    }
}
