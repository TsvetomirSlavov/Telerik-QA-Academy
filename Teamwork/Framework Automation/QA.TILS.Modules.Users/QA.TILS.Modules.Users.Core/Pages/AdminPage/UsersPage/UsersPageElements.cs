namespace QA.TILS.Modules.Users.Core.Pages.AdminPage.UsersPage
{
    using System.Linq;

    using ArtOfTest.WebAii.Controls.HtmlControls;

    using QA.Framework.Core.Base;
    using QA.Framework.Core.Extensions;

    public class UsersPageElements : BaseElementsMap
    {
        public HtmlAnchor NewUserRegistrationButton
        { 
            get
            {
                return this.Find.ByExpression<HtmlAnchor>("/Users/Auth/Registration".ToLinkContainsExpression());
            }
        }

        public HtmlAnchor OpenAllButton
        {
            get
            {
                return this.Find.ByAttributes<HtmlAnchor>("k-button k-button-icontext k-grid-expandAll".ToIsClassExpression());
            }
        }

        public HtmlAnchor FilterUsersButton
        {
            get
            {
                return this.Find.ById<HtmlAnchor>("getUsersData");
            }
        }

        public HtmlAnchor ExportToExcelButton
        {
            get
            {
                return this.Find.ById<HtmlAnchor>("export");
            }
        }

        public HtmlAnchor BackToAdministrationButton
        {
            get
            {
                return this.Find.ByExpression<HtmlAnchor>("/Administration/Navigation".ToLinkContainsExpression());
            }
        }

        public HtmlAnchor RefreshButton
        {
            get
            {
                return this.Find.ByAttributes<HtmlAnchor>("title=Refresh");
            }
        }

        public HtmlAnchor DeleteUserButton(string username)
        {
            var row = this.Find.AllByExpression<HtmlTableRow>("TagName=tr").FirstOrDefault(e => e.Find.ByAttributes<HtmlAnchor>(string.Format("data-username={0}", username)) != null);
            return row.Find.ByAttributes<HtmlAnchor>("class=k-button k-button-icontext k-grid-delete");
        }
    }
}
