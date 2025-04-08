using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunflowerInfrastructure
{
    public class Cart: ElementUser
    {
        private const string CART_NAME_CSS = ".product-name";
        public Cart(IWebDriver driver, IWebElement mainElement) : base(driver, mainElement) { }

        public string GetCartName => Waiters.FindAndWaitForElement(Driver, MainElement, By.CssSelector(CART_NAME_CSS)).Text;
    }
}
