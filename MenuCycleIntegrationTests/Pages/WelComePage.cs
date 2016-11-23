using MenuCycleIntegrationTests.Base;
using MenuCycleIntegrationTests.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MenuCycleIntegrationTests.Pages
{
    public class WelComePage : BasePage
    {

        //Welcome page objects 
        [FindsBy(How = How.XPath, Using = "//img[@name='Header1:imgMenu']")]
        public IWebElement _menu_Header { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@id='lblHello']")]
        IWebElement _Hello { get; set; }

        [FindsBy(How = How.Name, Using = "Header1:imgAdmin")]
        IWebElement _adminLink { get; set; }

        [FindsBy(How = How.Name, Using = "Header1:imgIngredient")]
        IWebElement _ingredientsLink { get; set; }

        [FindsBy(How = How.Name, Using = "Header1:imgDish")]
        IWebElement _recipesLink { get; set; }

        [FindsBy(How = How.Name, Using = "Header1:imgMenu")]
        IWebElement _menusLink { get; set; }

        [FindsBy(How = How.Name, Using = "Header1:imgHome")]
        IWebElement _homePageLink { get; set; }

        [FindsBy(How = How.Name, Using = "h:imgHome")]
        IWebElement _homePageLink1 { get; set; }



        public bool ImOnTheRightPage()
        {
            return Waits.waitForElementVisible(_Hello).Displayed;


        }

        public MenuPage clickMenu()
        {
            Waits.waitForElementVisible(_menu_Header).Click();
            return new MenuPage();
        }

        public AdminPage ClickAdmin()
        {
            Waits.waitForElementVisible(_adminLink).Click();
            return new AdminPage();
        }

        public IngredientsPage ClickIngredients()
        {
            Waits.waitForElementVisible(_ingredientsLink).Click();
            return new IngredientsPage();

        }

        public RecipesPage ClickRecipes()
        {
            Waits.waitForElementVisible(_recipesLink).Click();
            return new RecipesPage();

        }

        public MenuPage ClickMenus()
        {
            Waits.waitForElementVisible(_menusLink).Click();
            return new MenuPage();
        }

        public HomePage ClickHomePage()
        {

            try
            {
                Waits.waitForElementVisible(_homePageLink1).Click();
            }
            catch
            {
                Waits.waitForElementVisible(_homePageLink).Click();
            }
            return new HomePage();

        }


    }





}
