using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunflowerInfrastructure.Inputs
{
    public class RadioInput : ElementUser
    {
        public RadioInput(IWebDriver driver, IWebElement mainElement) : base(driver, mainElement) { }

        public void SetInput()
        {
            MainElenent.Click();
        }

    }
}
