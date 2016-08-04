using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumDemo.DriversExtensions;

namespace SeleniumDemo.Tests.UseCases
{
    public static class GivenAnyUser_WhenSearchesMADAMS
    {

        public static void ThenCanReachToPassengersInformation(IWebDriver driver)
        {
            driver.Navigate().GoToUrl(TestEnvironment.CmsBaseUrl);
            driver.FindElement(Pages.SearchFlight.TrypTypeCombo).Click();
            driver.WaitForElement(Pages.SearchFlight.TrypTypeReturnOption).Click();
            driver.WaitForElement(Pages.SearchFlight.OriginOptionMadrid).Click();
            driver.WaitForElement(Pages.SearchFlight.DestinationOptionAmsterdam).Click();
            driver.WaitForElement(Pages.SearchFlight.DateFrom24Option).Click();
            driver.WaitForElement(Pages.SearchFlight.DateTo26Option).Click();
            driver.WaitForElement(Pages.SearchFlight.PassengersDoneButton).Click();
            driver.FindElement(Pages.SearchFlight.FindFlightsButton).Click();
        }
    }
}
