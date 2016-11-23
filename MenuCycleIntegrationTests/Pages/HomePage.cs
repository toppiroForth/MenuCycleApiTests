using MenuCycleIntegrationTests.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuCycleIntegrationTests.Pages
{
    public class HomePage
    {

        [FindsBy(How = How.Id, Using = "Header1:imgHome")]
        public IWebElement _homePageLink { get; set; }

        public bool ImOnTheRightPage()
        {
            return Waits.waitForElementVisible(_homePageLink).GetAttribute("border") == "0";
        }

    }
}
