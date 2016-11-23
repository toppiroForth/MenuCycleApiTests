using MenuCycleIntegrationTests.Base;
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
    public class MenuPage : BasePage
    {

        //MenuPage Objects 
        [FindsBy(How = How.XPath, Using = "//span[@class='titlebar']")]
        IWebElement menuDetails { get; set; }

        [FindsBy(How = How.Id, Using = "d_linkButton")]
        IWebElement _createNewMenuLink { get; set; }

        public bool IsMenuDetailsPageDisplayed()
        {
            return Waits.waitForElementVisible(menuDetails).Displayed;
        }

        public MenuDetailsPage ClickCreateNewMenu()
        {
            Waits.waitForElementVisible(_createNewMenuLink).Click();
            return GetInstance<MenuDetailsPage>();
        }


    }
}
