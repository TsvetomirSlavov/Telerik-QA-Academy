using ArtOfTest.WebAii.Controls.HtmlControls;
using QA.Framework.Core.Base;

namespace QA.TILS.Modules.Users.Core.Pages.AdminPage.Towns
{
    public class TownsPageElements : BaseElementsMap
    {
        public HtmlAnchor AnchorAddNewTown
        {
            get
            {
                return
                    this.Find.ByXPath<HtmlAnchor>(
                        "//a[@href='/Administration_Users/Provinces/Read?DataGrid-mode=insert']");
            }
        }

        public HtmlInputText NameEnglish
        {
            get { return this.Find.ById<HtmlInputText>("NameEn"); }
        }

        public HtmlInputText NameBulgarian
        {
            get { return this.Find.ById<HtmlInputText>("NameBg"); }
        }


        public HtmlAnchor UpdateButton
        {
            get
            {
                return
                    this.Find.ByXPath<HtmlAnchor>(
                        "/html/body/div[3]/div[2]/div/div[5]/a[1]");
            }
        }
    }
}
