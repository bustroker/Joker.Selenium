using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDemo
{
    public static class RemoteDriverFactory
    {
        private const string WebDriverRemoteServerUrl = "http://localhost:4444/wd/hub";

        public static IWebDriver CreateDriver(DriverType browserType)
        {
            switch (browserType)
            {
                case DriverType.Firefox:
                    return CreateFirefox();

                case DriverType.Chrome:
                    return CreateChrome();

                case DriverType.IE10:
                    return CreateIE();

                default:
                    var errorMessage = string.Format("Inknown browserType = '{0}'", browserType.ToString());
                    throw new ArgumentOutOfRangeException(errorMessage);
            }
        }

        private static IWebDriver CreateFirefox()
        {
            var platform = new Platform(PlatformType.Windows);
            var desiredCapabilities = new DesiredCapabilities("firefox", null, platform);
            var browser = new RemoteWebDriver(new Uri(WebDriverRemoteServerUrl), desiredCapabilities);
            return browser;
        }

        private static IWebDriver CreateChrome()
        {
            var platform = new Platform(PlatformType.Windows);
            var desiredCapabilities = new DesiredCapabilities("chrome", null, platform);
            var browser = new RemoteWebDriver(new Uri(WebDriverRemoteServerUrl), desiredCapabilities);
            return browser;
        }

        private static IWebDriver CreateIE()
        {
            var platform = new Platform(PlatformType.Windows);
            var desiredCapabilities = new DesiredCapabilities("internet explorer", null, platform);
            var browser = new RemoteWebDriver(new Uri(WebDriverRemoteServerUrl), desiredCapabilities);
            return browser;
        }
    }
}
