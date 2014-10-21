namespace QA.TILS.Modules.Users.Core.Pages.AdminPage.UsersPage.FilterUsersPopUp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using QA.Framework.Core.Base;

    public class FilterUsersPopUpElements : BaseElementsMap
    {
        public FilterUsersPopUpElements(FilterUsersPopUp filterUsersPopUp)
        {
            this.FilterUsersPopUp = filterUsersPopUp;
        }

        public FilterUsersPopUp FilterUsersPopUp { get; private set; }


    }
}
