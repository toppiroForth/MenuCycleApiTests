using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using ApiTests.Domain.Model;

namespace MenuCycleApiTests.MenuCycleTests.MenuCyclesStepDefs
{
    [Binding]
    public class UpdateMenuCycleStepDefs
    {



        [When(@"the update request ""(.*)"" ""(.*)"" (.*) contains the following body")]
        public void WhenTheUpdateRequestContainsTheFollowingBody(string name, string desc, int nonSer)
        {
            // get the request
            var request = ScenarioContext.Current.Get<RestRequest>("Request");
            //add body to request 
            var entity = new MenuCycleEntity<Dictionary<string, object>>();
            entity.@class.Add("MenuCycle");
            entity.rel.Add("/rels/MenuCycle");
            Dictionary<string, object> props = new Dictionary<string, object>()
            {
                { "menuCycleId", 30},
                { "name", name + DateTime.Now},
                { "description", desc},
                {"nonServingDays",nonSer}
            };
            entity.properties = props;
            entity.entities = new List<EmbeddedProperty>
            {
                new EmbeddedProperty
                {
                     Class = new List<string>{"Group"},
                     rel =new List<string>{"/rels/Group"},
                     Properties = new ApiTests.Domain.Model.Properties2
                     {
                         groupId = 25
                     }
                }
            };
            //using CamelCasePropertyNames
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
