using MenuCycleIntegrationTests.Base;
using MenuCycleIntegrationTests.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MenuCycleIntegrationTests.Pages
{
    public class RecipesPage : BasePage
    {


        [FindsBy(How = How.Id, Using = "h:imgIngredient")]
        public IWebElement _recipeLocator { get; set; }


        public bool ImOnTheRightPage()
        {
            return Waits.waitForElementVisible(_recipeLocator).GetAttribute("border") == "0";
        }


    }
}
