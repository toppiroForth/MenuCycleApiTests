using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using RestSharp;
using RestSharp.Authenticators;
using Newtonsoft.Json;
using MenuCycleApiTests_ci.Domain.Model;
using System.Net;
using NUnit.Framework;
using System.Collections;
using MenuCycleApiTests_ci.GlobalData;
using MenuCycleApiTests_ci.Domain.Siren;
using System.Data.SqlClient;

namespace MenuCycleApiTests_ci.MenuCycleTests
{
    [Binding]
    public class MenuCycleStepDef
    {
        private readonly MenuCycleRecord menuCycleLastId;

        public MenuCycleStepDef(MenuCycleRecord menuCycleLastId)
        {
            this.menuCycleLastId = menuCycleLastId;
        }

        [Then(@"the following MenuCycle properites is returned")]
        public void ThenTheFollowingMenuCycleProperitesIsReturned(Table table)
        {

            var response = ScenarioContext.Current.Get<RestResponse>("Response");
            var menucycle = JsonConvert.DeserializeObject<MenuCycleEntity<MenuCycleProperties>>(response.Content);
            table.CompareToInstance<MenuCycleProperties>(menucycle.properties);
        }

        [Then(@"the following MenuCycle single entities are returned")]
        public void ThenTheFollowingMenuCycleSingleEntitiesAreReturned(Table table)
        {  
            var response = ScenarioContext.Current.Get<RestResponse>("Response");
            var embeddedLink = JsonConvert.DeserializeObject<MenuCycleEntity<EmbeddedLink>>(response.Content);

            string className =null;
            string relName = null;

            for (int i = 0; i < table.Rows.Count; i++)
            {

                className = table.Rows[i]["Class"];
                relName = table.Rows[i]["rel"];
                // string herf = table.Rows[i]["herf"];
                var result = embeddedLink.entities.Any(x => x.Class.First() == className && x.rel.First() == relName);
                if (!result)
                {
                    throw new Exception("class and rel not present in the entities");
                }
              
            }
           
        }



        [Then(@"the following menucycle Actions entities are returned")]
        public void ThenTheFollowingMenucycleActionsEntitiesAreReturned(Table table)
        {
            var response = ScenarioContext.Current.Get<RestResponse>("Response");
            var entitiesActions = JsonConvert.DeserializeObject<MenuCycleEntity<Actions>>(response.Content);
            table.CompareToSet<Actions>(entitiesActions.Actions);
        
        }


        [Then(@"the following MenuCycle propertie collection is returned by the server")]
        public void ThenTheFollowingMenuCyclePropertieCollectionIsReturnedByTheServer(Table table)
        {
            var response = ScenarioContext.Current.Get<RestResponse>("Response");
            var menuCycles = JsonConvert.DeserializeObject<PagedCollectionEntity<MenuCycleEntity<MenuCycleProperties>>>(response.Content);
            table.CompareToSet<MenuCycleProperties>(menuCycles.entities.Select(x => x.properties));

        }

        [Then(@"the following entities class and rel are returned")]
        public void ThenTheFollowingEntitiesClassAndRelAreReturned(Table table)
        {         
            var response = ScenarioContext.Current.Get<RestResponse>("Response");
            var embeddedLink = JsonConvert.DeserializeObject<PagedCollectionEntity<EmbeddedLink>>(response.Content);


            string Class = table.Rows.FirstOrDefault().FirstOrDefault(x => x.Key == "class").Value;
            String rel = table.Rows.FirstOrDefault().FirstOrDefault(x => x.Key == "rel").Value;

            foreach (var entity in embeddedLink.entities)
            {
                var cls = entity.Class.First();
                var Rel = entity.rel.First();
                //row.FirstOrDefault(x => x.Key == "href");

             
                if ((cls == Class) && (Rel ==rel))
                {

                    continue;
                }
                else
                {
                    throw new Exception("Links are not equal");
                }
            }
        }

        [Then(@"the following '(.*)' links returned")]
        public void ThenTheFollowingLinksReturned(string links, Table table)
        {
           
            int id = menuCycleLastId._menuCycleId;

            if (links == "href")
            {

                var response = ScenarioContext.Current.Get<RestResponse>("Response");
                var _links = JsonConvert.DeserializeObject<PagedCollectionEntity<Link>>(response.Content);
                // table.CompareToSet<Link>(_links.links);
                //var rows = table.Rows.Where(x => x.ContainsKey("href"));
                foreach (var row in table.Rows)
                {
                    var item = row.FirstOrDefault(x => x.Key == "href").Value;
                    if (!string.IsNullOrEmpty(item))
                    {
                        menuCycleLastId.href.Add(string.Format(item, id));
                    }
                }

                var result = Enumerable.SequenceEqual(
                    _links.links.Select(y => y.href).ToList().OrderBy(x => x),
                    menuCycleLastId.href.OrderBy(m => m));
            }
            else if (links == "Action href")
            {
                var response = ScenarioContext.Current.Get<RestResponse>("Response");
                var _actions = JsonConvert.DeserializeObject<MenuCycleApiTests_ci.Domain.Siren.PagedCollectionEntity<Actions>>(response.Content);

                foreach (var row in table.Rows)
                {
                    var item = row.FirstOrDefault(x => x.Key == "href").Value;
                    if (!string.IsNullOrEmpty(item))
                    {
                        menuCycleLastId.href.Add(string.Format(item, id));
                    }
                }

                var result = Enumerable.SequenceEqual(
                    _actions.Actions.Select(y => y.Href.AbsoluteUri).ToList().OrderBy(x => x),
                     menuCycleLastId.href.OrderBy(m => m));
            }        
        }


