namespace TILSTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support;
    using OpenQA.Selenium.Support.PageObjects;
    using TILSTests.Pages;
    using OpenQA.Selenium.Firefox;
    using OpenQA.Selenium.Support.UI;
    using System.Collections.Generic;

    [TestClass]
    public class UserInfoTest
    {
        private string academyStartPageUrl = @"http://test.telerikacademy.com/";
        private string userSettingsUrl = @"http://test.telerikacademy.com/Users/Profile/Settings";

        private IWebDriver driver;
        private LoginPage loginPage;
        private ProfilePage profilePage;
        private SettingsPage settingsPage;

        public UserInfoTest()
        {
            this.driver = new FirefoxDriver();
            this.loginPage = new LoginPage();
            this.profilePage = new ProfilePage();
            this.settingsPage = new SettingsPage();
            this.driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(2));
        }

        [TestCleanup]
        public void TestCleanup()
        {
            this.driver.Quit();
        }

        [TestMethod]
        public void FillInSettingsWithValidInfo()
        {
            string username = "lyubenTest";
            string password = "123456";

            this.driver.Navigate().GoToUrl(this.academyStartPageUrl);

            this.loginPage.Login(this.driver, username, password);

            string firstNameInEnglish = "FirstName";
            string lastNameInEnglish = "LastName";
            string birthDate = "22/02/1976";
            bool isMale = true;
            string town = "София";
            string occupation = "Ученик";
            string mobilePhone = "0888123456";
            string aboutMe = "Some info";
            string university = "Университет в чужбина";
            string facultyName = "Finance and Trade";
            string universitySpecialty = "Accounting";
            string facultyNumber = "12345678";
            string schoolName = "Some School";
            string website = "me.org";
            string skypeName = "mySkype";
            string facebookUrl = "facebook.com/myFacebook";
            string googlePlusUrl = "plus.google.com/myGooglePlus";
            string linkedInUrl = @"linkedin.com/myLinkedIn";
            string twitterUrl = "twitter.com/meTwitter";
            string gitHubUrl = "github.com/myGitHub";

            this.driver.Navigate().GoToUrl(this.userSettingsUrl);

            this.settingsPage.ChangeInfo(firstNameInEnglish, lastNameInEnglish, birthDate, isMale, town, occupation, mobilePhone, aboutMe, university, facultyName, universitySpecialty, facultyNumber, schoolName, website, skypeName, facebookUrl, googlePlusUrl, linkedInUrl, twitterUrl, gitHubUrl, this.driver);

            IWebElement settingsSavedSuccessfully = null;

            try 
	        {
                settingsSavedSuccessfully = this.driver.FindElement(By.Id("SuccessfullySavedSettingsMessageBox"));
	        }
	        catch
	        {
	        }

            Assert.IsNotNull(settingsSavedSuccessfully, "Setting were not saved");

            this.driver.Navigate().GoToUrl(@"http://test.telerikacademy.com/Users/" + username);

            this.profilePage.IntitializeElements(this.driver);

            Assert.AreEqual(this.profilePage.WebsiteValueField.Text, @"http://" + website, "Website has not been saved correctly");
            Assert.AreEqual(this.profilePage.GenderValueField.Text, isMale ? "Мъж" : "Жена", "Gender has not been saved correctly");
            Assert.AreEqual(this.profilePage.TownValueField.Text, town, "Town has not been saved correctly");
            Assert.AreEqual(this.profilePage.BirthDateValueField.Text, birthDate, "Birth date has not been saved correctly");
            Assert.AreEqual(this.profilePage.OccupationValueField.Text, occupation, "Occupation has not been saved correctly");
            Assert.AreEqual(this.profilePage.AboutMeValueField.Text, "За мен: " + aboutMe, "About has not been saved correctly");
            Assert.AreEqual(this.profilePage.SchoolValueField.Text, schoolName, "School has not been saved correctly");
            Assert.AreEqual(this.profilePage.UniversityValueField.Text, university, "University has not been saved correctly");
            Assert.AreEqual(this.profilePage.FacultyValueField.Text, facultyName, "Faculty name has not been saved correctly");
            Assert.AreEqual(this.profilePage.SpecialtyValueField.Text, universitySpecialty, "Specialty has not been saved correctly");
            Assert.AreEqual(this.profilePage.FacultyNumberValueField.Text, facultyNumber, "Faculty number has not been saved correctly");
        }
    }
}
