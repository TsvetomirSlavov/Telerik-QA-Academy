using System.Threading;

namespace QA.TILS.Modules.Users.Tests.Admin.Universities
{
    using ArtOfTest.WebAii.Core;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.Framework.Core.Base;
    using QA.Framework.Core.Helpers;
    using QA.TILS.Modules.Users.Core.Pages.AdminPage.Universities;
    using QA.TILS.Modules.Users.Core.SharedSteps;

    [TestClass]
    public class AddUniversity : BaseTest
    {
        private UniversitiesPage universitiesPage;
        private const string ValidName = "УАСГ-proba";
        private const string ValidWebSite = "http://uacg.bg/";
        private const string ValidOrder = "101";

        public override void TestInitialize()
        {
            this.universitiesPage = new UniversitiesPage();

            this.Browser.ClearCache(BrowserCacheType.Cookies);
            this.Browser.Refresh();
        }

        [TestMethod]
        public void AddNewUniversityWithValidData()
        {
            LoginSteps.LoginAdmin();
            NavigateTo.Url(this.universitiesPage.Url);
            this.universitiesPage.Elements.AnchorAddNewTown.Click();
            this.universitiesPage.Elements.Name.Text = ValidName;
            this.universitiesPage.Elements.Website.Text = ValidWebSite;
            //   this.universitiesPage.Elements.Order.Text = ValidOrder;
            Thread.Sleep(10000);
            this.Browser.RefreshDomTree();
            this.universitiesPage.Elements.UpdateButton.Click();
            var text = this.Browser.ViewSourceString;

            bool result = text.Contains(ValidName);

            Assert.IsTrue(result);

        }
    }
}
