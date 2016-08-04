using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class Generated
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;
        
        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "http://www.iberiaexpress.com/";
            verificationErrors = new StringBuilder();
        }
        
        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }
        
        [Test]
        public void TheGeneratedTest()
        {
            // open | /en/home | 
            driver.Navigate().GoToUrl(baseURL + "/en/home");
            // click | id=home-login-label | 
            driver.FindElement(By.Id("home-login-label")).Click();
            // type | id=club_login_email | luismesa
            driver.FindElement(By.Id("club_login_email")).Clear();
            driver.FindElement(By.Id("club_login_email")).SendKeys("luismesa");
            // type | id=club_login_email | luismesa@gmail.es
            driver.FindElement(By.Id("club_login_email")).Clear();
            driver.FindElement(By.Id("club_login_email")).SendKeys("luismesa@gmail.es");
            // type | id=club_login_pass | ñlasjdfñalskdjf
            driver.FindElement(By.Id("club_login_pass")).Clear();
            driver.FindElement(By.Id("club_login_pass")).SendKeys("ñlasjdfñalskdjf");
            // click | //input[@value='Start session'] | 
            driver.FindElement(By.XPath("//input[@value='Start session']")).Click();
            // assertText | //ul[@id='formMessagesContainer']/li[3] | The password you have entered is incorrect. Please try again.
            Assert.AreEqual("The password you have entered is incorrect. Please try again.", driver.FindElement(By.XPath("//ul[@id='formMessagesContainer']/li[3]")).Text);
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        
        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }
        
        private string CloseAlertAndGetItsText() {
            try {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert) {
                    alert.Accept();
                } else {
                    alert.Dismiss();
                }
                return alertText;
            } finally {
                acceptNextAlert = true;
            }
        }
    }
}
