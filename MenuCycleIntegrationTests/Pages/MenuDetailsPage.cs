using MenuCycleIntegrationTests.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuCycleIntegrationTests.Pages
{
    public class MenuDetailsPage : MenuPage
    {

        [FindsBy(How = How.XPath, Using = "//*[@id='d_entityName']")]
        IWebElement _detailsMenuName { get; set; }


        [FindsBy(How = How.XPath, Using = "//span[@class='titlebar']")]
        IWebElement _detailsMenuType { get; set; }


        [FindsBy(How = How.Id, Using = "d_lstIncSalesTax")]
        IWebElement _detailsIncludeSalesTax { get; set; }



        public MenuDetailsPage EnterMenuName(string name)
        {
            Waits.waitForElementVisible(_detailsMenuName).Clear();
            Waits.waitForElementVisible(_detailsMenuName).SendKeys(name);
            return GetInstance<MenuDetailsPage>();
        }

        public MenuDetailsPage SelectMenuType(string menuType)
        {
            new SelectElement(_detailsMenuType).SelectByText(menuType);
            return GetInstance<MenuDetailsPage>();
        }

        public MenuItemsPage SelectIncludeSalestax(string salesTax)
        {
            new SelectElement(_detailsIncludeSalesTax).SelectByText(salesTax);
            return GetInstance<MenuItemsPage>();
        }




    }




}
