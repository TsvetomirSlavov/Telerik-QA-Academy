namespace QA.Framework.Core.Base
{
    using System;
    using ArtOfTest.WebAii.Core;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class BaseTest
    {
        private const string BaseUrl = "http://test.telerikacademy.com/";

        public Browser Browser
        {
            get
            {
                return Manager.Current.ActiveBrowser;
            }
        }

        public virtual void TestInitialize()
        {
        }

        public virtual void TestCleanUp()
        {
        }  

        [TestInitialize]
        public void CoreTestInitialize()
        {
            this.InitializeBrowser();
            this.TestInitialize();
        }

        [TestCleanup]
        public void CoreTestCleanup()
        {
            this.TestCleanUp();
            this.DisposeBrowser();
        }

        private void InitializeBrowser()
        {
            if (Manager.Current == null)
            {
                Settings mySettings = new Settings();

                mySettings.Web.KillBrowserProcessOnClose = true;
                mySettings.DisableDialogMonitoring = true;
                mySettings.UnexpectedDialogAction = UnexpectedDialogAction.HandleAndContinue;
                mySettings.Web.ExecutingBrowsers.Add(BrowserExecutionType.InternetExplorer);
                mySettings.Web.Browser = BrowserExecutionType.InternetExplorer;
                mySettings.Web.DefaultBrowser = BrowserType.InternetExplorer;
                //mySettings.Web.BaseUrl = BaseUrl;

                var myManager = new Manager(mySettings);
                myManager.Start();
            }

            Manager.Current.LaunchNewBrowser();
        }

        private void DisposeBrowser()
        {
            foreach (var browser in Manager.Current.Browsers)
            {
                browser.Close();
            }

            if (Manager.Current != null)
            {
                Manager.Current.Dispose();
            }
        }
    }
}
