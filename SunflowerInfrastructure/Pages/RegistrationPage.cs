using OpenQA.Selenium;
using SunflowerInfrastructure.Components;
using SunflowerInfrastructure.Inputs;
using SunflowerInfrastructure.Utils.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunflowerInfrastructure
{
    public class RegistrationPage : DriverUser
    {
        private string REGISTER_CSS = ".registration-page";

        public RegistrationPage(IWebDriver driver) : base(driver) { }

        public Register GetRegister=> new Register(Driver, Driver.FindElement(By.CssSelector(REGISTER_CSS)));

    }
}
