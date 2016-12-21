using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using MenuCycleApiTests_ci.Domain.Model;
using MenuCycleApiTests_ci.GlobalData;

namespace MenuCycleApiTests_ci.MenuCycleTests.MenuCyclesStepDefs
{
    [Binding]
    public class UpdateMenuCycleStepDefs
    {
  
        private readonly MenuCycleRecord menuCycleLastId;

        public UpdateMenuCycleStepDefs( MenuCycleRecord menuCycleLastId)
        {   
            this.menuCycleLastId = menuCycleLastId;
        }

        [When(@"the user update the record with name '(.*)' description '(.*)' and nonServingdata (.*)")]
        public void WhenTheUserUpdateTheRecordWithNameDescriptionAndNonServingdata(string name, string desc, int nonSer)
        {
            // get the request
            var request = ScenarioContext.Current.Get<RestRequest>("Request");
            //add body to request 
            var entity = new MenuCycleEntity<Dictionary<string, object>>();
            entity.@class.Add("MenuCycle");
            entity.rel.Add("/rels/MenuCycle");
            Dictionary<string, object> props = new Dictionary<string, object>()
            {
                { "menuCycleId", menuCycleLastId._menuCycleId},
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
                     Properties = new MenuCycleApiTests_ci.Domain.Model.Properties2
                     {
                         groupId = 95
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




        [When(@"user issues '(.*)' request to update last record against the '(.*)' and '(.*)'")]
        public void WhenUserIssuesRequestToUpdateLastRecordAgainstTheAnd(string httpVerb, string resourceCollection, string p2)
        {

            // request method
            Method method;
            Method.TryParse(httpVerb, out method);

            int lastMenucycleid = menuCycleLastId._menuCycleId;


            // generate a request based on that URI
            var request = new RestRequest(resourceCollection + "/" + lastMenucycleid, method);
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

    }
}
