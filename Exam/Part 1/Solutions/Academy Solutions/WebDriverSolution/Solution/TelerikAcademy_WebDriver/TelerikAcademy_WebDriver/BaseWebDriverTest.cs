using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Text;
using System.Threading;
using TelerikAcademyWebDriver.Exceptions;

namespace TelerikAcademyWebDriver
{
    public class BaseWebDriverTest
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public void TestInit(IWebDriver driver, string baseUrl, int timeOut)
        {
            this.Browser = driver;
            this.BaseUrl = baseUrl;
            this.Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOut));
            this.TimeOut = timeOut;
        }

        [TestInitialize]
        public void SetupTest()
        {
            this.Browser = new FirefoxDriver();
            this.Browser.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(2));
            this.Browser.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(5));
            this.Wait = new WebDriverWait(this.Browser, TimeSpan.FromSeconds(10));
            this.TimeOut = 1000;
        }


        [TestCleanup]
        public void TeardownTest()
        {
            try
            {
                this.Browser.Quit();
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
            }
        }

        public IWebDriver Browser { get; set; }

        public StringBuilder VerificationErrors { get; set; }

        public string BaseUrl { get; set; }

        public WebDriverWait Wait { get; set; }

        public IWebElement CurrentElement { get; set; }

        public int TimeOut { get; set; }

        public IWebElement GetElement(By by)
        {
            IWebElement result = null;
            try
            {
                result = this.Wait.Until(x => x.FindElement(by));
            }
            catch (TimeoutException ex)
            {
                log.Error(ex.Message);
                throw new TelerikAcademyWebDriver.Exceptions.NoSuchElementException(by, this, ex);
            }

            return result;
        }

        public bool IsElementPresent(By by)
        {
            try
            {
                this.Browser.FindElement(by);
                return true;
            }
            catch (TelerikAcademyWebDriver.Exceptions.NoSuchElementException ex)
            {
                log.Error(ex.Message);
                return false;
            }
        }

        public void WaitForElementPresent(By by)
        {
            this.GetElement(by);
        }

        public void WaitForElementNotPresent(By by)
        {
            try
            {
                this.GetElement(by);
                throw new ElementStillVisibleException(by, this);
            }
            catch (TelerikAcademyWebDriver.Exceptions.NoSuchElementException ex)
            {
                log.Error(ex.Message);
                return;
            }
        }

        public void WaitForChecked(By by)
        {
            IWebElement currentElement = this.GetElement(by);
            bool isSelected = currentElement.Selected;

            if (!isSelected)
            {
                log.ErrorFormat("The element with find expression {0} was not checked.", by.ToString());
                throw new NotCheckedException(by, this);
            }
        }

        public void WaitForNotChecked(By by)
        {
            IWebElement currentElement = this.GetElement(by);
            bool isSelected = currentElement.Selected;

            if (!isSelected)
            {
                log.ErrorFormat("The element with find expression {0} was checked.", by.ToString());
                throw new StillCheckedException(by, this);
            }
        }

        public void WaitForText(By by, string textToFind)
        {
            IWebElement currentElement = this.GetElement(by);
            string elementText = currentElement.Text;

            if (!textToFind.Equals(elementText))
            {
                log.ErrorFormat("The following text: {0}\n was not found on the page.", textToFind);
                throw new TextNotFoundException(textToFind, this);
            }
        }
    }
}

