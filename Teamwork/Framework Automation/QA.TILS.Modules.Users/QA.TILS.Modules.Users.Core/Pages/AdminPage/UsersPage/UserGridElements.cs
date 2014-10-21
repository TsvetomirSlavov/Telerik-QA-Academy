namespace QA.TILS.Modules.Users.Core.Pages.AdminPage.UsersPage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using ArtOfTest.WebAii.Controls.HtmlControls;

    using QA.Framework.Core.Base;

    public class UserGridElements : BaseElementsMap
    {
        private string username;

        public UserGridElements(string username)
        {
            this.username = username;
        }

        public HtmlDiv Grid
        {
            get
            {
                return this.Find.ById<HtmlDiv>("DataGrid");
            }
        }

        public HtmlTableRow MasterRow 
        { 
            get
            {
                return GetUserMasterRow(this.username);
            }
        }

        public HtmlTableRow DetailsRow
        {
            get
            {
                return this.GetUserDetailsRow(this.username);
            }
        }

        public HtmlAnchor MasterOpenCloseDetailsButton 
        {
            get
            {
                return this.MasterRow.Find.ByXPath<HtmlAnchor>("//td[1]/a");
            }
        }

        public HtmlTableCell MasterId
        {
            get
            {
                return this.MasterRow.Find.ByXPath<HtmlTableCell>("//td[2]");
            }
        }

        public HtmlAnchor MasterUsername
        {
            get
            {
                return this.MasterRow.Find.ByXPath<HtmlAnchor>("//td[3]/a");
            }
        }

        public HtmlTableCell MasterStudentNumber
        {
            get
            {
                return this.MasterRow.Find.ByXPath<HtmlTableCell>("//td[4]");
            }
        }

        public HtmlTableCell MasterFullName
        {
            get
            {
                return this.MasterRow.Find.ByXPath<HtmlTableCell>("//td[5]");
            }
        }

        public HtmlTableCell MasterBirthDate
        {
            get
            {
                return this.MasterRow.Find.ByXPath<HtmlTableCell>("//td[7]");
            }
        }

        public HtmlTableCell MasterSex
        {
            get
            {
                return this.MasterRow.Find.ByXPath<HtmlTableCell>("//td[8]");
            }
        }

        public HtmlTableCell MasterEmail
        {
            get
            {
                return this.MasterRow.Find.ByXPath<HtmlTableCell>("//td[9]");
            }
        }

        public HtmlAnchor MasterEditUser
        {
            get
            {
                return this.MasterRow.Find.ByXPath<HtmlAnchor>("//td[18]/a");
            }
        }

        public HtmlAnchor MasterDeleteUser
        {
            get
            {
                var masterRow = this.MasterRow;
                return masterRow.Find.ByXPath<HtmlAnchor>("/td[19]/a");
            }
        }

        private HtmlTableRow GetUserMasterRow(string username)
        {
            var result = this.Find.AllByXPath<HtmlTableRow>("//*[@id='DataGrid']/table/*/tr"); //.Find.ByExpression<HtmlTableRow>("data-username=" + username);
            return null;
        }

        private HtmlTableRow GetUserDetailsRow(string username)
        {
            var result = this.Grid.Find.AllByTagName<HtmlTableRow>("tr").FirstOrDefault(e =>
                e.Find.ByAttributes<HtmlAnchor>("data-username=" + username) != null
                );
            return result;
        }
    }
}
