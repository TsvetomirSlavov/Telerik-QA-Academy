using System;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using TelerikAcademyTests.Templates;

namespace TelerikAcademyWebDriver.Exceptions
{
    public class ElementStillVisibleException : ApplicationException
    {
        public ElementStillVisibleException()        
        {
        }

        public ElementStillVisibleException(By by, WebDriverTest ext, Exception ex)
        {
            string message = this.BuildElementStillVisibleExceptionText(by, ext);

            throw new ApplicationException(message, ex);
        }

        public ElementStillVisibleException(By by, WebDriverTest ext)
        {
            string message = this.BuildElementStillVisibleExceptionText(by, ext);

            throw new ApplicationException(message);
        }

        private string BuildElementStillVisibleExceptionText(By by, WebDriverTest ext)
        {
            StringBuilder sb = new StringBuilder();

            string customLoggingMessage =
                String.Format("#### The element with the location strategy:  {0} ####\n ####IS STILL VISIBLE!####",
                    by.ToString());
            sb.AppendLine(customLoggingMessage);

            string cuurentUrlMessage = String.Format("The URL when the test failed was: {0}", ext.Browser.Url);
            sb.AppendLine(cuurentUrlMessage);

            return sb.ToString();
        }
    }
}