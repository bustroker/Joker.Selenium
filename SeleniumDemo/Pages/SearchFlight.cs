using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDemo
{
    public class SearchFlight
    {
        public By Origin
        {
            get
            {
                return By.Id("OriginCity");
            }
        }

        public By TrypTypeCombo
        {
            get
            {
                return By.XPath("(//button[@type='button'])[7]");
            }
        }

        public By TrypTypeReturnOption
        {
            get
            {
                return By.CssSelector("a.js-flight-search-bar-forced-click.data-value-1 > span.text");
            }
        }

        public By OriginOptionMadrid
        {
            get
            {
                return By.LinkText("Madrid (MAD)");
            }
        }

        public By DestinationOptionAmsterdam
        {
            get
            {
                return By.XPath("(//a[contains(text(),'Amsterdam (AMS)')])[2]");
            }
        }

        public By DateFrom24Option
        {
            get
            {
                return By.LinkText("24");
            }
        }

        public By DateTo26Option
        {
            get
            {
                return By.LinkText("26");
            }
        }

        public By PassengersDoneButton
        {
            get
            {
                return By.XPath("(//button[@type='button'])[12]");
            }
        }

        public By FindFlightsButton
        {
            get
            {
                return By.Id("submit-booking-search-flight");
            }
        }
    }
}
