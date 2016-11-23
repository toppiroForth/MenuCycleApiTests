using RestSharp;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Newtonsoft.Json;
using MenuCycleApiTests_ci.Domain.Models;
using System.Linq;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;
using MenuCycleApiTests_ci.GlobalData;
using ApiTests.Domain.Siren;
using ApiTests.Domain.Model;

namespace MenuCycleApiTests_ci.MenuCycleItems.MenuCycleItemsStepDef
{
    [Binding]
    public class MenuCycleItemCollectionsSteps
    {

        private readonly MenuCycleRecord menuCycleItemId;

        public MenuCycleItemCollectionsSteps(MenuCycleRecord menuCycleItemId)
        {
            this.menuCycleItemId = menuCycleItemId;
        }

        [When(@"user update single item  with day (.*) order (.*) menuid (.*) mealperiod (.*) and recipeid (.*)")]
        public void WhenUserUpdateSingleItemWithDayOrderMenuidMealperiodAndRecipeid(int _day, int _order, int _menuid, int _mealperiod, int recipeId)
        {
            // get the request
            var request = ScenarioContext.Current.Get<RestRequest>("Request");
            //add body to request 
            var entity = new MenuCycleItemEntity<Dictionary<string, object>>();
            entity.@class.Add("MenuCycleItems");
            entity.entities = new List<EmbeddedMenuCycleItemProperty>
            {
                new EmbeddedMenuCycleItemProperty
                {
                     Class = new List<string>{"MenuCycleItem"},
                     rel =new List<string>{"/rels/MenuCycle"},
                     Properties = new MenuCycleItemsEntityProperties
                     {
                         menuCycleItemId =menuCycleItemId._menuCycleItemId,
                         day= _day,
                         order=_order,
                         menuId=_menuid,                       
                         mealPeriodId=_mealperiod                                                                  
                     }
                },
                 new EmbeddedMenuCycleItemProperty
                {
                     Class = new List<string>{"MenuCycleItem"},
                     rel =new List<string>{"/rels/MenuCycle"},
                     Properties = new MenuCycleItemsEntityProperties
                     {
                         menuCycleItemId =menuCycleItemId._menuCycleItemId,
                         day= _day,
                         order=_order,
                         recipeId=recipeId,                    
                         mealPeriodId=_mealperiod                                                                  
                     }
                }
                
                

            };

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


        [Then(@"the following MenuCycleitem propertie collection is returned")]
        public void ThenTheFollowingMenuCycleitemPropertieCollectionIsReturned(Table table)
        {
            var response = ScenarioContext.Current.Get<RestResponse>("Response");
            // var listOfMenuCycles = JsonConvert.DeserializeObject<ApiTests.Domain.Siren.PagedCollectionEntity<MenuCycleItemsEntity<MenuCycleItemsEntityProperties>>>(response.Content);
            var listOfMenuCycles = JsonConvert.DeserializeObject<ApiTests.Domain.Siren.PagedCollectionEntity<MenuCycleItemEntity<MenuCycleItemsEntityProperties>>>(response.Content);
            table.CompareToSet<MenuCycleItemsEntityProperties>(listOfMenuCycles.entities.Select(x => x.properties));


        }


        [Then(@"the following MenuCycleItem entities are returned")]
        public void  ThenTheFollowingMenuCycleItemEntitiesAreReturned(Table table)
        {

      
            var response = ScenarioContext.Current.Get<RestResponse>("Response");
            var embeddedLink = JsonConvert.DeserializeObject<PagedCollectionEntity<EmbeddedLink>>(response.Content);

            var links = table.CreateDynamicInstance();

            foreach (var entity in embeddedLink.entities)
            {
                var cls = entity.Class.First();
                var Rel = entity.rel.First();
                if ((cls == "MenuCycleItem") && (Rel == "/rels/menucycle/item"))
                {  
                    continue;
                }
                else
                {
                    throw new Exception("Items links MenucycleItem and rels are not Found!");
                }
            }
  


        }


    }




}





