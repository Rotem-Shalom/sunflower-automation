using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class DriverUser
    {
        protected IWebDriver Driver { get; private set; }
        protected IJavaScriptExecutor JsExecutor { get; }
        protected Actions Actions { get; set; }

        public DriverUser(IWebDriver driver)
        {
            Driver = driver;
            JsExecutor = (IJavaScriptExecutor)Driver;
        }

        protected void SetDriver(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}
