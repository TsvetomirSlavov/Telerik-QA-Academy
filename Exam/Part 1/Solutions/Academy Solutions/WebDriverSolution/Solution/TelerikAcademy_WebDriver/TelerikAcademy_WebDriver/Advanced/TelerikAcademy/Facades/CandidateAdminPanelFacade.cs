using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using TelerikAcademyWebDriver.Advanced.TelerikAcademy.ElementMaps;

namespace TelerikAcademyWebDriver.Advanced.TelerikAcademy.Facades
{
    class CandidateAdminPanelFacade
    {
        public void VerifyCandidate(IWebDriver browser)
        {
            CandidateAdminPanelPage candidatePage = new CandidateAdminPanelPage();
            PageFactory.InitElements(browser, candidatePage);
            var bodyInnerHtml = candidatePage.TableGrid.Text;
            bool containsCandidate = bodyInnerHtml.Contains("ageorgieva");
            Assert.IsFalse(containsCandidate, "there is ageorgieva in the grid");
        }

        public void DeleteCandidate(IWebDriver browser, string email)
        {
            CandidateAdminPanelPage candidatePage = new CandidateAdminPanelPage();
            PageFactory.InitElements(browser, candidatePage);
            candidatePage.DeleteCandidateInput.SendKeys(email);
            candidatePage.DeleteCandidateButton.Click();
        }
    }
}