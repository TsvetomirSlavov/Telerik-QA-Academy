namespace QA.TILS.Modules.Users.Core.Pages.AdminPage.CoursesPage
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using QA.Framework.Core.Base;
    using QA.Framework.Core.Extensions;

    public class CoursesPageElements : BaseElementsMap
    {
        public HtmlAnchor EditTestCourseButton
        {
            get
            {
                return this.Find.ByXPath<HtmlAnchor>("//*[@id='DataGrid']/table/tbody/tr[td/a/@href ='/Courses/Courses/Details/29']/td[16]/a");
            }
        }
    }
}
