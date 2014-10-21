namespace QA.TILS.Modules.Users.Core.Pages.RegistrationPage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using QA.Framework.Core.Base;
    using QA.Framework.Core.Data.Templates;
    using QA.Framework.Core.Extensions;
    using QA.Framework.Core.Helpers;
    using QA.TILS.Modules.Users.Core.Pages.Common;

    public class RegistrationPage : BasePage
    {
        public RegistrationPage()
        {
            this.Validator = new RegistrationPageValidator(this);
            this.Elements = new RegistrationPageElements();
            this.UpperNavigation = new LoggedUsersUpperNavigationElements();
            this.Url = @"http://test.telerikacademy.com/Users/Auth/Registration";
        }

        public RegistrationPageValidator Validator { get; private set; }

        public RegistrationPageElements Elements { get; private set; }

        public LoggedUsersUpperNavigationElements UpperNavigation { get; private set; }

        public void EnterUserCredentials(string username, string password, string firstNameBg, string lastNameBg, string email)
        {
            NavigateTo.Page(this);

            this.Elements.UsernameField.Text = username;
            this.Elements.PasswordField.Text = password;
            this.Elements.PasswordAgainField.Text = password;
            this.Elements.FirstNameInBulgarianField.Text = firstNameBg;
            this.Elements.LastNameInBulgarianField.Text = lastNameBg;
            this.Elements.EmailField.Text = email;
        }

        public void RegisterUser(string username, string password, string firstNameBg, string lastNameBg, string email)
        {
            this.EnterUserCredentials(username, password, firstNameBg, lastNameBg, email);
            this.Elements.TermsAndConditionsCheckBox.Click();
            this.Elements.SubmitButton.Click();
        }

        public void RegisterUser(User user)
        {
            this.RegisterUser(user.Username, user.Password, user.FirstNameInBulgarian, user.FirstNameInBulgarian, user.Email);
        }

        public string RegisterUniqueUser(User user)
        {
            var dateTime = DateTime.Now;
            string uniqueAddition = dateTime.ToString("hhmmddMMyyyy");
            this.RegisterUser(user.Username + uniqueAddition, user.Password, user.FirstNameInBulgarian, user.FirstNameInBulgarian, uniqueAddition + user.Email);
            return user.Username + uniqueAddition;
        }

        public void VerifySuccessfulRegistration(string expectedUsername)
        {
            this.UpperNavigation.LoggedUserUsernameSpan.Wait.ForExists();
            this.UpperNavigation.LoggedUserUsernameSpan.AssertTextEquals(expectedUsername);
        }
    }
}
