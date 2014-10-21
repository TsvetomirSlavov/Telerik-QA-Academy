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
    public class MOBILEBG
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;
        
        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "http://www.mobile.bg/";
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
        public void TheMOBILEBGTest()
        {
            driver.Navigate().GoToUrl(baseURL + "/");
            new SelectElement(driver.FindElement(By.Name("marka"))).SelectByText("Ford");
            driver.FindElement(By.XPath("//option[@value='Ford']")).Click();
            new SelectElement(driver.FindElement(By.Name("model"))).SelectByText("Fiesta");
            driver.FindElement(By.Name("price1")).Clear();
            driver.FindElement(By.Name("price1")).SendKeys("50000");
            new SelectElement(driver.FindElement(By.Name("year"))).SelectByText("след 2000");
            new SelectElement(driver.FindElement(By.Name("engine_t"))).SelectByText("Бензинов");
            driver.FindElement(By.Id("nup1")).Click();
            driver.FindElement(By.Id("button2")).Click();
            driver.FindElement(By.LinkText("2")).Click();
            // Warning: verifyTextPresent may require manual changes
            try
            {
                Assert.IsTrue(Regex.IsMatch(driver.FindElement(By.CssSelector("BODY")).Text, "^[\\s\\S]*4 900 лв\\.[\\s\\S]*$"));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.LinkText("exact:Ford Fiesta 1.4i*МН.ЗАПАЗЕНА")).Click();
            // Warning: verifyTextPresent may require manual changes
            try
            {
                Assert.IsTrue(Regex.IsMatch(driver.FindElement(By.CssSelector("BODY")).Text, "^[\\s\\S]*Ford Fiesta 1\\.4i[\\s\\S]*МН\\.ЗАПАЗЕНА[\\s\\S]*$"));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.XPath("//img[@alt='Ford Fiesta 1.4i*МН.ЗАПАЗЕНА']")).Click();
            // ERROR: Caught exception [ERROR: Unsupported command [waitForPopUp | 11369832163403765 | 30000]]
            // ERROR: Caught exception [ERROR: Unsupported command [selectWindow | name=11369832163403765 | ]]
            // Warning: verifyTextPresent may require manual changes
            try
            {
                Assert.IsTrue(Regex.IsMatch(driver.FindElement(By.CssSelector("BODY")).Text, "^[\\s\\S]*Ford Fiesta 1\\.4i[\\s\\S]*МН\\.ЗАПАЗЕНА[\\s\\S]*$"));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.XPath("//td[@id='pnext']/a/img")).Click();
            driver.FindElement(By.XPath("//td[@id='pnext']/a/img")).Click();
            driver.Close();
            // ERROR: Caught exception [ERROR: Unsupported command [selectWindow | null | ]]
            driver.FindElement(By.XPath("//img")).Click();
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
        
        private string CloseAlertAndGetItsText() {
            try {
                IAlert alert = driver.SwitchTo().Alert();
                if (acceptNextAlert) {
                    alert.Accept();
                } else {
                    alert.Dismiss();
                }
                return alert.Text;
            } finally {
                acceptNextAlert = true;
            }
        }
    }
}
