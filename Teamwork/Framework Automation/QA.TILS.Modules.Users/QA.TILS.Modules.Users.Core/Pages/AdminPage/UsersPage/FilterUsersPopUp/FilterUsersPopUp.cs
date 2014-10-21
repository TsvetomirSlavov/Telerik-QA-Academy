namespace QA.TILS.Modules.Users.Core.Pages.AdminPage.UsersPage.FilterUsersPopUp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class FilterUsersPopUp
    {
        public FilterUsersPopUp()
        {
            this.Elements = new FilterUsersPopUpElements(this);
            this.Validators = new FilterUsersPopUpValidators();
            
        }

        public FilterUsersPopUpElements Elements { get; private set; }

        public FilterUsersPopUpValidators Validators { get; private set; }
    }
}
