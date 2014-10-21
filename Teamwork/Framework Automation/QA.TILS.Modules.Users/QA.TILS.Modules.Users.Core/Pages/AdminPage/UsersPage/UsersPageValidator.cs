namespace QA.TILS.Modules.Users.Core.Pages.AdminPage.UsersPage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class UsersPageValidator
    {
        public UsersPageValidator(UsersPage usersPage)
        {
            this.UsersPage = usersPage;
        }

        public UsersPage UsersPage { get; private set; }
    }
}
