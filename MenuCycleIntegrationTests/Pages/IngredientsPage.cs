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
    public class IngredientsPage: BasePage
    {



        [FindsBy(How = How.Id, Using = "h:imgIngredient")]
        public IWebElement _ingredientLocator  { get; set; }




        public bool ImOnTheRightPage()
        {
            return Waits.waitForElementVisible(_ingredientLocator).Displayed;
        }









    }
}
