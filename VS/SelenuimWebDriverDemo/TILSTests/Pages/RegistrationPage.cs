using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.PageObjects;

namespace TILSTests.Pages
{
    public class RegistrationPage
    {
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/section/form/fieldset/p/input")]
        private IWebElement registerButton;

        public IWebElement RegisterButton
        {
            get { return registerButton; }
            set { registerButton = value; }
        }

        [FindsBy(How = How.Id, Using = "Username")]
        private IWebElement usernameField;

        public IWebElement UsernameField
        {
            get { return usernameField; }
            set { usernameField = value; }
        }

        private IWebElement passwordField;

        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement PasswordField
        {
            get { return passwordField; }
            set { passwordField = value; }
        }

        [FindsBy(How = How.Id, Using = "PasswordAgain")]
        private IWebElement passwordAgainField;

        public IWebElement PasswordAgainField
        {
            get { return passwordAgainField; }
            set { passwordAgainField = value; }
        }

        [FindsBy(How = How.Id, Using = "FirstName")]
        private IWebElement firstNameField;

        public IWebElement FirstNameField
        {
            get { return firstNameField; }
            set { firstNameField = value; }
        }

        [FindsBy(How = How.Id, Using = "LastName")]
        private IWebDriver lastNameField;

        public IWebDriver LastNameField
        {
            get { return lastNameField; }
            set { lastNameField = value; }
        }

        [FindsBy(How = How.Id, Using = "Email")]
        private IWebElement emailField;

        public IWebElement EmailField
        {
            get { return emailField; }
            set { emailField = value; }
        }

        private IWebElement acceptCheckbox;

        [FindsBy(How = How.Id, Using = "TermsAndConditions")]
        public IWebElement AcceptCheckbox
        {
            get { return acceptCheckbox; }
            set { acceptCheckbox = value; }
        }
        
    }
}
