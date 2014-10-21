namespace QA.TILS.Modules.Users.Core.Pages.ForgottenPasswordPage
{
    using ArtOfTest.Common.UnitTesting;
    using ArtOfTest.WebAii.Core;
    using QA.Framework.Core.Base;

    public class ForgottenPasswordPageValidator : BasePageValidator
    {
        public ForgottenPasswordPage ForgottenPasswordPage
        {
            get
            {
                return new ForgottenPasswordPage();
            }
        }

        public void VerifyUrl()
        {
            Assert.AreEqual(this.ForgottenPasswordPage.Url, Manager.Current.ActiveBrowser.Url);
        }
    }
}
