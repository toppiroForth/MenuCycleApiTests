using MenuCycleApiTests_ci.Domain.Models;
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
    public class UpdateRecipeItemSteps
    {
        //[When(@"the update request (.*)  (.*)  (.*)  (.*) (.*) sent to server")]
        //public void WhenTheUpdateRequestSentToServer(int _day, int _order, int _menuid, int _mealperiod, int recipeId)
        //{
        //    // get the request
        //    var request = ScenarioContext.Current.Get<RestRequest>("Request");
        //    //add body to request 
        //    var entity = new MenuCycleItemsEntity<Dictionary<string, object>>();
        //    entity.@class.Add("MenuCycleItems");
        //    entity.entities = new List<EmbeddedMenuCycleItemProperty>
        //    {

        //    //    new EmbeddedMenuCycleItemProperty
        //    //    {
        //    //         Class = new List<string>{"MenuCycleItem"},
        //    //         rel =new List<string>{"/rels/MenuCycle"},
        //    //         Properties = new MenuCycleItemsEntityProperties
        //    //         {
        //    //             day= _day,
        //    //             order=_order,
        //    //             menuId=_menuid,
        //    //             mealPeriodId=_mealperiod                                                                  
        //    //         }
        //    //    },
        //    //     new EmbeddedMenuCycleItemProperty
        //    //        {
        //    //             Class = new List<string>{"MenuCycleItem"},
        //    //             rel =new List<string>{"/rels/MenuCycle"},
        //    //             Properties = new MenuCycleItemsEntityProperties
        //    //             {
        //    //                 day=9,
        //    //                 order=1,
        //    //                 recipeId=recipeId,
        //    //                 mealPeriodId=4
                                                                   
        //    //             }
        //    //        }
                



        //    };

        //    //changing PropertyNames into CamelCase
        //    var settings = new JsonSerializerSettings
        //    {
        //        ContractResolver = new CamelCasePropertyNamesContractResolver()
        //    };

        //    var obj = JsonConvert.SerializeObject(entity, Formatting.None, settings);

        //    request.AddParameter("application/vnd.siren+json", obj, ParameterType.RequestBody);

        //    // get the client
        //    var restClient = ScenarioContext.Current.Get<RestClient>("RestClient");

        //    //execute request and add response to context for later processing
        //    ScenarioContext.Current.AddNewRemoveExisting("Response", restClient.Execute(request));
        //}



    }
}
