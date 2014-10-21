namespace QA.TILS.Modules.Users.Tests.Front
{
    using ArtOfTest.WebAii.Core;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.Framework.Core.Base;
    using QA.Framework.Core.Data;
    using QA.Framework.Core.Helpers;
    using QA.TILS.Modules.Users.Core.Pages.ForgottenPasswordPage;
    using QA.TILS.Modules.Users.Core.Pages.LoginPage;

    [TestClass]
    public class Login : BaseTest
    {
        public LoginPage LoginPage;
        public ForgottenPasswordPage ForgottenPasswordPage;

        public override void TestInitialize()
        {
            this.LoginPage = new LoginPage();
            this.ForgottenPasswordPage = new ForgottenPasswordPage();

            this.Browser.ClearCache(BrowserCacheType.Cookies);
            this.Browser.Refresh();
        }

        [TestMethod]
        public void Login_With_Blank_Credentials_Should_Fail()
        {
            this.LoginPage.Login("", "");

            this.LoginPage.Validator.VerifyErrorMessageOnInvalidLogin();
        }

        [TestMethod]
        public void Login_With_Valid_Username_And_Invalid_Password_Should_Fail()
        {
            this.LoginPage.Login(TestUsers.TestUser1.Username, "invalidPassword");

            this.LoginPage.Validator.VerifyErrorMessageOnInvalidLogin();
        }

        [TestMethod]
        public void Login_With_Valid_Credentials_Is_Successfull()
        {
            this.LoginPage.Login(TestUsers.TestUser1);

            this.LoginPage.Validator.VerifySuccessfullLogin(TestUsers.TestUser1.Username);
        }

        [TestMethod]
        public void Forgotten_Password_Link_Should_Navigate_To_The_Correct_Page()
        {
            NavigateTo.Page(this.LoginPage);

            this.LoginPage.Elements.ForgottenPasswordLink.Click();
            this.Browser.WaitUntilReady();

            this.ForgottenPasswordPage.Validator.VerifyUrl();
        }
    }
}
