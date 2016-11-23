using MenuCycleIntegrationTests.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuCycleIntegrationTests.Helpers
{
    public class Waits
    {


        public static IWebElement waitForElementVisible(IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(DriverContext.Driver, TimeSpan.FromSeconds(30));
            return wait.Until(ExpectedConditions.ElementToBeClickable(element));    
        }



    }
}
