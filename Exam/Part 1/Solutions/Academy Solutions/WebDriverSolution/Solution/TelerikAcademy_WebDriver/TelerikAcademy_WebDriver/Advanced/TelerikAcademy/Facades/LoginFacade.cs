using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;
using TelerikAcademyWebDriver.Advanced.TelerikAcademy.ElementMaps;

namespace TelerikAcademyWebDriver.Advanced.TelerikAcademy.Facades
{
    public class LoginFacade
    {
        public void Login(IWebDriver browser, string userName, string password)
        {
            LoginPage loginPage = new LoginPage();
            PageFactory.InitElements(browser, loginPage);
            loginPage.LoginButton.Click();           
            loginPage.UserName.SendKeys(userName);
            loginPage.Password.SendKeys(password);
            loginPage.SubmitButton.Click();
        }
    }
}
