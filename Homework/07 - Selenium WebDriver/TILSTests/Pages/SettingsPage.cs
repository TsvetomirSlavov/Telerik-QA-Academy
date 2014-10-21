using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace TILSTests.Pages
{
    public class SettingsPage
    {
        [FindsBy(How = How.Id, Using = "FirstNameEn")]
        private IWebElement firstNameInEnglishField;

        [FindsBy(How = How.Id, Using = "LastNameEn")]
        private IWebElement lastNameInEnglishField;

        [FindsBy(How = How.Id, Using = "BirthDay")]
        private IWebElement birthDateField;

        [FindsBy(How = How.Id, Using = "MaleRadioBtn")]
        private IWebElement maleRadioButton;

        [FindsBy(How = How.Id, Using = "FemaleRadioBtn")]
        private IWebElement femaleRadioButton;

        [FindsBy(How = How.Id, Using = "UnknownRadioBtn")]
        private IWebElement unknownRadioButton;

        [FindsBy(How = How.Name, Using = "CityId_input")]
        private IWebElement townDropdown;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section/form/fieldset[2]/div[16]/span[1]/span/span[1]")]
        private IWebElement occupationDropdown;

        [FindsBy(How = How.Id, Using = "Phone")]
        private IWebElement phoneField;

        [FindsBy(How = How.Id, Using = "About")]
        private IWebElement aboutField;

        [FindsBy(How = How.Name, Using = "UniversityId_input")]
        private IWebElement universityDropdown;

        [FindsBy(How = How.Id, Using = "FacultyName")]
        private IWebElement facultyField;

        [FindsBy(How = How.Id, Using = "UniversitySpeciality")]
        private IWebElement universitySpecialityField;

        [FindsBy(How = How.Id, Using = "FacultyNumber")]
        private IWebElement facultyNumberField;

        [FindsBy(How = How.Id, Using = "SchoolName")]
        private IWebElement schoolNameField;

        [FindsBy(How = How.Id, Using = "Website")]
        private IWebElement websiteField;

        [FindsBy(How = How.Id, Using = "SkypeUsername")]
        private IWebElement skypeUsernameField;

        [FindsBy(How = How.Id, Using = "FacebookUrl")]
        private IWebElement facebookUrlField;

        [FindsBy(How = How.Id, Using = "GooglePlusUrl")]
        private IWebElement googlePlusUrlField;

        [FindsBy(How = How.Id, Using = "LinkedInUrl")]
        private IWebElement linkedInUrlField;

        [FindsBy(How = How.Id, Using = "TwitterUrl")]
        private IWebElement twitterUrlField;

        [FindsBy(How = How.Id, Using = "GitHubUrl")]
        private IWebElement gitHubUrlField;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section/form/div[2]/input")]
        private IWebElement saveChangesButton;

        public IWebElement SaveChangesButton
        {
            get { return saveChangesButton; }
            set { saveChangesButton = value; }
        }

        public IWebElement GitHubUrlField
        {
            get { return gitHubUrlField; }
            set { gitHubUrlField = value; }
        }

        public IWebElement TwitterUrlField
        {
            get { return twitterUrlField; }
            set { twitterUrlField = value; }
        }

        public IWebElement LinkedInUrlField
        {
            get { return linkedInUrlField; }
            set { linkedInUrlField = value; }
        }

        public IWebElement GooglePlusUrlField
        {
            get { return googlePlusUrlField; }
            set { googlePlusUrlField = value; }
        }

        public IWebElement FacebookUrlField
        {
            get { return facebookUrlField; }
            set { facebookUrlField = value; }
        }

        public IWebElement SkypeUsernameField
        {
            get { return skypeUsernameField; }
            set { skypeUsernameField = value; }
        }

        public IWebElement WebsiteField
        {
            get { return websiteField; }
            set { websiteField = value; }
        }

        public IWebElement SchoolNameField
        {
            get { return schoolNameField; }
            set { schoolNameField = value; }
        }

        public IWebElement FacultyNumberField
        {
            get { return facultyNumberField; }
            set { facultyNumberField = value; }
        }

        public IWebElement UniversitySpecialityField
        {
            get { return universitySpecialityField; }
            set { universitySpecialityField = value; }
        }

        public IWebElement FacultyField
        {
            get { return facultyField; }
            set { facultyField = value; }
        }

        public IWebElement UniversityDropdown
        {
            get { return universityDropdown; }
            set { universityDropdown = value; }
        }

        public IWebElement AboutField
        {
            get { return aboutField; }
            set { aboutField = value; }
        }

        public IWebElement PhoneField
        {
            get { return phoneField; }
            set { phoneField = value; }
        }

        public IWebElement OccupationDropdown
        {
            get { return occupationDropdown; }
            set { occupationDropdown = value; }
        }

        public IWebElement TownDropdown
        {
            get { return townDropdown; }
            set { townDropdown = value; }
        }

        public IWebElement UnknownRadioButton
        {
            get { return unknownRadioButton; }
            set { unknownRadioButton = value; }
        }

        public IWebElement MaleRadioButton
        {
            get { return maleRadioButton; }
            set { maleRadioButton = value; }
        }

        public IWebElement FemaleRadioButton
        {
            get { return femaleRadioButton; }
            set { femaleRadioButton = value; }
        }

        public IWebElement BirthDateField
        {
            get { return birthDateField; }
            set { birthDateField = value; }
        }

        public IWebElement LastNameInEnglishField
        {
            get { return lastNameInEnglishField; }
            set { lastNameInEnglishField = value; }
        }

        public IWebElement FirstNameInEnglishField
        {
            get { return firstNameInEnglishField; }
            set { firstNameInEnglishField = value; }
        }

        public void ChangeInfo(string firstNameInEnglish, string lastNameInEnglish, string birthDate, bool isMale, string town, string occupation, string mobilePhone, string aboutMe, string university, string facultyName, string universitySpecialty, string facultyNumber, string schoolName, string website, string skypeName, string facebookUrl, string googlePlusUrl, string linkedInUrl, string twitterUrl, string gitHubUrl, IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);

            this.FirstNameInEnglishField.Clear();
            this.FirstNameInEnglishField.SendKeys(firstNameInEnglish);

            this.LastNameInEnglishField.Clear();
            this.LastNameInEnglishField.SendKeys(lastNameInEnglish);

            this.birthDateField.Clear();
            this.birthDateField.SendKeys(birthDate);

            if (isMale)
            {
                this.MaleRadioButton.Click();
            }
            else
            {
                this.FemaleRadioButton.Click();
            }

            this.TownDropdown.Clear();
            this.TownDropdown.SendKeys(town);

            this.OccupationDropdown.SendKeys(occupation);

            this.PhoneField.Clear();
            this.PhoneField.SendKeys(mobilePhone);

            this.AboutField.Clear();
            this.AboutField.SendKeys(aboutMe);

            this.UniversityDropdown.Clear();
            this.UniversityDropdown.SendKeys(university);

            this.FacultyField.Clear();
            this.FacultyField.SendKeys(facultyName);

            this.UniversitySpecialityField.Clear();
            this.UniversitySpecialityField.SendKeys(universitySpecialty);

            this.facultyNumberField.Clear();
            this.FacultyNumberField.SendKeys(facultyNumber);

            this.SchoolNameField.Clear();
            this.SchoolNameField.SendKeys(schoolName);

            this.WebsiteField.Clear();
            this.WebsiteField.SendKeys(website);

            this.SkypeUsernameField.Clear();
            this.SkypeUsernameField.SendKeys(skypeName);

            this.FacebookUrlField.Clear();
            this.FacebookUrlField.SendKeys(facebookUrl);

            this.GooglePlusUrlField.Clear();
            this.GooglePlusUrlField.SendKeys(googlePlusUrl);

            this.LinkedInUrlField.Clear();
            this.LinkedInUrlField.SendKeys(linkedInUrl);

            this.TwitterUrlField.Clear();
            this.TwitterUrlField.SendKeys(twitterUrl);

            this.GitHubUrlField.Clear();
            this.GitHubUrlField.SendKeys(gitHubUrl);

            this.SaveChangesButton.Click();
        }
    }
}
