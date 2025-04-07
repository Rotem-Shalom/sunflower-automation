using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class WebshopBrowser : DriverUser
    {
        private string CONTAINER_CSS = "#container.ytd-masthead";
        private string PANEL = "#guide-content";

        public WebshopBrowser(IWebDriver driver) : base(driver)
        {
            Driver.Navigate().GoToUrl("https://www.youtube.com/");
        }

        public ControlPanel GetContainerPanel()
        {
            return new ControlPanel(Driver, Driver.FindElement(By.CssSelector(CONTAINER_CSS)));
        }

        public bool IsElementExist()
        {
            try
            {
                Driver.FindElement(By.CssSelector(PANEL));
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public void CloseDriver()
        {
            Driver.Close();
        }
    }
}
