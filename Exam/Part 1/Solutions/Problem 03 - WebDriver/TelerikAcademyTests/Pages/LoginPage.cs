using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;

namespace TelerikAcademyTests.Pages
{
    public class LoginPage
    {
        private string loginPageUrl = @"http://test.telerikacademy.com/Users/Auth/Login";

        [FindsBy(How = How.Id, Using = "UsernameOrEmail")]
        private IWebElement usernameOrEmailField;

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/section/form/fieldset/input")]
        private IWebElement signInButton;

        [FindsBy(How = How.Id, Using = "Password")]
        private IWebElement passwordField;

        public IWebElement UsernameOrEmailField
        {
            get { return usernameOrEmailField; }
            set { usernameOrEmailField = value; }
        }

        public IWebElement PasswordField
        {
            get { return passwordField; }
            set { passwordField = value; }
        }

        public IWebElement SignInButton
        {
            get { return signInButton; }
            set { signInButton = value; }
        }

        public void Login(IWebDriver driver, string usernameOrEmail = "lhranov", string password = "oloriN!01")
        {
            PageFactory.InitElements(driver, this);

            try
            {
                IWebElement logoutButton = driver.FindElement(By.Id("ExitMI"));
                logoutButton.Click();
            }
            catch
            {

            }

            driver.Navigate().GoToUrl(this.loginPageUrl);

            this.UsernameOrEmailField.Clear();
            this.UsernameOrEmailField.SendKeys(usernameOrEmail);

            this.PasswordField.Clear();
            this.PasswordField.SendKeys(password);

            this.SignInButton.Click();

            Thread.Sleep(3000);
        }
    }
}
