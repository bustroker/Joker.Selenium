using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDemo.DriversExtensions
{
    public static class WaitForElementExtension
    {
        private const int DefaultWaitTimeInSeconds = 10;
        public static IWebElement WaitForElement(this IWebDriver target, By by)
        {
            var wait = new WebDriverWait(target, TimeSpan.FromSeconds(DefaultWaitTimeInSeconds));
            var element = wait.Until(x => x.FindElement(by));
            return element;
        }
    }
}
