namespace QA.TILS.Modules.Users.Core.Pages.AdminPage.UsersPage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    using QA.Framework.Core.Base;
    using QA.Framework.Core.Helpers;

    public class UsersPage : BasePage
    {
        public UsersPage()
        {
            this.Validator = new UsersPageValidator(this);
            this.Elements = new UsersPageElements();
            this.Url = "http://test.telerikacademy.com/Administration_Users/Users";
        }

        public UsersPageValidator Validator { get; private set; }

        public UsersPageElements Elements { get; private set; }

        public void OpenFilteringPopUp()
        {
            NavigateTo.Page(this);
        }

        public void DeleteUser(string username)
        {
            var userDeleteButton = this.Elements.DeleteUserButton(username);
            userDeleteButton.Click();
        }
    }
}
