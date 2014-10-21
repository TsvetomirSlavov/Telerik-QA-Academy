namespace QA.TILS.Modules.Users.Tests.Front
{
    using ArtOfTest.WebAii.Core;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.Framework.Core.Base;
    using QA.Framework.Core.Data;
    using QA.Framework.Core.Helpers;
    using QA.Framework.Core.Extensions;
    using QA.TILS.Modules.Users.Core.SharedSteps;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TILS.Modules.Users.Core.Pages.AdminPage.CoursesPage;

    /// <summary>
    /// Summary description for AccessToMaterials
    /// </summary>
    [TestClass]
    public class CourseEnrollment : BaseTest
    {
        //Enrollment an in-class from adds the course to the user
        public CoursesPage CoursesPage;

        public override void TestInitialize()
        {
            this.CoursesPage = new CoursesPage();

            this.Browser.ClearCache(BrowserCacheType.Cookies);
            this.Browser.Refresh();

        }
    }
}
