using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using TelerikAcademyWebDriver.Advanced.TelerikAcademy.ElementMaps;

namespace TelerikAcademyWebDriver.Advanced.TelerikAcademy.Facades
{
    public class ApplyForAcademyFacade
    {
        public void NavigateToTheApplyingForm(IWebDriver browser)
        {
            ApplyForAcademyPage elementMap = new ApplyForAcademyPage();
            PageFactory.InitElements(browser, elementMap);
            elementMap.SoftwareAcademyNavButton.Click();
            browser.FindElementAndWait(By.XPath(".//a[contains(.,'Кандидатстване за академията')]"));
            elementMap.ApplyingForAcademyLink.Click();
        }

        public void PopulatePersonalData(IWebDriver browser)
        {
            ApplyForAcademyPage elementMap = new ApplyForAcademyPage();
            PageFactory.InitElements(browser, elementMap);

            elementMap.FirstNameField.Clear();
            elementMap.FirstNameField.SendKeys("Ася");
            elementMap.SecondNameField.Clear();
            elementMap.SecondNameField.SendKeys("Аурелова");
            elementMap.LastNameField.Clear();
            elementMap.LastNameField.SendKeys("Георгиева");
            elementMap.Picture.SendKeys(@"C:\Users\ageorgieva\Desktop\5.jpg");
            elementMap.IsMaleRadioButton.Click();
            elementMap.ActivitySpan.Click();
            elementMap.SchoolActivity.Click();
            elementMap.BirthdayField.Clear();
            elementMap.BirthdayField.SendKeys(@"01/03/1901");
            elementMap.EmailField.Clear();
            elementMap.EmailField.SendKeys("adsa@asdas.bg");
            elementMap.PhoneField.Clear();
            elementMap.PhoneField.SendKeys("0897773383");
            elementMap.CitySpan.Click();
            elementMap.ChosenCity.Click();
            elementMap.UniversitySpan.Click();
            elementMap.ChosenUniversity.Click();
            elementMap.SchoolNameField.Clear();
            elementMap.SchoolNameField.SendKeys("Танцово училище");
        }

        public void PopulateAdditionalQuestions(IWebDriver browser)
        {
            ApplyForAcademyPage elementMap = new ApplyForAcademyPage();
            PageFactory.InitElements(browser, elementMap);

            elementMap.QuestionField_1.Clear();
            elementMap.QuestionField_1.SendKeys("QA ACADEMY");

            elementMap.QuestionField_2.Clear();
            elementMap.QuestionField_2.SendKeys("QA ACADEMY");

            elementMap.QuestionField_3.Clear();
            elementMap.QuestionField_3.SendKeys("QA ACADEMY");

            elementMap.QuestionField_4.Clear();
            elementMap.QuestionField_4.SendKeys("QA ACADEMY");

            elementMap.QuestionField_5.Clear();
            elementMap.QuestionField_5.SendKeys("QA ACADEMY");

            elementMap.WhyApplyingField.Click();
            elementMap.WhatWouldChangeField.Click();
            elementMap.RelatingField.Click();
            elementMap.LearnFromField.Click();
            elementMap.TimesApplyingField.Click();
            elementMap.RelatingToTelerikField.Click();
        }

        public void PopulateDocuments(IWebDriver browser)
        {
            ApplyForAcademyPage elementMap = new ApplyForAcademyPage();
            PageFactory.InitElements(browser, elementMap);
            browser.FindElement(By.Id("CV")).SendKeys(@"C:\Users\ageorgieva\Desktop\a.docx");
            browser.FindElement(By.Id("CoverLetter")).SendKeys(@"C:\Users\ageorgieva\Desktop\a.docx");
        }

        public void SubmitForm(IWebDriver browser)
        {
            ApplyForAcademyPage elementMap = new ApplyForAcademyPage();
            PageFactory.InitElements(browser, elementMap);
            elementMap.AcceptTerms.Click();
            elementMap.SubmitApplication.Click();
        }
    }
}
