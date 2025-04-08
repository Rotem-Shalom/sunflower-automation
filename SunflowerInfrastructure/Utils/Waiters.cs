using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SunflowerInfrastructure
{
    public static class Waiters
    {
        public static IWebElement FindAndWaitForElement(IWebDriver driver, By by, int timeoutInSeconds = 10)
        {
            return FindElementWithWait(driver, by, timeoutInSeconds);
        }

        public static List<IWebElement> FindAndWaitForElements(IWebDriver driver, By by, int timeoutInSeconds = 10)
        {
            return FindElementsWithWait(driver, by, timeoutInSeconds);
        }

        public static IWebElement FindAndWaitForElement(IWebDriver driver, IWebElement mainElement, By by, int timeoutInSeconds = 10)
        {
            return FindElementWithWait(driver, by, timeoutInSeconds);
        }

        public static List<IWebElement> FindAndWaitForElements(IWebDriver driver, IWebElement mainElement, By by, int timeoutInSeconds = 10)
        {
            return FindElementsWithWait(driver, by, timeoutInSeconds);
        }

        private static List<IWebElement> FindElementsWithWait(IWebDriver driver, By by, int timeoutInSeconds = 10)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            return wait.Until(d =>
            {
                try
                {
                    var elements = d.FindElements(by);
                    return elements.Count > 0 ? elements.ToList() : null;
                }
                catch (NoSuchElementException)
                {
                    return null;
                }
            });
        }

        private static IWebElement FindElementWithWait(IWebDriver driver, By by, int timeoutInSeconds = 10)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            return wait.Until(d =>
            {
                try
                {
                    var element = d.FindElement(by);
                    return element != null ? element : null;
                }
                catch (NoSuchElementException)
                {
                    return null;
                }
            });
        }
    }
}
