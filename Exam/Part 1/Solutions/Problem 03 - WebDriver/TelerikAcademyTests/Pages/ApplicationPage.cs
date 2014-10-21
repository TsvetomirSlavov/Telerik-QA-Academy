using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;

namespace TelerikAcademyTests.Pages
{
    public class ApplicationPage
    {

        [FindsBy(How = How.Id, Using = "FirstName")]
        private IWebElement firstName;

        [FindsBy(How = How.Id, Using = "SecondName")]
        private IWebElement middleName;

        [FindsBy(How = How.Id, Using = "LastName")]
        private IWebElement lastName;

        [FindsBy(How = How.XPath, Using = "//*[@id='IsMale_True']")]
        private IWebElement maleRadioButton;

        [FindsBy(How = How.XPath, Using = "//*[@id='PersonalData']/div[8]/span[1]/span/span[1]")]
        private IWebElement occupationDropdown;
      
        [FindsBy(How = How.Id, Using = "BirthDay")]
        private IWebElement birthDateField;

        [FindsBy(How = How.Id, Using = "Email")]
        private IWebElement emailAddress;

        [FindsBy(How = How.Id, Using = "Phone")]
        private IWebElement phoneNumber;

        [FindsBy(How = How.XPath, Using = "//*[@id='PersonalData']/div[16]/span[1]/span/span[1]")]
        private IWebElement city;

        [FindsBy(How = How.XPath, Using = "//*[@id='PersonalData']/div[18]/span[1]/span/span[1]")]
        private IWebElement university;

        [FindsBy(How = How.Id, Using = "SchoolName")]
        private IWebElement school;

        [FindsBy(How = How.Id, Using = "Question_1")]
        private IWebElement whyProgrammingQuestionField;

        [FindsBy(How = How.Id, Using = "Question_2")]
        private IWebElement forHowLongInterestQuestion;

        public IWebElement FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public IWebElement MiddleName
        {
            get { return middleName; }
            set { middleName = value; }
        }

        public IWebElement LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        [FindsBy(How = How.Id, Using = "Question_3")]
        private IWebElement howMuchTimeForAcademyQuestion;

        [FindsBy(How = How.Id, Using = "Question_4")]
        private IWebElement howMuchTimeForEngeneerQuestion;

        [FindsBy(How = How.Id, Using = "Question_5")]
        private IWebElement whatDoYouKnowAboutAcademyQuestion;

        public IWebElement WhatDoYouKnowAboutAcademyQuestion
        {
            get { return whatDoYouKnowAboutAcademyQuestion; }
            set { whatDoYouKnowAboutAcademyQuestion = value; }
        }

        public IWebElement ForHowLongInterestQuestion
        {
            get { return forHowLongInterestQuestion; }
            set { forHowLongInterestQuestion = value; }
        }

        public IWebElement HowMuchTimeForAcademyQuestion
        {
            get { return howMuchTimeForAcademyQuestion; }
            set { howMuchTimeForAcademyQuestion = value; }
        }

        [FindsBy(How = How.Id, Using = "Answer_1")]
        private IWebElement whyApplyAnswerCheckbox;

        [FindsBy(How = How.Id, Using = "Answer_9")]
        private IWebElement whatWillYouGetFromAcademyAnswer;

        public IWebElement WhatWillYouGetFromAcademyAnswer
        {
            get { return whatWillYouGetFromAcademyAnswer; }
            set { whatWillYouGetFromAcademyAnswer = value; }
        }

        [FindsBy(How = How.Id, Using = "Answer_16")]
        private IWebElement whatDoYouRelateAcademyWithAnswer;

        public IWebElement WhatDoYouRelateAcademyWithAnswer
        {
            get { return whatDoYouRelateAcademyWithAnswer; }
            set { whatDoYouRelateAcademyWithAnswer = value; }
        }

        [FindsBy(How = How.Id, Using = "Answer_24")]
        private IWebElement howDidYouFindOutAboutTheAcademy;

        public IWebElement HowDidYouFindOutAboutTheAcademy
        {
            get { return howDidYouFindOutAboutTheAcademy; }
            set { howDidYouFindOutAboutTheAcademy = value; }
        }

        [FindsBy(How = How.Id, Using = "Answer_39")]
        private IWebElement haveYouAppliedBeforeAnswer;

        public IWebElement HaveYouAppliedBeforeAnswer
        {
            get { return haveYouAppliedBeforeAnswer; }
            set { haveYouAppliedBeforeAnswer = value; }
        }

        [FindsBy(How = How.Id, Using = "Answer_42")]
        private IWebElement whatDoYouRelateTelerikWith;

        [FindsBy(How = How.Id, Using = "CV")]
        private IWebElement submitCVButton;

        [FindsBy(How = How.Id, Using = "CoverLetter")]
        private IWebElement submitCoverLetterButton;

        [FindsBy(How = How.Id, Using = "AcceptTerms")]
        private IWebElement acceptTermsCheckbox;

        [FindsBy(How = How.Id, Using = "SendButton")]
        private IWebElement sendApplicationButton;

        [FindsBy(How = How.Id, Using = "Picture")]
        private IWebElement uploadPictureButton;

