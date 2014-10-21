namespace QA.TILS.Modules.Users.Tests.Front
{
    using ArtOfTest.WebAii.Core;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using QA.Framework.Core.Base;
    using QA.Framework.Core.Helpers;
    using QA.TILS.Modules.Users.Core.Pages.RegistrationPage;
    using QA.TILS.Modules.Users.Core.Pages.Common;
    using QA.Framework.Core.Data;

    /// <summary>
    /// Summary description for AccessToMaterials
    /// </summary>
    [TestClass]
    public class Registration : BaseTest
    {
        private RegistrationPage registrationPage;

        public override void TestInitialize()
        {
            this.registrationPage = new RegistrationPage();
            this.Browser.ClearCache(BrowserCacheType.Cookies);
            this.Browser.Refresh();
        }

        [TestMethod]
        public void RegistrationLink_ShouldNavigateCorrectly()
        {
            NavigateTo.Url("http://test.telerikacademy.com/");
            var notLoggedNavigationPanel = new NotLoggedUpperNavigationElements();
            notLoggedNavigationPanel.SignUpButton.Click();
            this.Browser.WaitForUrl(this.registrationPage.Url, false, 3000);
            Assert.IsTrue(this.Browser.Url == this.registrationPage.Url);
        }

        [TestMethod]
        public void RegisterValidUser_ShouldProceedWithoutErrors()
        {
            var username = this.registrationPage.RegisterUniqueUser(TestUsers.TestRegistrationUser);
            this.registrationPage.VerifySuccessfulRegistration(username);
        }

        [TestMethod]
        public void RegisterUserWithEmptyFields_ShouldResultAnErrorMessages()
        {
            this.registrationPage.RegisterUser(string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
            this.registrationPage.Validator.VerifyEmptyFieldsImmediateErrorMessages();
            this.registrationPage.Validator.VerifyEmptyFieldsSummaryErrorMessages();
        }
    }
}
