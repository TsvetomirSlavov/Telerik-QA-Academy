using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace TILSTests.Pages
{
    public class ProfilePage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='PersonalSection']/div[3]/a[1]")]
        private IWebElement websiteValueField;

        [FindsBy(How = How.XPath, Using = "//*[@id='PersonalSection']/div[4]/span[2]")]
        private IWebElement genderValueField;

        [FindsBy(How = How.XPath, Using = "//*[@id='PersonalSection']/div[5]/span[2]")]
        private IWebElement townValueField;

        [FindsBy(How = How.XPath, Using = "//*[@id='PersonalSection']/div[6]/span[2]")]
        private IWebElement birthDateValueField;

        [FindsBy(How = How.XPath, Using = "//*[@id='PersonalSection']/div[8]/span[2]")]
        private IWebElement occupationValueField;

        [FindsBy(How = How.Id, Using = "AboutMe")]
        private IWebElement aboutMeValueField;

        [FindsBy(How = How.XPath, Using = "//*[@id='EducationSection']/div[1]/span[2]")]
        private IWebElement schoolValueField;

        [FindsBy(How = How.XPath, Using = "//*[@id='EducationSection']/div[2]/span[2]")]
        private IWebElement universityValueField;

        [FindsBy(How = How.XPath, Using = "//*[@id='EducationSection']/div[3]/span[2]")]
        private IWebElement facultyValueField;

        [FindsBy(How = How.XPath, Using = "//*[@id='EducationSection']/div[4]/span[2]")]
        private IWebElement specialtyValueField;

        [FindsBy(How = How.XPath, Using = "//*[@id='EducationSection']/div[5]/span[2]")]
        private IWebElement facultyNumberValueField;

        public IWebElement FacultyNumberValueField
        {
            get { return facultyNumberValueField; }
            set { facultyNumberValueField = value; }
        }

        public IWebElement SpecialtyValueField
        {
            get { return specialtyValueField; }
            set { specialtyValueField = value; }
        }

        public IWebElement FacultyValueField
        {
            get { return facultyValueField; }
            set { facultyValueField = value; }
        }

        public IWebElement UniversityValueField
        {
            get { return universityValueField; }
            set { universityValueField = value; }
        }

        public IWebElement SchoolValueField
        {
            get { return schoolValueField; }
            set { schoolValueField = value; }
        }

        public IWebElement AboutMeValueField
        {
            get { return aboutMeValueField; }
            set { aboutMeValueField = value; }
        }

        public IWebElement OccupationValueField
        {
            get { return occupationValueField; }
            set { occupationValueField = value; }
        }

        public IWebElement BirthDateValueField
        {
            get { return birthDateValueField; }
            set { birthDateValueField = value; }
        }

        public IWebElement TownValueField
        {
            get { return townValueField; }
            set { townValueField = value; }
        }

        public IWebElement GenderValueField
        {
            get { return genderValueField; }
            set { genderValueField = value; }
        }

        public IWebElement WebsiteValueField
        {
            get { return websiteValueField; }
            set { websiteValueField = value; }
        }

        public void IntitializeElements(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
    }
}
