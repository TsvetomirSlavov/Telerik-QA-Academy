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

namespace Answers
{

    public class _Book_Store_bg____JS_First_Result_Title_Check : BaseWebAiiTest
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
    
        [CodedStep(@"Verify 'TextContent' 'Contains' '$(FirstResultTitle)' on 'ЦенаЗаBTag'")]
        public void BookStorebg_JS_First_Result_Title_Check_CodedStep()
        {
            // Verify 'TextContent' 'Contains' '$(FirstResultTitle)' on 'ЦенаЗаBTag'
            Pages.StoreBg.ЦенаЗаBTag.AssertContent().TextContent(ArtOfTest.Common.StringCompareType.Contains, GetExtractedValue("FirstResultTitle").ToString());
            
        }
    }
}
