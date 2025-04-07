using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunflowerInfrastructure
{
    public class ShoppingCartPage : ElementUser
    {
        private string CART_CSS = ".cart-item-row";

        public ShoppingCartPage(IWebDriver driver, IWebElement mainElement) : base(driver, mainElement) { }
        private List<Cart> Carts => MainElenent.FindElements(By.CssSelector(CART_CSS)).Select(cart => new Cart(Driver, cart)).ToList();

        public string GetFirsCartName()
        {
            return Carts.FirstOrDefault().GetCartName;
        }
    }
}
