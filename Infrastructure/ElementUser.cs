using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class ElementUser : DriverUser
    {
        protected IWebElement MainElenent;
        public ElementUser(IWebDriver driver, IWebElement element) : base(driver)
        {
            MainElenent = element;
        }
    }
}
