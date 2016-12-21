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
using MenuCycleApiTests_ci.GlobalData;

namespace MenuCycleApiTests_ci.MealPeriods
{

    [Binding]
    public class GETMealPeriods
    {
        private readonly MenuCycleRecord menuCycleRecord;

        public GETMealPeriods(MenuCycleRecord menuCycleRecord)
        {
            this.menuCycleRecord = menuCycleRecord;
        }




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

                if ((cls == Class) && (Rel == rel))
                {
                    continue;
                }
                else
                {
                    throw new Exception("Items links Mealperiods and rels are not Found!");
                }

            }
        }

        [Then(@"user should get the first mealPriodId from response")]
        public void ThenUserShouldGetTheFirstMealPriodIdFromResponse()
        {
            var response = ScenarioContext.Current.Get<RestResponse>("Response");
            var mealPeriods = JsonConvert.DeserializeObject<PagedCollectionEntity<MealPeriodItemEntity<MealPeriodsItemProperties>>>(response.Content);
            foreach (var mealPeriod in mealPeriods.entities)
            {
                menuCycleRecord.idList.Add(mealPeriod.properties.mealPeriodId);
            }
            menuCycleRecord.Id = menuCycleRecord.idList.First();
            Console.WriteLine("the last menu id " + menuCycleRecord.Id);

        }

        [When(@"user issues '(.*)' request against the single '(.*)' and '(.*)'")]
        public void WhenUserIssuesRequestAgainstTheSingleAnd(string httpVerb, string resourceCollection, string individualResource = "")
        {
            // request method
            Method method;
            Method.TryParse(httpVerb, out method);

            menuCycleRecord.Id = menuCycleRecord.idList.First();

            // generate a request based on that URI
            var request = new RestRequest(resourceCollection + menuCycleRecord.Id + individualResource, method);

            request.AddHeader("Accept", "application/vnd.siren+json");

            // add standard headers
            // request.AddHeader("Content-Type", "application/vnd.siren+json");

            switch (method)
            {
                case Method.GET:
                    // get the client
                    // add request to context for later processing (add additional headers)
                    ScenarioContext.Current.AddNewRemoveExisting("Request", request);

                    break;

                case Method.PUT:
                    // add request to context for later processing (add additional headers)
                    ScenarioContext.Current.AddNewRemoveExisting("Request", request);
                    break;

                case Method.POST:
                    // add request to context for later processing (add additional headers)
                    ScenarioContext.Current.AddNewRemoveExisting("Request", request);
                    break;

                case Method.DELETE:
                    // execute request and add response to context for later processing
                    ScenarioContext.Current.AddNewRemoveExisting("Request", request);
                    break;
            }


        }

        [Then(@"the following single mealperiod properties are returned")]
        public void ThenTheFollowingSingleMealperiodPropertiesAreReturned(Table table)
        {
            var response = ScenarioContext.Current.Get<RestResponse>("Response");
            var mealPeriods = JsonConvert.DeserializeObject<MealPeriodItemEntity<MealPeriodsItemProperties>>(response.Content);
            table.CompareToInstance<MealPeriodsItemProperties>(mealPeriods.properties);

        }

        [Then(@"the following '(.*)' links returned for single mealPeriod")]
        public void ThenTheFollowingLinksReturnedForSingleMealPeriod(string links, Table table)
        {

            int id = menuCycleRecord.idList.First();

            var response = ScenarioContext.Current.Get<RestResponse>("Response");
            var embadedLinks = JsonConvert.DeserializeObject<MealPeriodItemEntity<EmbeddedLink>>(response.Content);
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

