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

namespace Telerik
{

    public class TelerikAcademy : BaseWebAiiTest
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
    
        //[CodedStep(@"New Coded Step")]
        //public void LogError()
        //{
            
        //}
    
        [CodedStep(@"Log error about a missing search field")]
        public void LogMissingSearchFieldError()
        {
            Console.WriteLine("Search field has not been found");
        }
    
        //[CodedStep(@"Verify Exists 'BingSearchField'")]
        //public void TelerikAcademy_CodedStep()
        //{
            //// Verify Exists 'BingSearchField'
            //Pages.Bing.BingSearchField.Wait.ForExists(30000);
            
        //}
    
        //[CodedStep(@"'Maximize' the browser.")]
        //public void TelerikAcademy_CodedStep()
        //{
            //// 'Maximize' the browser.
            //ActiveBrowser.Window.Maximize();
            
        //}
    
        [CodedStep(@"New Coded Step")]
        public void CodedSearchFieldCheck()
        {
            try
            {
            	// Verify Exists 'BingSearchField'
            	Pages.Bing.BingSearchField.Wait.ForExists(30000);
            	
            	// 'Maximize' the browser.
            	ActiveBrowser.Window.Maximize();
            }
            catch
            {
            	Console.WriteLine("Search field not present");
            }
        }
    }
}
