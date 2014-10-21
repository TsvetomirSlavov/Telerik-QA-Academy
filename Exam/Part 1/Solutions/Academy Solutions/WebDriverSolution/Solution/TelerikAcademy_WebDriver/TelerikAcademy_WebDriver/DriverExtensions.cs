using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace TelerikAcademyWebDriver
{
    public static class DriverExtensions
    {
        private static WebDriverWait internalWait;
 
        public static IWebElement FindElementAndWait(this IWebDriver driver, By findExpression)
        {
            if (internalWait == null)
            {
                internalWait = new WebDriverWait(driver, TimeSpan.FromMinutes(3));
            }

            var element = internalWait.Until(x => x.FindElement(findExpression));
            return element;
        }
    }
}
