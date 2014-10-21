using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArtOfTest.WebAii.Core;

namespace QA.TestingFramework.Core
{
    [TestClass]
    public class BaseTest
    {
        [TestInitialize]
        public void CoreTestInit()
        {
            this.InitializeBrowser();
            this.CoreTestInit();
        }

        protected virtual void TestInit(){

        }

        [TestCleanup]
        public void CoreTestCleanup()
        {
            this.DisposeBrowser();
            this.CoreTestCleanup();
        }

        private void DisposeBrowser()
        {

        }

        private void InitializeBrowser()
        {
            Settings mySettings = new Settings();
            mySettings.Web.DefaultBrowser = BrowserType.InternetExplorer;
            mySettings.UnexpectedDialogAction = UnexpectedDialogAction.HandleAndContinue;

            var manager = new Manager(mySettings);
            manager.Start();

            manager.LaunchNewBrowser();
        }
    }
}
