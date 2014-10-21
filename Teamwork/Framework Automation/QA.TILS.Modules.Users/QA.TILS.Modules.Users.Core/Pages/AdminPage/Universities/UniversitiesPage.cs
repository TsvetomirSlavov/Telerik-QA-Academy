using QA.Framework.Core.Base;
using QA.TILS.Modules.Users.Core.Pages.AdminPage.Roles;

namespace QA.TILS.Modules.Users.Core.Pages.AdminPage.Universities
{
    public class UniversitiesPage : BasePage
    {
        private const string FullUrl = "http://test.telerikacademy.com/Administration_Users/Universities";

        public UniversitiesPage()
        {
            this.Validator = new UniversitiesPageValidator(this);
            this.Elements = new UniversitiesPageElements();
            this.Url = FullUrl;
        }

        public UniversitiesPageValidator Validator { get; private set; }

        public UniversitiesPageElements Elements { get; private set; }

    }
}
