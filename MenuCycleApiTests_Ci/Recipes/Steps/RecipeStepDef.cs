using MenuCycleApiTests_ci.Domain.Model;
using MenuCycleApiTests_ci.Domain.Models;
using MenuCycleApiTests_ci.Domain.Siren;
using MenuCycleApiTests_ci.GlobalData;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace MenuCycleApiTests_ci.Recipes.Steps
{
    [Binding]
    public class RecipeStepDef
    {


        private readonly MenuCycleRecord menuCycleRecord;
        public RecipeStepDef(MenuCycleRecord menuCycleRecord)
        {
            this.menuCycleRecord = menuCycleRecord;
        }




        [Then(@"the following entities class '(.*)' and rel '(.*)'are returned")]
        public void ThenTheFollowingEntitiesClassAndRelAreReturned(string Class, string rel)
        {
      
            var response = ScenarioContext.Current.Get<RestResponse>("Response");
            var embeddedLink = JsonConvert.DeserializeObject<PagedCollectionEntity<EmbeddedLink>>(response.Content);

            foreach (var entity in embeddedLink.entities)
            {
                var cls = entity.Class.First();
                var Rel = entity.rel.First();

                if ((cls == Class) && (Rel == rel))
                {
                    continue;
                }
                else
                {
                    throw new Exception("Items links tariff and rels are not Found!");
                }

            }
        }


        [Then(@"the follwing links are returned for recipes")]
        public void ThenTheFollwingLinksAreReturned(Table table)
        {

            int id = menuCycleRecord.Id;

            var response = ScenarioContext.Current.Get<RestResponse>("Response");
            var embadedLinks = JsonConvert.DeserializeObject<RecipesItemEntity<EmbeddedLink>>(response.Content);
            //var rows = table.Rows.Where(x => x.ContainsKey("href"));
            foreach (var row in table.Rows)
            {
                var item = row.FirstOrDefault(x => x.Key == "href").Value;
                if (!string.IsNullOrEmpty(item))
                {
                    menuCycleRecord.href.Add(string.Format(item, id));
                }
            }

            var result = Enumerable.SequenceEqual(
                embadedLinks.links.Select(y => y.href).ToList().OrderBy(x => x),
                menuCycleRecord.href.OrderBy(m => m));

        }

        [Then(@"user should get the first recipeId from response")]
        public void ThenUserShouldGetTheFirstRecipeIdFromResponse()
        {
            var response = ScenarioContext.Current.Get<RestResponse>("Response");
            var recipes = JsonConvert.DeserializeObject<PagedCollectionEntity<RecipesItemEntity<RecipesItemProperties>>>(response.Content);
            foreach (var recipe in recipes.entities)
            {
                menuCycleRecord.idList.Add(recipe.properties.recipeId);

            }
            menuCycleRecord.Id = menuCycleRecord.idList.First();
            Console.WriteLine("the last menu id " + menuCycleRecord.Id);
          
        }

        [Then(@"the following recipes propertie collection is returned by the server")]
        public void ThenTheFollowingRecipesPropertieCollectionIsReturnedByTheServer(Table table)
        {
            var response = ScenarioContext.Current.Get<RestResponse>("Response");
            var recipes = JsonConvert.DeserializeObject<PagedCollectionEntity<RecipesItemEntity<RecipesItemProperties>>>(response.Content);
            table.CompareToSet<RecipesItemProperties>(recipes.entities.Select(x => x.properties));


        }
        [Then(@"the following single recipe properties are returned")]
        public void ThenTheFollowingSingleRecipePropertiesAreReturned(Table table)
        {
            var response = ScenarioContext.Current.Get<RestResponse>("Response");
            var recieps = JsonConvert.DeserializeObject<RecipesItemEntity<RecipesItemProperties>>(response.Content);
            table.CompareToInstance<RecipesItemProperties>(recieps.properties);
           
        }


        [Then(@"the following '(.*)' links returned for single recipe")]
        public void ThenTheFollowingLinksReturnedForSingleRecipe(string links, Table table)
        {

            int id = menuCycleRecord.idList.First();

            var response = ScenarioContext.Current.Get<RestResponse>("Response");
            var embadedLinks = JsonConvert.DeserializeObject<RecipesItemEntity<EmbeddedLink>>(response.Content);
            //var rows = table.Rows.Where(x => x.ContainsKey("href"));

            foreach (var row in table.Rows)
            {

                var item = row.FirstOrDefault(x => x.Key == "href").Value;
                if (!string.IsNullOrEmpty(item))
                {
                    menuCycleRecord.href.Add(string.Format(item, id));
                }

            }
            var result = Enumerable.SequenceEqual(
                 embadedLinks.entities.Select(y => y.href.ToString()).ToList().OrderBy(x => x),
                 menuCycleRecord.href.OrderBy(m => m));          
        }


        









    }
}
