using Telerik.TestingFramework.Controls.KendoUI;
using Telerik.WebAii.Controls.Html;
using Telerik.WebAii.Controls.Xaml;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using ArtOfTest.Common.UnitTesting;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts;
using ArtOfTest.WebAii.Design;
using ArtOfTest.WebAii.Design.Execution;
using ArtOfTest.WebAii.ObjectModel;
using ArtOfTest.WebAii.Silverlight;
using ArtOfTest.WebAii.Silverlight.UI;

namespace ExamPart1TestStudio
{

    public class _1__Kendo_UI___Grid__Inline_Editing : BaseWebAiiTest
    {
        #region [ Dynamic Pages Reference ]

        private Pages _pages;

        /// <summary>
        /// Gets the Pages object that has references
        /// to all the elements, frames or regions
        /// in this project.
        /// </summary>
        public Pages Pages
        {
            get
            {
                if (_pages == null)
                {
                    _pages = new Pages(Manager.Current);
                }
                return _pages;
            }
        }

        #endregion
        
        // Add your test methods here...
    
        //[CodedStep(@"KendoPager (Wait for): Page '4' is Selected")]
        //public void KendoUI_Grid_Inline_Editing_CodedStep()
        //{
            //// KendoPager (Wait for): Page '4' is Selected
            //Pages.ApplyingInlineEditingIn.GridPagerControl.Wait.ForExists(30000);
            //Wait.For<KendoPager>(c => (c.SelectedPage == "4"), Pages.ApplyingInlineEditingIn.GridPagerControl, 30000);
            
        //}
    
        //[CodedStep(@"KendoPager (Wait for): Pages count 'Equals' '4'")]
        //public void KendoUI_Grid_Inline_Editing_CodedStep()
        //{
            //// KendoPager (Wait for): Pages count 'Equals' '4'
            //Pages.ApplyingInlineEditingIn.GridPagerControl.Wait.ForExists(30000);
            //Wait.For<KendoPager>(c => c.ControlAssert().NumberValue("PagesCount", 4, ArtOfTest.Common.NumberCompareType.Equals), Pages.ApplyingInlineEditingIn.GridPagerControl, 30000);
            
        //}
    }
}
