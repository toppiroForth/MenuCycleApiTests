using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuCycleIntegrationTests.Base
{



    public class Browser
    {

        private readonly IWebDriver driver;

        public Browser(IWebDriver driver)
        {
            this.driver = driver;
        }


        public BrowserType Type { get; set; }

        public void GoToUrl(string Url)
        {
            DriverContext.Driver.Url = Url;

        }


    }

      public enum BrowserType
       {

           InternetExplorer,
           Firefox,
           Chrome
       }

    
}
