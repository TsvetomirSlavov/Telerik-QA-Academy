using ArtOfTest.WebAii.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace _09___Telerik_Testing_Framework.Hooks
{
    [Binding]
    public static class CalculatorHooks
    {
        public static Manager WebTestsManager;

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            WebTestsManager = new Manager(false);

            WebTestsManager.Settings.ExecutionDelay = 500;
            WebTestsManager.Settings.Web.RecycleBrowser = true;

            WebTestsManager.Start();
        }

        [BeforeScenario]
        public static void BeforeScenario()
        {
            WebTestsManager.LaunchNewBrowser();
        }

        [AfterScenario]
        public static void AfterScenario()
        {
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            WebTestsManager.ActiveBrowser.Close();

            if (WebTestsManager != null)
            {
                WebTestsManager.Dispose();                
            }
        }
    }
}
