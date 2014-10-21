using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace _09___Telerik_Testing_Framework.Steps
{
    [Binding]
    public class WebBasedCalculatorSteps
    {
        private Manager Manager { get; set; }
        private Browser Browser { get; set; }
        private HtmlTable Calculator { get; set; }
        public HtmlInputText CalculatorResult { get; set; }

        public WebBasedCalculatorSteps()
        {
            this.Manager = Hooks.CalculatorHooks.WebTestsManager;
            this.Browser = this.Manager.ActiveBrowser;
        }

        [Given(@"I have navigated to the web calc's webpage")]
        public void GivenIHaveNavigatedToTheWebCalcSWebpage()
        {
            this.Browser.NavigateTo("http://www.webestools.com/ftp/ybouane/scripts_tutorials/javascript/calculator/calculator.html");

            this.Browser.WaitUntilReady();
            this.Browser.RefreshDomTree();

            this.Calculator = this.Browser.Find.ById<HtmlTable>("calc");
            this.CalculatorResult = this.Calculator.Find.ById<HtmlInputText>("calc_result");
        }

        [When(@"I press (.*)")]
        public void PressCalculatorButton(string buttonValue)
        {
            this.Calculator.Find.ByXPath<HtmlInputButton>("//*[@value='" + buttonValue + "']").Click();
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(string expectedResult)
        {
            string actualResult = this.CalculatorResult.Text;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCleanup]
        public void CleanUp()
        {
            this.Browser.Close();
            this.Manager.Dispose();
        }
    }
}
