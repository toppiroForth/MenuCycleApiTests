using ApiTests.Domain.Siren;
using MenuCycleApiTests_ci.Domain.Models;
using MenuCycleApiTests_ci.GlobalData;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MenuCycleApiTests_ci.MenuCycleItems.Steps
{
    [Binding]
    public class UpdateMenuItemSetps
    {

 private readonly MenuCycleRecord menuCycleItemId;

 public UpdateMenuItemSetps(MenuCycleRecord menuCycleItemId)
        {
            this.menuCycleItemId = menuCycleItemId;
        }


        [Then(@"user can get one of the menucycleitemid")]
        public void ThenUserCanGetOneOfTheMenucycleitemid()
        {
            var response = ScenarioContext.Current.Get<RestResponse>("Response");
            // var listOfMenuCycles = JsonConvert.DeserializeObject<ApiTests.Domain.Siren.PagedCollectionEntity<MenuCycleItemsEntity<MenuCycleItemsEntityProperties>>>(response.Content);
            var listOfMenuCycle = JsonConvert.DeserializeObject<PagedCollectionEntity<MenuCycleItemEntity<MenuCycleItemsEntityProperties>>>(response.Content);

            var menucycleItemId = listOfMenuCycle.entities.First().properties.menuCycleItemId;
            menuCycleItemId._menuCycleItemId = menucycleItemId;



            Console.WriteLine("this is the menuCycle item id" + menuCycleItemId._menuCycleItemId);
                        
        }

        [When(@"user issues '(.*)' request to update single item against the '(.*)' and '(.*)'")]
        public void WhenUserIssuesRequestToUpdateSingleItemAgainstTheAnd(string httpVerb, string resourceCollection, string individualResource = "")
        {
            // request method
            Method method;
            Method.TryParse(httpVerb, out method);

            int lastMenucycleItemId = menuCycleItemId._menuCycleItemId;


            // generate a request based on that URI
            var request = new RestRequest(resourceCollection +individualResource+ "/" + lastMenucycleItemId, method);
            Console.WriteLine("this is the request " + request);


            request.AddHeader("Accept", "application/vnd.siren+json");
            // add standard headers
            //GlobalSteps.AddJsondHeadersToRequest(request);

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

        [When(@"user update single item (.*) (.*) (.*) (.*) (.*) add to body")]
        public void WhenUserUpdateSingleItemAddToBody(int _day, int _order, int _menuid, int _mealperiod, int recipeId)
        {
            // get the request
            var request = ScenarioContext.Current.Get<RestRequest>("Request");
            //add body to request 
            var entity = new MenuCycleItemEntity<Dictionary<string, object>>();
            entity.@class.Add("MenuCycleItems");
            entity.rel.Add("/rels/MenuCycle");

            Dictionary<string, object> props = new Dictionary<string, object>()
            {
                { "menuCycleItemId", menuCycleItemId._menuCycleItemId},
                { "day",_day},
                { "order",_order},
                { "mealPeriodId",_mealperiod}
            };


            entity.properties = props;

            //changing PropertyNames into CamelCase
            var settings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };

            var obj = JsonConvert.SerializeObject(entity, Formatting.None, settings);

            request.AddParameter("application/vnd.siren+json", obj, ParameterType.RequestBody);

            // get the client
            var restClient = ScenarioContext.Current.Get<RestClient>("RestClient");

            //execute request and add response to context for later processing
            ScenarioContext.Current.AddNewRemoveExisting("Response", restClient.Execute(request));
        }



           
        }








    
}
