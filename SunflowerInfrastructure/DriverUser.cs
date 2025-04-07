using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunflowerInfrastructure
{
    public class DriverUser
    {
        protected IWebDriver Driver { get; private set; }
        protected Actions Actions { get; set; }

        public DriverUser(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}