        [Then(@"the follwing links properties are returned")]
        public void ThenTheFollwingLinksAreReturned(Table table)
        {
            int id = menuCycleLastId._menuCycleId;
            var response = ScenarioContext.Current.Get<RestResponse>("Response");
            var _links = JsonConvert.DeserializeObject<PagedCollectionEntity<Link>>(response.Content);
            table.CompareToSet<Link>(_links.links);
           
        }

        [Then(@"the following Actions are returned")]
        public void ThenTheFollowingActionsAreReturned(Table table)
        {
            var response = ScenarioContext.Current.Get<RestResponse>("Response");
            var _actions = JsonConvert.DeserializeObject<MenuCycleApiTests_ci.Domain.Siren.PagedCollectionEntity<Actions>>(response.Content);
            table.CompareToSet<Actions>(_actions.Actions);
        }

        [Then(@"user should get the last menuCycleId from response")]
        public void ThenUserShouldGetTheLastMenuCycleIdFromResponse()
        {
            var response = ScenarioContext.Current.Get<RestResponse>("Response");
            var menuCycle = JsonConvert.DeserializeObject<MenuCycleEntity<MenuCycleProperties>>(response.Content);
            ///table.CompareToSet<MenuCycleProperties>(menuCycle.entities);
            //  var details = table.CreateDynamicSet();   
       
            menuCycleLastId._menuCycleId = menuCycle.properties.menuCycleId;
            Console.WriteLine("MenuCycle id " + menuCycleLastId._menuCycleId);


        }

        [Then(@"No record found exception returned by server")]
        public void ThenNoRecordFoundExceptionReturnedByServer()
        {
            var response = ScenarioContext.Current.Get<RestResponse>("Response");
            Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode);
        }

        [When(@"user issues '(.*)' request to get recent record against the '(.*)' and '(.*)'")]
        public void WhenUserIssuesRequestToGetRecentRecordAgainstTheAnd(string httpVerb, string resourceCollection, string p2)
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

        [Then(@"user should get the list of  menuCycleId from response")]
        public void ThenUserShouldGetTheListOfMenuCycleIdFromResponse()
        {
            var response = ScenarioContext.Current.Get<RestResponse>("Response");
            var menuCycle = JsonConvert.DeserializeObject<MenuCycleEntity<MenuCycleProperties>>(response.Content);
            ///table.CompareToSet<MenuCycleProperties>(menuCycle.entities);
            //  var details = table.CreateDynamicSet();          
            menuCycleLastId._menuCycleId = menuCycle.properties.menuCycleId;

            menuCycleLastId.idList.Add(menuCycle.properties.menuCycleId);
            Console.WriteLine("MenuCycle id " + menuCycleLastId._menuCycleId);
        }

        [When(@"user issues '(.*)' request to delete mencucycle using index '(.*)' against the '(.*)' and '(.*)'")]
        public void WhenUserIssuesRequestToDeleteMencucycleUsingIndexAgainstTheAnd(string httpVerb, int index, string resourceCollection, string p3)
        {
            // request method
            Method method;
            Method.TryParse(httpVerb, out method);
            int lastMenucycleid = menuCycleLastId.idList[index];

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

        [Then(@"its return the menucycles ids")]
        public void ThenItsReturnTheMenucyclesIds()
        {
            foreach (var item in menuCycleLastId.idList)
            {
                Console.WriteLine("these all are the ids" + item);
            }
        }

 
        [Given(@"the executable Menuservice stored procedure '(.*)' with id '(.*)' is executed against Staging Database")]
        public void GivenTheExecutableMenuserviceStoredProcedureWithNameIsExecutedAgainstStagingDatabase(string spName, int customerId)
        {
            var queryResults = Helpers.ExecuteStoredProToDeleteMenucycle(spName, new SqlParameter("@customerid", customerId));
            ScenarioContext.Current.AddNewRemoveExisting("queryResults", queryResults);
        }



    }
}
