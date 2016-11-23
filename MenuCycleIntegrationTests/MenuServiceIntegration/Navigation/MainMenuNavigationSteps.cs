using MenuCycleIntegrationTests.Base;
using MenuCycleIntegrationTests.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MenuCycleIntegrationTests.MenuServiceIntegration.Navigation
{

    [Binding]
    public class MainMenuNavigationSteps
    {

        [Given(@"the user navigates to the '(.*)' page")]
        public void GivenTheUserNavigatesToThePage(string mainMenuItem)
        {
            switch (mainMenuItem)
            {
                case "admin":
                    {
                        var welComePage = ScenarioContext.Current.Get<WelComePage>("WelComePage");
                        welComePage.ClickAdmin();                      
                        Assert.IsTrue(welComePage.ImOnTheRightPage());
                        if (ScenarioContext.Current.ContainsKey("AdminPage")) return;
                        ScenarioContext.Current.Add("AdminPage", welComePage);
                        break;
                    }

                case "Ingredients":
                    {
                        var ingredients = ScenarioContext.Current.Get<WelComePage>("WelComePage").ClickIngredients();
                        Assert.IsTrue(ingredients.ImOnTheRightPage());
                        if (ScenarioContext.Current.ContainsKey("IngredientsPage")) return;
                        ScenarioContext.Current.Add("IngredientsPage", ingredients);
                        break;
                    }


                case "Recipes":
                    {
                        var recipes = ScenarioContext.Current.Get<WelComePage>("WelComePage").ClickRecipes();
                        Assert.IsTrue(recipes.ImOnTheRightPage());
                        if (ScenarioContext.Current.ContainsKey("RecipesPage")) return;
                        ScenarioContext.Current.Add("RecipesPage", recipes);
                        break;
                    }
                case "Menus":
                    {
                        var menus = ScenarioContext.Current.Get<WelComePage>("WelComePage").ClickMenus();
                        Assert.IsTrue(menus.IsMenuDetailsPageDisplayed());
                        if (ScenarioContext.Current.ContainsKey("MenusPage")) return;
                        ScenarioContext.Current.Add("MenusPage", menus);
                        break;
                    }
                case "Home":
                    {
                        var home = ScenarioContext.Current.Get<WelComePage>("WelComePage").ClickHomePage();
                        Assert.IsTrue(home.ImOnTheRightPage());
                        if (ScenarioContext.Current.ContainsKey("MenusPage")) return;
                        ScenarioContext.Current.Add("MenusPage", home);
                        break;
                    }
            }


            

           
        }



    }
}
