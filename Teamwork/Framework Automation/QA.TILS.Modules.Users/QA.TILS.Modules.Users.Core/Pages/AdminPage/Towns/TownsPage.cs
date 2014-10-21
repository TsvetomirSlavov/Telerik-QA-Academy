using QA.Framework.Core.Base;

namespace QA.TILS.Modules.Users.Core.Pages.AdminPage.Towns
{
    public class TownsPage : BasePage
    {
        private const string FullUrl = "http://test.telerikacademy.com/Administration_Users/Provinces";

        public TownsPage()
        {
            this.Validator = new TownsPageValidator(this);
            this.Elements = new TownsPageElements();
            this.Url = FullUrl;
        }

        public TownsPageValidator Validator { get; private set; }

        public TownsPageElements Elements { get; private set; }

    }
}
