using MenuCycleApiTests_ci.Domain.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using MenuCycleApiTests_ci.Domain.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using MenuCycleApiTests_ci.GlobalData;

namespace MenuCycleApiTests_ci.MenuCycleItems.Steps
{

    [Binding]
    public class CreateMenuCycleItemStepDef
    {
    
        private readonly MenuCycleRecord menuCycleLastId;

        public CreateMenuCycleItemStepDef(LoginData loginData, MenuCycleRecord menuCycleLastId)
        {     
            this.menuCycleLastId = menuCycleLastId;
        }


        [When(@"Item request contains mealpriod (.*) and the '(.*)' with id (.*)")]
        public void WhenItemRequestContainsMealpriodAndTheWithId(int mealperiod, string itemName, int id)
        {
             
            // get the request
            var request = ScenarioContext.Current.Get<RestRequest>("Request");
            //add body to request 
            var entity = new MenuCycleItemEntity<Dictionary<string, object>>();
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
                         menuId=id,
                         mealPeriodId=mealperiod                                                                  
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
                             recipeId=id,
                             mealPeriodId=mealperiod
                                                                  
                         }
                    }
                };

            }
            else if (itemName == "MenuRecipe")
            {  
                int menu = id / 100;
                int recipe = id % 100;
  

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
                              menuId=menu,
                             mealPeriodId=mealperiod
                                                                   
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
                             recipeId=recipe,
                             mealPeriodId=mealperiod
                                                                   
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

        [When(@"Item request contains mealpriod (.*) and the '(.*)' with mneu id (.*) recipeid (.*)")]
        public void WhenItemRequestContainsMealpriodAndTheWithMneuIdRecipeid(int mealperiod, string itemName, int menuid, int recipeid)
        {
            // get the request
            var request = ScenarioContext.Current.Get<RestRequest>("Request");
            //add body to request 
            var entity = new MenuCycleItemEntity<Dictionary<string, object>>();
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
                         menuId=menuid,
                         mealPeriodId=mealperiod                                                                  
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
                             recipeId=recipeid,
                             mealPeriodId=mealperiod
                                                                  
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
                              menuId=menuid,
                             mealPeriodId=mealperiod
                                                                   
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
                             recipeId=recipeid,
                             mealPeriodId=mealperiod
                                                                   
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


        [When(@"the '(.*)' with id (.*) request contains the following body")]
        public void WhenTheWithIdRequestContainsTheFollowingBody(string p0, int p1)
        {
            Console.WriteLine("Under development........");
        }



        [When(@"the '(.*)' not associated request contains the following body")]
        public void WhenTheNotAssociatedRequestContainsTheFollowingBody(string itemName)
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


        [When(@"user issues '(.*)' request against a menucycle '(.*)' and '(.*)'")]
        public void WhenUserIssuesRequestAgainstAMenucycleAnd(string httpVerb, string resourceCollection, string individualResource = "")
        {

            // request method
            Method method;
            Method.TryParse(httpVerb, out method);


            // generate a request based on that URI
            var request = new RestRequest(resourceCollection + menuCycleLastId._menuCycleId + individualResource, method);

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

        [When(@"user issues '(.*)' request against a menucycleitem '(.*)' and '(.*)'")]
        public void WhenUserIssuesRequestAgainstAMenucycleitemAnd(string httpVerb, string resourceCollection, string individualResource = "")
        {

           // request method
            Method method;
            Method.TryParse(httpVerb, out method);
            int lastMenucycleItemid = menuCycleLastId._menuCycleItemId;

            // generate a request based on that URI
            var request = new RestRequest(resourceCollection + menuCycleLastId._menuCycleId + individualResource + "/" + lastMenucycleItemid, method);

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

        [When(@"Items request contains mealpriod (.*) and the '(.*)' with id (.*)")]
        public void WhenItemsRequestContainsMealpriodAndTheWithId(int mealperiod, string itemName, int id)
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
                         day=9,
                         order=1,
                         menuId=id,
                         mealPeriodId=mealperiod                                                                  
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
                         menuId=id,
                         mealPeriodId=mealperiod                                                                  
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
                         menuId=id,
                         mealPeriodId=mealperiod                                                                  
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
                         menuId=id,
                         mealPeriodId=mealperiod                                                                  
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
                         menuId=id,
                         mealPeriodId=mealperiod                                                                  
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
                         menuId=id,
                         mealPeriodId=mealperiod                                                                  
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
                         menuId=id,
                         mealPeriodId=mealperiod                                                                  
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
                         menuId=id,
                         mealPeriodId=mealperiod                                                                  
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
                         menuId=id,
                         mealPeriodId=mealperiod                                                                  
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
                         menuId=id,
                         mealPeriodId=mealperiod                                                                  
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
                         menuId=id,
                         mealPeriodId=mealperiod                                                                  
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
