using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.Assist;
using TechTalk.SpecFlow;
using MenuCycleApiTests_ci.Domain.Siren;
using MenuCycleApiTests_ci.Domain.Model;
using MenuCycleApiTests_ci.Domain.Models;

namespace MenuCycleApiTests_ci.MealPeriods
{

    [Binding]
    public class GETMealPeriods
    {
        [Then(@"the following MealPeriod propertie collection is returned by the server")]
        public void ThenTheFollowingMealPeriodPropertieCollectionIsReturnedByTheServer(Table table)
        {
            var response = ScenarioContext.Current.Get<RestResponse>("Response");
            var mealPeriods = JsonConvert.DeserializeObject<MenuCycleApiTests_ci.Domain.Siren.PagedCollectionEntity<MealPeriodItemEntity<MealPeriodsItemProperties>>>(response.Content);
            table.CompareToSet<MealPeriodsItemProperties>(mealPeriods.entities.Select(x => x.properties));

        }


       [Then(@"the following MealPeriod entities class '(.*)' and rel '(.*)'are returned")]
        public void ThenTheFollowingMealPeriodEntitiesClassAndRelAreReturned(string Class, string rel)
        {     
            var response = ScenarioContext.Current.Get<RestResponse>("Response");
            var embeddedLink = JsonConvert.DeserializeObject<PagedCollectionEntity<EmbeddedLink>>(response.Content);
             
            foreach (var entity in embeddedLink.entities)
            {
                var cls = entity.Class.First();
                var Rel = entity.rel.First();
         
                    if ((cls == Class ) && (Rel == rel))
                    {
                        continue;
                    }
                    else
                    {
                        throw new Exception("Items links Mealperiods and rels are not Found!");
                    }

            }



        }

    }
}
