using MenuCycleIntegrationTests.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MenuCycleIntegrationTests.Helpers
{
    public class Utils : BasePage
    {

        public static int GetRandomNumber(int max)
        {
            return new Random().Next(0, max);
        }


        public static bool isAlertPresent()
        {
            try
            {
                Thread.Sleep(5000);
                DriverContext.Driver.SwitchTo().Alert();
                return true;
            }   // try 
            catch (NoAlertPresentException Ex)
            {
                return false;
            }   // catch 
        }

        public static bool isAlertDialogPresent(IWebDriver driver)
        {
            IAlert alert = ExpectedConditions.AlertIsPresent().Invoke(driver);
            return (alert != null);
        }







      
    }
}
