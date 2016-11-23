using MenuCycleIntegrationTests.Base;
using MenuCycleIntegrationTests.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuCycleIntegrationTests.Pages
{
    public class MenuItemsPage : BasePage
    {


        [FindsBy(How=How.Id, Using = "d_mainTabs")]
        public IWebElement _menuItemsTab {get;set;}


        public MenuItemsPage ClickMenuItems()
        {
            var actions = new Actions(DriverContext.Driver);
            actions.MoveToElement(Waits.waitForElementVisible(_menuItemsTab)).MoveByOffset(-500, 0).Click().Build().Perform();
            return GetInstance<MenuItemsPage>();
        }
    }
}
