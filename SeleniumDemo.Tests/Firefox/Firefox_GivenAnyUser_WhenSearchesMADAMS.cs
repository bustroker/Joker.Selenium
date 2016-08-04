using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumDemo.Tests.UseCases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDemo.Tests.Firefox
{
    [TestClass]
    public class Firefox_GivenAnyUser_WhenSearchesMADAMS : FirefoxBaseTest
    {
        [TestMethod]
        public void Chrome_GivenAnyUser_WhenSearchesMADAMS_ThenCanReachToPassengersInformation()
        {
            GivenAnyUser_WhenSearchesMADAMS.ThenCanReachToPassengersInformation(FirefoxDriver);
        }
    }
}
