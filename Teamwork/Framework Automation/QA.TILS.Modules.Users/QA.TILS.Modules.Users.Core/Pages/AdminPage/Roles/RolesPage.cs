using QA.Framework.Core.Base;
using QA.TILS.Modules.Users.Core.Pages.AdminPage.Towns;

namespace QA.TILS.Modules.Users.Core.Pages.AdminPage.Roles
{
    public class RolesPage : BasePage
    {
        private const string FullUrl = "http://test.telerikacademy.com/Administration_Users/Roles";

        public RolesPage()
        {
            this.Validator = new RolesPageValidator(this);
            this.Elements = new RolesPageElements();
            this.Url = FullUrl;
        }

        public RolesPageValidator Validator { get; private set; }

        public RolesPageElements Elements { get; private set; }

    }
}
