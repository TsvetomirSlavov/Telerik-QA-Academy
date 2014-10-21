namespace Homework
{
    using System;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support;
    using OpenQA.Selenium.Support.PageObjects;
    using OpenQA.Selenium.Firefox;
    using OpenQA.Selenium.Support.UI;
    using System.Collections.Generic;
    using System.Threading;

    public class EntryPoint
    {
        private static IWebDriver driver;
        private static WebDriverWait wait;

        static void Main(string[] args)
        {
            driver = new FirefoxDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));

            LoginToTelerik();
            TestProfile();
            DisableJS();
            DeleteCookies();

            driver.Quit();
        }

        private static void DeleteCookies()
        {
            driver.Manage().Cookies.DeleteAllCookies();
        }

        private static void DisableJS()
        {
            FirefoxProfile driverProfile = new FirefoxProfile();
            driverProfile.SetPreference("javascript.enabled", false);
            driver = new FirefoxDriver(driverProfile);

            Console.WriteLine("JavaScript has been disabled");
        }

        private static void TestProfile()
        {
            driver.Navigate().GoToUrl(@"https://www.telerik.com/account/profile.aspx");

            IWebElement nicknameField = driver.FindElement(By.Id("ctl00_ctl00_GeneralBox_Content_usercontrols_public_unitedaccount_client_editprofile_ascx1_scetbNick_tbSanitized"));
            IWebElement firstNameField = driver.FindElement(By.Id("ctl00_ctl00_GeneralBox_Content_usercontrols_public_unitedaccount_client_editprofile_ascx1_scetbFirstName_tbSanitized"));
            IWebElement lastNameField = driver.FindElement(By.Id("ctl00_ctl00_GeneralBox_Content_usercontrols_public_unitedaccount_client_editprofile_ascx1_scetbLastName_tbSanitized"));
            IWebElement companyNameField = driver.FindElement(By.Id("ctl00_ctl00_GeneralBox_Content_usercontrols_public_unitedaccount_client_editprofile_ascx1_scetbCompanyName_tbSanitized"));
            IWebElement updateProfileButton = driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_GeneralBox_Content_usercontrols_public_unitedaccount_client_editprofile_ascx1_lbUpdate']"));

            nicknameField.Clear();
            nicknameField.SendKeys("QA Academy");

            firstNameField.Clear();
            firstNameField.SendKeys("Asya");

            lastNameField.Clear();
            lastNameField.SendKeys("Georgieva");

            companyNameField.Clear();

            try
            {
                IWebElement blankCompanyError = wait.Until(d => d.FindElement(By.XPath("//*[@id='ctl00_ctl00_GeneralBox_Content_usercontrols_public_unitedaccount_client_editprofile_ascx1_scetbCompanyName_rfvSanitizedControl']/strong")));

                Console.WriteLine("SUCCESS: Error message for blank company is present");
            }
            catch
            {
                Console.WriteLine("ERROR: Error message for blank company is NOT present");
            }

            companyNameField.SendKeys(DataGenerator.GenerateRandomString(5, 15));

            updateProfileButton.Click();

            try
            {
                IWebElement updateSuccess = wait.Until(d => d.FindElement(By.XPath("//*[@id='ctl00_ctl00_GeneralBox_Content_usercontrols_public_unitedaccount_client_editprofile_ascx1_panelSuccess']")));

                Console.WriteLine("SUCCESS: Profile has been saved");
            }
            catch
            {
                Console.WriteLine("ERROR: Profile has NOT been saved");
            }
        }

        private static void LoginToTelerik()
        {
            driver.Navigate().GoToUrl(@"http://www.telerik.com/account");

            IWebElement usernameField = driver.FindElement(By.Id("username"));
            IWebElement passwordField = driver.FindElement(By.Id("password"));
            IWebElement loginButton = driver.FindElement(By.Id("LoginButton"));

            usernameField.SendKeys("a4117721@trbvm.com");
            passwordField.SendKeys("12345");
            loginButton.Click();

            IWebElement supportLink = wait.Until(d => d.FindElement(By.LinkText("Support")));
        }
    }
}
