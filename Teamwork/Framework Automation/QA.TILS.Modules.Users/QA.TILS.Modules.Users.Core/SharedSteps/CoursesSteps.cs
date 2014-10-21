namespace QA.TILS.Modules.Users.Core.SharedSteps
{
    using ArtOfTest.WebAii.Core;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.Framework.Core.Data;
    using QA.Framework.Core.Data.Templates;
    using QA.Framework.Core.Helpers;
    using QA.TILS.Modules.Users.Core.Pages.AdminPage.CoursesPage;
    using QA.TILS.Modules.Users.Core.Pages.Common;

    public static class CoursesSteps
    {
        private static CoursesPage CoursesPage
        {
            get
            {
                return new CoursesPage();
            }
        }
        public static void OpenTestCourseEditPage()
        {
            LoginSteps.LoginAdmin();

            CoursesPage.Elements.EditTestCourseButton.Click();
        }
    }
}
