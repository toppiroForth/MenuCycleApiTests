using RestSharp;
using TechTalk.SpecFlow;
using MenuCycleApiTests_ci;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using System.Threading;
using OpenQA.Selenium.Firefox;
using System;
using OpenQA.Selenium.Remote;
using MenuCycleIntegrationTests.Pages;
using MenuCycleIntegrationTests.Base;
using OpenQA.Selenium.Chrome;
using MenuCycleIntegrationTests.Helpers;
using MenuCycleIntegrationTests.Config;
using System.Configuration;


namespace ApiTests.MenuServiceIntegration.Menus
{


    [Binding]
    public class GeneralMenu : Base

    {

        [When(@"user navigate click Create a new menu")]
        public void WhenUserNavigateClickCreateANewMenu()
        {
            CurrentPage = GetInstance<MenuPage>();
            CurrentPage = CurrentPage.As<MenuPage>().ClickCreateNewMenu();             
        }

        [When(@"user enter '(.*)' as Menu Name")]
        public void WhenIEnterAsMenuName(string menuName)
        {
            var randomNumber = Utils.GetRandomNumber(1000);
            var randomMenuName = menuName + randomNumber;
            CurrentPage = CurrentPage.As<MenuDetailsPage>().EnterMenuName(randomMenuName);   
        }

        [When(@"user select '(.*)' as Menu Type")]
        public void WhenUserSelectAsMenuType(string menuType)
        {
            CurrentPage = CurrentPage.As<MenuDetailsPage>().SelectMenuType(menuType);           
        }

        [When(@"user select '(.*)' as Include Sales Tax")]
        public void WhenUserSelectAsIncludeSalesTax(string salesTax)
        {
            CurrentPage = CurrentPage.As<MenuDetailsPage>().SelectIncludeSalestax(salesTax);
        }

        [When(@"user navigates to  the Menu Items tab")]
        public void WhenUserNavigatesToTheMenuItemsTab()
        {
            CurrentPage = CurrentPage.As<MenuItemsPage>().ClickMenuItems();
        }

        [When(@"user adding new course and enter name '(.*)' '(.*)'")]
        public void WhenUserAddingNewCourseAndEnterName(string p0, string p1)
        {
            Console.WriteLine("under development");
        }

        [When(@"I click on Save in menus toolbar")]
        public void WhenIClickOnSaveInMenusToolbar()
        {
            Console.WriteLine("under development");
        }

        



    }
}
