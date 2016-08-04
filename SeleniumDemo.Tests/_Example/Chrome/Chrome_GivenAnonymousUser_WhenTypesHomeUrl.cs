using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeleniumDemo.Tests._Example
{
    [TestClass]
    public class Chrome_GivenAnonymousUser_WhenTypesHomeUrl : ChromeBaseTest
    {
        [TestMethod]
        public void Chrome_GivenAnonymousUser_WhenTypesHomeUrl_ThenHomePageLoadsCorrectly()
        {
            GivenAnonymousUser_WhenTypesHomeUrl.ThenHomePageLoadsCorrectly(ChromeDriver);
        }
    }
}
