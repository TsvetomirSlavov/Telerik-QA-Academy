using ArtOfTest.WebAii.Controls.HtmlControls;

using QA.Framework.Core.Base;
using QA.Framework.Core.Extensions;

namespace QA.TILS.Modules.Towns.Core.Pages.Towns
{
    public class TownsPageElements : BaseElementsMap
    {
        public HtmlAnchor AnchorAddNewTown
        {
            get
            {
                return this.Find.ByXPath<HtmlAnchor>(@"//*[@id='DataGrid']/div[1]/a[2]");
                //return this.Find.ByAttributes<HtmlAnchor>("k-button k-button-icontext k-grid-add".ToIsClassExpression());
            }
        }
    }
}
