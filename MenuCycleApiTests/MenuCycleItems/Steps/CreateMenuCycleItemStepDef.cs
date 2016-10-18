using MenuCycleApiTests.Domain.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using ApiTests.Domain.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace MenuCycleApiTests.MenuCycleItems.Steps
{

    [Binding]
    public class CreateMenuCycleItemStepDef
    {


        [When(@"the '(.*)' request contains the following body")]
        public void WhenTheRequestContainsTheFollowingBody(string itemName)
        {
            // get the request
            var request = ScenarioContext.Current.Get<RestRequest>("Request");
            //add body to request 
            var entity = new MenuCycleItemsEntity<Dictionary<string, object>>();
            entity.@class.Add("MenuCycleItems");


            if (itemName == "Menu")
            {
                entity.entities = new List<EmbeddedMenuCycleItemProperty>
            {
                new EmbeddedMenuCycleItemProperty
                {
                     Class = new List<string>{"MenuCycleItem"},
                     rel =new List<string>{"/rels/MenuCycle"},
                     Properties = new MenuCycleItemsEntityProperties
                     {
                         day=9,
                         order=1,
                         menuId=9,
                         mealPeriodId=4                                                                   
                     }
                }
            };
            }
            else if (itemName == "Recipe")
            {

                entity.entities = new List<EmbeddedMenuCycleItemProperty>
                {
                    new EmbeddedMenuCycleItemProperty
                    {
                         Class = new List<string>{"MenuCycleItem"},
                         rel =new List<string>{"/rels/MenuCycle"},
                         Properties = new MenuCycleItemsEntityProperties
                         {                                
                             day=9,
                             order=1,
                             recipeId=6,
                             mealPeriodId=4
                                                                  
                         }
                    }
                };

            }
            else if (itemName == "MenuRecipe")
            {
                entity.entities = new List<EmbeddedMenuCycleItemProperty>
                {
                    new EmbeddedMenuCycleItemProperty
                    {
                         Class = new List<string>{"MenuCycleItem"},
                         rel =new List<string>{"/rels/MenuCycle"},
                         Properties = new MenuCycleItemsEntityProperties
                         {
                             day=9,
                             order=1,
                              menuId=9,
                             mealPeriodId=4
                                                                   
                         }
                    },
                    new EmbeddedMenuCycleItemProperty
                    {
                         Class = new List<string>{"MenuCycleItem"},
                         rel =new List<string>{"/rels/MenuCycle"},
                         Properties = new MenuCycleItemsEntityProperties
                         {
                             day=9,
                             order=1,
                             recipeId=6,
                             mealPeriodId=4
                                                                   
                         }
                    }
                };

            }
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


        [When(@"the '(.*)' not associated request contains the following body")]
        public void WhenTheNotAssociatedRequestContainsTheFollowingBody(string itemName)
        {
            // get the request
            var request = ScenarioContext.Current.Get<RestRequest>("Request");
            //add body to request 
            var entity = new MenuCycleItemsEntity<Dictionary<string, object>>();
            entity.@class.Add("MenuCycleItems");
            entity.entities = new List<EmbeddedMenuCycleItemProperty>
            {
                new EmbeddedMenuCycleItemProperty
                {
                     Class = new List<string>{"MenuCycleItem"},
                     rel =new List<string>{"/rels/MenuCycle"},
                     Properties = new MenuCycleItemsEntityProperties
                     {
                         day=9,
                         order=1,
                         menuId=8,
                         mealPeriodId=4                                                                   
                     }
                },
                 new EmbeddedMenuCycleItemProperty
                {
                     Class = new List<string>{"MenuCycleItem"},
                     rel =new List<string>{"/rels/MenuCycle"},
                     Properties = new MenuCycleItemsEntityProperties
                     {
                         day=9,
                         order=1,
                        recipeId=5,
                         mealPeriodId=4                                                                   
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




    }
}
