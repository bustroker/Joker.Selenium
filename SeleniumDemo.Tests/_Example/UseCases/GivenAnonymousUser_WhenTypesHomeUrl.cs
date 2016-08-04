using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace SeleniumDemo.Tests._Example
{
    public static class GivenAnonymousUser_WhenTypesHomeUrl
    {
        public static void ThenHomePageLoadsCorrectly(IWebDriver driver)
        {
            // copiado del código generado
            driver.Navigate().GoToUrl(TestEnvironment.CmsBaseUrl);
            driver.Title.Should().Be("Iberiaexpress");
        }
    }
}
