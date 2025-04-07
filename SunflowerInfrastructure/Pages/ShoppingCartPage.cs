using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunflowerInfrastructure
{
    public class ShoppingCartPage : DriverUser
    {
        private string CART_CSS = ".cart-item-row";

        public ShoppingCartPage(IWebDriver driver) : base(driver) { }
        private List<Cart> Carts => Driver.FindElements(By.CssSelector(CART_CSS)).Select(cart => new Cart(Driver, cart)).ToList();

        public string GetFirstCartName => Carts.FirstOrDefault().GetCartName;

    }
}
