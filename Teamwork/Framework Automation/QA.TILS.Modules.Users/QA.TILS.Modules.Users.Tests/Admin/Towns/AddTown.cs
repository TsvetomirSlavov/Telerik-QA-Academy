namespace QA.TILS.Modules.Users.Tests.Admin.Towns
{
    using ArtOfTest.WebAii.Core;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.Framework.Core.Base;
    using QA.Framework.Core.Helpers;
    using QA.TILS.Modules.Users.Core.Pages.AdminPage.Towns;
    using QA.TILS.Modules.Users.Core.SharedSteps;

    [TestClass]
    public class AddTown : BaseTest
    {

        public TownsPage TownsPage;
        private const string ValidNameBulgarian = "фсдфсдф";
        private const string ValidNameEnglish = "asdsad";

        public override void TestInitialize()
        {
            this.TownsPage = new TownsPage();

            this.Browser.ClearCache(BrowserCacheType.Cookies);
            this.Browser.Refresh();
        }

        [TestMethod]
        public void AddTownWithValidData()
        {
            LoginSteps.LoginAdmin();
            NavigateTo.Url(this.TownsPage.Url);
            // this.Browser.RefreshDomTree();
            //this.TownsPage.Elements.AnchorAddNewTown.Wait.ForExists(5000);
            this.TownsPage.Elements.AnchorAddNewTown.Click();
            this.TownsPage.Elements.NameBulgarian.Text = ValidNameBulgarian;
            this.TownsPage.Elements.NameEnglish.Text = ValidNameEnglish;
            this.TownsPage.Elements.UpdateButton.Click();

            var text = this.Browser.ViewSourceString;

            bool result = text.Contains(ValidNameBulgarian);

            Assert.IsTrue(result);
        }
    }
}

