namespace QA.TILS.Modules.Users.Tests.Admin.Users
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using QA.Framework.Core.Base;
    using QA.Framework.Core.Helpers;
    using QA.TILS.Modules.Users.Core.Pages.AdminPage.UsersPage;
    using QA.TILS.Modules.Users.Core.SharedSteps;

    [TestClass]
    public class Users : BaseTest
    {
        private UsersPage usersPage;

        public override void TestInitialize()
        {
            this.usersPage = new UsersPage();

            LoginSteps.LoginAdmin();
            NavigateTo.Page(this.usersPage);
            this.Browser.WaitUntilReady();
        }

        [TestMethod]
        public void DeleteUserFuction_ShouldDeleteUsersSuccessfully()
        {
            usersPage.DeleteUser("Test225809102014");
        }
    }
}
