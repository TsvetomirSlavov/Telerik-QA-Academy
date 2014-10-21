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

    public class Telerik_Silverlight_Demo : BaseWebAiiTest
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
    
        //[CodedStep(@"Verify 'OCT032014Textblock' text Same 'OCT 03, 2014'", RequiresSilverlight=true)]
        //public void Telerik_Silverlight_Demo_CodedStep()
        //{
            //// Verify 'OCT032014Textblock' text Same 'OCT 03, 2014'
            //Assert.IsFalse((ArtOfTest.Common.CompareUtils.StringCompare(Pages.TelerikGaugeForSilverlight0.SilverlightApp.OCT032014Textblock.Text, DateTime.Now.ToString("MMM dd, yyyy").ToUpper(), ArtOfTest.Common.StringCompareType.Same) == false), string.Format("Verify \'OCT032014Textblock\' text Same \'OCT 03, 2014\' failed.  Actual value \'{0}\'", Pages.TelerikGaugeForSilverlight0.SilverlightApp.OCT032014Textblock.Text));
            
        //}
    
        [CodedStep(@"Verify 'OCT032014Textblock' text Same 'OCT 03, 2014'", RequiresSilverlight=true)]
        public void Telerik_Silverlight_Demo_CodedStep()
        {
            // Verify 'OCT032014Textblock' text Same 'OCT 03, 2014'
            Assert.IsFalse((ArtOfTest.Common.CompareUtils.StringCompare(Pages.TelerikGaugeForSilverlight0.SilverlightApp.OCT032014Textblock.Text, DateTime.Now.ToString("MMM dd, yyyy").ToUpper(), ArtOfTest.Common.StringCompareType.Same) == false), string.Format("Verify \'OCT032014Textblock\' text Same \'OCT 03, 2014\' failed.  Actual value \'{0}\'", Pages.TelerikGaugeForSilverlight0.SilverlightApp.OCT032014Textblock.Text));
            
        }
    }
}
