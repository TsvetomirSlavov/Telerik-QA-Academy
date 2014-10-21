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

    public class Drag_and_Drop_Test : BaseWebAiiTest
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
    
        //[CodedStep(@"Desktop command: Drag & Drop Box1Div to Window Target")]
        //public void Drag_and_Drop_Test_CodedStep()
        //{
            //// Desktop command: Drag & Drop Box1Div to Window Target
            //Pages.Demo2DragAndDrop.Box1Div.Wait.ForExists(30000);
            //ActiveBrowser.ScrollBy(0, 0);
            //Pages.Demo2DragAndDrop.Box1Div.DragToWindowLocation(ArtOfTest.Common.OffsetReference.TopLeftCorner, 405, 315, true, ArtOfTest.Common.OffsetReference.TopLeftCorner, 705, 379, true);
            
        //}
    }
}
