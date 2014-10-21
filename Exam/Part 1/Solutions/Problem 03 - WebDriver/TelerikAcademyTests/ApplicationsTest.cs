using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using TelerikAcademyTests.Templates;
using TelerikAcademyTests.Pages;

namespace TelerikAcademyTests
{    
    [TestClass]
    public class ApplicationsTest : WebDriverTest
    {
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private string applicationPageUrl = @"http://test.telerikacademy.com/SoftwareAcademy/Candidate";

        [TestInitialize]
        public void InitializeTest()
        {
            this.Browser = new FirefoxDriver();
            this.BaseUrl = @"http://www.test.telerikacademy.com/";
            this.Wait = new WebDriverWait(this.Browser, TimeSpan.FromSeconds(10));
            this.TimeOut = 10;
            this.Browser.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
        }

        [TestCleanup]
        public void CleanupTest()
        {
            try
            {
                this.Browser.Quit();
            }
            catch (Exception exception)
            {
                logger.Error(exception.Message);
            }
        }

        [TestMethod]
        public void SubmitApplicationTest()
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Login(this.Browser);            

            this.Browser.Navigate().GoToUrl(this.applicationPageUrl);
            ApplicationPage applicationPage = new ApplicationPage();
            applicationPage.Apply(this.Browser);

            // MANUALLY CLEAR THE SUBMITTED APPLICATION
        }
    }
}
