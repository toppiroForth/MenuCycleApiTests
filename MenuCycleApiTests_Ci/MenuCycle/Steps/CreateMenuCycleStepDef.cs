using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using MenuCycleApiTests_ci.Domain.Model;

namespace MenuCycleApiTests_ci.MenuCycleTests.MenuCyclesStepDefs
{
    [Binding]
    public class CreateMenuCycleStepDef
    {



        [When(@"the '(.*)' group '(.*)' and '(.*)' request sent to server")]
        public void WhenTheGroupsAndRequestSentToServer(string group, int groupOneId, int groupTwoId)
        {

            // get the request
            var request = ScenarioContext.Current.Get<RestRequest>("Request");
            //add body to request 
            var entity = new MenuCycleEntity<Dictionary<string, object>>();
            entity.@class.Add("MenuCycle");
            entity.rel.Add("/rels/MenuCycle");

            Dictionary<string, object> props = new Dictionary<string, object>()
            {
                {"menuCycleId", 0},
                {"name","Test verify"},
                { "description","Test description"},
                {"parentId",0},
                {"isPublished","false"},
                {"isMaster","false"},
                { "nonServingDays",0}
            };

            entity.properties = props;

            if (group == "single")
            {
                entity.entities = new List<EmbeddedProperty>
                {
                    new EmbeddedProperty
                    {
                         Class = new List<string>{"Group"},
                         rel =new List<string>{"/rels/Group"},

                         Properties = new  MenuCycleApiTests_ci.Domain.Model.Properties2
                         {
                             groupId = groupOneId
                         }
                    }
                };
            }
            else if (group == "multiple")
            {
                entity.entities = new List<EmbeddedProperty>
                {
                    new EmbeddedProperty
                    {
                         Class = new List<string>{"Group"},
                         rel =new List<string>{"/rels/Group"},
                         Properties = new MenuCycleApiTests_ci.Domain.Model.Properties2
                         {
                             groupId = groupTwoId
                         }
                    },
                      new EmbeddedProperty
                    {
                         Class = new List<string>{"Group"},
                         rel =new List<string>{"/rels/Group"},
                         Properties = new MenuCycleApiTests_ci.Domain.Model.Properties2
                         {
                             groupId = groupOneId
                         }
                    }
                };
            }
            else if (group == "not associated")
            {
                entity.entities = new List<EmbeddedProperty>
                {
                    new EmbeddedProperty
                    {
                         Class = new List<string>{"Group"},
                         rel =new List<string>{"/rels/Group"},
                         Properties = new MenuCycleApiTests_ci.Domain.Model.Properties2
                         {
                             groupId = groupOneId
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

        [Then(@"bad request status are returned by server")]
        public void ThenBadRequestStatusAreReturnedByServer()
        {

            var response = ScenarioContext.Current.Get<RestResponse>("Response");
            Assert.AreEqual(HttpStatusCode.BadRequest, response.StatusCode);
        }






    }
}
