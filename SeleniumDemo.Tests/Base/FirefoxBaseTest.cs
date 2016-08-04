using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDemo.Tests
{
    public class FirefoxBaseTest 
    {
        protected IWebDriver FirefoxDriver;

        [TestInitialize]
        public void Initialize()
        {
            FirefoxDriver = LocalDriverFactory.CreateDriver(DriverType.Firefox);
        }

        [TestCleanup]
        public void CleanUp()
        {
            FirefoxDriver.Quit();
        }
    }
}
