using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDemo.Tests
{
    public class ChromeBaseTest
    {
        protected IWebDriver ChromeDriver;

        [TestInitialize]
        public void Initialize()
        {
            ChromeDriver = LocalDriverFactory.CreateDriver(DriverType.Chrome);
        }

        [TestCleanup]
        public void CleanUp()
        {
            ChromeDriver.Quit();
        }
    }
}
