using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;


namespace TelerikAcademyWebDriver.Advanced.TelerikAcademy.ElementMaps
{
    class CandidateAdminPanelPage
    {
        [FindsBy(How = How.Name, Using = "email")]
        public IWebElement DeleteCandidateInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='QaTestingTool']/form/fieldset/input[2]")]
        public IWebElement DeleteCandidateButton { get; set; }

        [FindsBy(How = How.Id, Using = "DataGrid")]
        public IWebElement TableGrid { get; set; } 
    }
}
