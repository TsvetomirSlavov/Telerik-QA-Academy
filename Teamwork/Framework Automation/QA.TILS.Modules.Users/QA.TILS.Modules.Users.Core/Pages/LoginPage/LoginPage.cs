namespace QA.TILS.Modules.Users.Core.Pages.LoginPage
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using QA.Framework.Core.Base;
    using QA.Framework.Core.Data.Templates;
    using QA.Framework.Core.Helpers;

    public class LoginPage : BasePage
    {
        public LoginPage()
        {
            this.Elements = new LoginPageElements();
            this.Validator = new LoginPageValidator();
            this.Url = "http://test.telerikacademy.com/Users/Auth/Login";
        }

        public LoginPageElements Elements { get; set; }

        public LoginPageValidator Validator { get; set; }

        public void Login(string username, string password)
        {
            NavigateTo.Page(this);

            this.Elements.UsernameField.Text = username;
            this.Elements.PasswordField.Text = password;

            this.Elements.LoginButton.Click();
        }

        public void Login(User user)
        {
            this.Login(user.Username, user.Password);
        }
    }
}
