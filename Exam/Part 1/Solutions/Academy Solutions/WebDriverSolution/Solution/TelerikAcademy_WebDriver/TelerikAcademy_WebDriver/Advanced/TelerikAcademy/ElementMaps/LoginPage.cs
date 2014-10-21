using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;

namespace TelerikAcademyWebDriver.Advanced.TelerikAcademy.ElementMaps
{
    public class LoginPage
    {
        [FindsBy(How = How.Id, Using = "LoginButton")]
        public IWebElement LoginButton { get; set; }

        [FindsBy(How = How.Id, Using = "UsernameOrEmail")]
        public IWebElement UserName { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='MainContent']/form/fieldset/input")]
        public IWebElement SubmitButton { get; set; }
    }
}