        public IWebElement UploadPictureButton
        {
            get { return uploadPictureButton; }
            set { uploadPictureButton = value; }
        }

        public IWebElement SendApplicationButton
        {
            get { return sendApplicationButton; }
            set { sendApplicationButton = value; }
        }
        

        public IWebElement AcceptTermsCheckbox
        {
            get { return acceptTermsCheckbox; }
            set { acceptTermsCheckbox = value; }
        }
        

        public IWebElement SubmitCoverLetterButton
        {
            get { return submitCoverLetterButton; }
            set { submitCoverLetterButton = value; }
        }

        public IWebElement SubmitCVButton
        {
            get { return submitCVButton; }
            set { submitCVButton = value; }
        }
        

        public IWebElement WhatDoYouRelateTelerikWith
        {
            get { return whatDoYouRelateTelerikWith; }
            set { whatDoYouRelateTelerikWith = value; }
        }

        public IWebElement WhyApplyAnswerCheckbox
        {
            get { return whyApplyAnswerCheckbox; }
            set { whyApplyAnswerCheckbox = value; }
        }


        public IWebElement HowMuchTimeForEngeneerQuestion
        {
            get { return howMuchTimeForEngeneerQuestion; }
            set { howMuchTimeForEngeneerQuestion = value; }
        }

        public IWebElement WhyProgrammingQuestionField
        {
            get { return whyProgrammingQuestionField; }
            set { whyProgrammingQuestionField = value; }
        }


        public IWebElement School
        {
            get { return school; }
            set { school = value; }
        }
        

        public IWebElement University
        {
            get { return university; }
            set { university = value; }
        }
        

        public IWebElement City
        {
            get { return city; }
            set { city = value; }
        }
        

        public IWebElement EmailAddress
        {
            get { return emailAddress; }
            set { emailAddress = value; }
        }

        public IWebElement PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }


        public IWebElement BirthDateField
        {
            get { return birthDateField; }
            set { birthDateField = value; }
        }

        public IWebElement OccupationDropdown
        {
            get { return occupationDropdown; }
            set { occupationDropdown = value; }
        }

        public IWebElement MaleRadioButton
        {
            get { return maleRadioButton; }
            set { maleRadioButton = value; }
        }


        public void Apply(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);

            this.FirstName.Clear();
            this.FirstName.SendKeys("Любен");

            this.MiddleName.Clear();
            this.MiddleName.SendKeys("Николаев");

            this.LastName.Clear();
            this.LastName.SendKeys("Хранов");

            this.MaleRadioButton.Click();

            this.BirthDateField.Clear();
            this.BirthDateField.SendKeys("24/03/1987");

            this.EmailAddress.Clear();
            this.EmailAddress.SendKeys("lyuben.hranov@gmail.com");

            this.PhoneNumber.Clear();
            this.PhoneNumber.SendKeys("0899091974");

            //this.City.Clear();
            this.City.SendKeys("София");

            //this.University.Clear();
            this.University.SendKeys("Университет в чужбина");

            this.School.Clear();
            this.School.SendKeys("University of Portsmouth");

            this.WhyProgrammingQuestionField.Clear();
            this.WhyProgrammingQuestionField.SendKeys("Finding a better job");

            this.ForHowLongInterestQuestion.Clear();
            this.ForHowLongInterestQuestion.SendKeys("Since three years");

            this.HowMuchTimeForAcademyQuestion.Clear();
            this.HowMuchTimeForAcademyQuestion.SendKeys("8 hours a day");

            this.HowMuchTimeForEngeneerQuestion.Clear();
            this.HowMuchTimeForEngeneerQuestion.SendKeys("8 hours a day");

            this.WhatDoYouKnowAboutAcademyQuestion.Clear();
            this.WhatDoYouKnowAboutAcademyQuestion.SendKeys("One of the best places to learn how to code");

            if (!this.WhyApplyAnswerCheckbox.Selected)
            {
                this.WhyApplyAnswerCheckbox.Click();                
            }

            if (!this.WhatWillYouGetFromAcademyAnswer.Selected)
            {
                this.WhatWillYouGetFromAcademyAnswer.Click();
            }

            if (!this.WhatDoYouRelateAcademyWithAnswer.Selected)
            {
                this.WhatDoYouRelateAcademyWithAnswer.Click();
            }

            if (!this.HowDidYouFindOutAboutTheAcademy.Selected)
            {
                this.HowDidYouFindOutAboutTheAcademy.Click();
            }            

            this.HaveYouAppliedBeforeAnswer.Click();

            if (!this.WhatDoYouRelateTelerikWith.Selected)
            {
                this.WhatDoYouRelateTelerikWith.Click();
            }            

            this.SubmitCVButton.SendKeys(@"C:\cv.pdf");
            this.SubmitCoverLetterButton.SendKeys(@"C:\coverLetter.pdf");
            this.UploadPictureButton.SendKeys(@"C:\avatar.jpg");

            this.AcceptTermsCheckbox.Click();

            this.SendApplicationButton.Click();

            Thread.Sleep(6000);
        }
    }
}
