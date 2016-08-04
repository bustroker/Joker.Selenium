using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDemo
{
    public static class LocalDriverFactory
    {
        private const string ChromeDriverFileName = "chromedriver.exe";
        private const string IE10DriverFileName = "";

        public static IWebDriver CreateDriver(DriverType browserType)
        {
            switch (browserType)
            {
                case DriverType.Firefox:
                    return CreateFirefox();

                case DriverType.Chrome:
                    return CreateChrome();

                case DriverType.IE10:
                    return CreateIE10();

                default:
                    var errorMessage = string.Format("Inknown browserType = '{0}'", browserType.ToString());
                    throw new ArgumentOutOfRangeException(errorMessage);
            }
        }

        private static IWebDriver CreateFirefox()
        {
            var browser = new FirefoxDriver(DesiredCapabilities.Firefox());
            return browser;
        }

        private static IWebDriver CreateChrome()
        {
            var browser = new ChromeDriver(GetDriversDirectoryPath());
            return browser;
        }

        private static IWebDriver CreateIE10()
        {
            var browser = new InternetExplorerDriver(GetDriversDirectoryPath());
            return browser;
        }

        private static string GetDriversDirectoryPath()
        {
            try
            {
                var currentDirectory = Directory.GetCurrentDirectory();
                var currentDirectoryInfo = new DirectoryInfo(currentDirectory);
                var testsProjectDirectory = currentDirectoryInfo.Parent.Parent;
                var driversDirectory = testsProjectDirectory.GetDirectories("drivers").Single();
                var driversDirectoryPath = driversDirectory.FullName;
                return driversDirectoryPath;
            }
            catch (Exception ex)
            {
                var errorMessage = @"Failed trying to find drivers directory path: slnFolder\lib\drivers";
                throw new DirectoryNotFoundException(errorMessage, ex);
            }
        }

    }
}
