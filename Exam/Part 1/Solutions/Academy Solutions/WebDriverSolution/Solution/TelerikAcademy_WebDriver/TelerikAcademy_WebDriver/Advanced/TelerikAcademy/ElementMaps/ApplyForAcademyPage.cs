using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;

namespace TelerikAcademyWebDriver.Advanced.TelerikAcademy.ElementMaps
{
    public class ApplyForAcademyPage
    {
        [FindsBy(How = How.XPath, Using = ".//span[contains(.,'Софтуерна академия')]")]
        public IWebElement SoftwareAcademyNavButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//a[contains(.,'Кандидатстване за академията')]")] 
        public IWebElement ApplyingForAcademyLink { get; set; }

        [FindsBy(How = How.Id, Using = "FirstName")]
        public IWebElement FirstNameField { get; set; }

        [FindsBy(How = How.Id, Using = "SecondName")]
        public IWebElement SecondNameField { get; set; }

        [FindsBy(How = How.Id, Using = "LastName")]
        public IWebElement LastNameField { get; set; }

        [FindsBy(How = How.Id, Using = "Picture")]
        public IWebElement Picture { get; set; }

        [FindsBy(How = How.Id, Using = "IsMale_True")]
        public IWebElement IsMaleRadioButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[contains(.,'Изберете занимание')]")]
        public IWebElement ActivitySpan { get; set; }

        [FindsBy(How = How.XPath, Using = @"//*[@id='WorkEducationStatusId_listbox']/li[3]")]   
        public IWebElement SchoolActivity { get; set; }
      
        [FindsBy(How = How.Id, Using = "BirthDay")]
        public IWebElement BirthdayField { get; set; }

        [FindsBy(How = How.Id, Using = "Email")]
        public IWebElement EmailField { get; set; }

        [FindsBy(How = How.Id, Using = "Phone")]
        public IWebElement PhoneField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[contains(.,'Изберете град')]")]
        public IWebElement CitySpan { get; set; }

        [FindsBy(How = How.XPath, Using = @"//*[@id='CityId_listbox']/li[2]")]
        public IWebElement ChosenCity { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='PersonalData']/div[18]/span[1]/span/span[2]/span")]
        public IWebElement UniversitySpan { get; set; }

        [FindsBy(How = How.XPath, Using = @"//*[@id='UniversityId_listbox']/li[2]")]
        public IWebElement ChosenUniversity { get; set; }

        [FindsBy(How = How.Id, Using = "SchoolName")]
        public IWebElement SchoolNameField { get; set; }

        [FindsBy(How = How.Id, Using = "Question_1")]
        public IWebElement QuestionField_1 { get; set; }

        [FindsBy(How = How.Id, Using = "Question_2")]
        public IWebElement QuestionField_2 { get; set; }

        [FindsBy(How = How.Id, Using = "Question_3")]
        public IWebElement QuestionField_3 { get; set; }

        [FindsBy(How = How.Id, Using = "Question_4")]
        public IWebElement QuestionField_4 { get; set; }

        [FindsBy(How = How.Id, Using = "Question_5")]
        public IWebElement QuestionField_5 { get; set; }

        [FindsBy(How = How.Id, Using = "Answer_1")]
        public IWebElement WhyApplyingField { get; set; }

        [FindsBy(How = How.Id, Using = "Answer_9")]
        public IWebElement WhatWouldChangeField { get; set; }

        [FindsBy(How = How.Id, Using = "Answer_16")]
        public IWebElement RelatingField { get; set; }

        [FindsBy(How = How.Id, Using = "Answer_24")]
        public IWebElement LearnFromField { get; set; }

        [FindsBy(How = How.Id, Using = "Answer_39")]
        public IWebElement TimesApplyingField { get; set; }

        [FindsBy(How = How.Id, Using = "Answer_42")]
        public IWebElement RelatingToTelerikField { get; set; }

        [FindsBy(How = How.Id, Using = "CV")]
        public IWebElement CV { get; set; }

        [FindsBy(How = How.Id, Using = "CoverLetter")]
        public IWebElement CoverLetter { get; set; }

        [FindsBy(How = How.Id, Using = "AcceptTerms")]
        public IWebElement AcceptTerms { get; set; }

        [FindsBy(How = How.Id, Using = "SendButton")]
        public IWebElement SubmitApplication { get; set; }        
    }
}
