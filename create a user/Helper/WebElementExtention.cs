using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_a_user.Helper
{
   public static class WebElementExtention
    {
        public static void WaitElement(this IWebElement iwebelement, TimeSpan timeSpan)
        {
            var wait = new WebDriverWait(CommonDrive.driver,timeSpan);
            wait.Until(ExpectedConditions.ElementToBeClickable(iwebelement));
        }
    }
}
