using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.PhantomJS;
using TelerikAcademyWebDriver.Advanced.TelerikAcademy.Facades;
using System.Threading;

namespace TelerikAcademyWebDriver
{
    [TestClass]
    public class Tests : BaseWebDriverTest
    {
        private readonly string academyLink = @"http://test.telerikacademy.com/";

        [TestMethod]
        public void ApplayForSortwareAcademy()
        {
            this.Browser.Navigate().GoToUrl(academyLink);

            LoginFacade loginFacade = new LoginFacade();
            loginFacade.Login(this.Browser, "ageorgieva", "{password}");

            ApplyForAcademyFacade applyFacade = new ApplyForAcademyFacade();
            applyFacade.NavigateToTheApplyingForm(this.Browser);
            applyFacade.PopulatePersonalData(this.Browser);
            applyFacade.PopulateAdditionalQuestions(this.Browser);
            applyFacade.PopulateDocuments(this.Browser);
            applyFacade.SubmitForm(this.Browser);
        }

        [TestMethod]
        public void VerifyAndDeleteCandidate()
        {
            this.Browser.Navigate().GoToUrl(academyLink);

            var loginFacade = new LoginFacade();
            loginFacade.Login(Browser, "ageorgieva", "{password}");
            this.Browser.Navigate().GoToUrl(string.Concat(academyLink, "Administration_SoftwareAcademy/Candidates"));
         
            var candidateFasade = new CandidateAdminPanelFacade();
            candidateFasade.VerifyCandidate(Browser);
            candidateFasade.DeleteCandidate(Browser, "adsa@asdas.bg");
            candidateFasade.VerifyCandidate(Browser);
        }
    }
}