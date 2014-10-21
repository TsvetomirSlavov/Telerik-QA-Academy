namespace QA.TILS.Modules.Users.Tests.Admin.Roles
{
    using ArtOfTest.WebAii.Core;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.Framework.Core.Base;
    using QA.Framework.Core.Helpers;
    using QA.TILS.Modules.Users.Core.Pages.AdminPage.Roles;
    using QA.TILS.Modules.Users.Core.SharedSteps;


    [TestClass]
    public class AddRole : BaseTest
    {
        private const string VadlidName = "SomeRole";
        private RolesPage rolesPage;
        public override void TestInitialize()
        {
            this.rolesPage = new RolesPage();
            this.Browser.ClearCache(BrowserCacheType.Cookies);
            this.Browser.Refresh();
        }
      
        [TestMethod]
        public void AddRoleWithValidData()
        {
            LoginSteps.LoginAdmin();
            NavigateTo.Url(this.rolesPage.Url);
            this.rolesPage.Elements.AnchorAddNewRole.Click();
            this.rolesPage.Elements.Name.Text = VadlidName;
            this.rolesPage.Elements.UpdateButton.Click();

            var text = this.Browser.ViewSourceString;

            bool result = text.Contains(VadlidName);

            Assert.IsTrue(result);
        }
    }
}
