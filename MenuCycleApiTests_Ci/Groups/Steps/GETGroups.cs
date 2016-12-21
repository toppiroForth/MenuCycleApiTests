using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Newtonsoft.Json;
using MenuCycleApiTests_ci.Domain.Models;
using MenuCycleApiTests_ci.Domain.Siren;
using MenuCycleApiTests_ci.GlobalData;
using MenuCycleApiTests_ci.Domain.Model;

namespace MenuCycleApiTests_ci.Groups
{

    [Binding]
    public class GETGroups
    {

        private readonly MenuCycleRecord menuCycleRecord;

        public GETGroups(MenuCycleRecord menuCycleRecord)
        {
            this.menuCycleRecord = menuCycleRecord;
        }


        [Then(@"the following Group propertie collection is returned by the server")]
        public void ThenTheFollowingGroupPropertieCollectionIsReturnedByTheServer(Table table)
        {
            var response = ScenarioContext.Current.Get<RestResponse>("Response");
            var groups = JsonConvert.DeserializeObject<PagedCollectionEntity<GroupItemEntity<GroupItemsProperties>>>(response.Content);
            table.CompareToSet<GroupItemsProperties>(groups.entities.Select(x => x.properties));

        }

        [Then(@"user should get the first groupId from response")]
        public void ThenUserShouldGetTheLastGroupIdFromResponse()
        {
            var response = ScenarioContext.Current.Get<RestResponse>("Response");
            var groups = JsonConvert.DeserializeObject<PagedCollectionEntity<GroupItemEntity<GroupItemsProperties>>>(response.Content);
            foreach (var group in groups.entities)
            {
                menuCycleRecord.idList.Add(group.properties.groupid);
             
            }
             menuCycleRecord.groupid = menuCycleRecord.idList.First();
             Console.WriteLine("the last menu id " + menuCycleRecord.groupid);
            
        }

        [When(@"user issues '(.*)' request against the single group '(.*)' and '(.*)'")]
        public void WhenUserIssuesRequestAgainstTheSingleGroupAnd(string httpVerb, string resourceCollection, string individualResource = "")
        {

            // request method
            Method method;
            Method.TryParse(httpVerb, out method);

            menuCycleRecord.groupid = menuCycleRecord.idList.First();

            // generate a request based on that URI
            var request = new RestRequest(resourceCollection + menuCycleRecord.groupid, method);

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

        [Then(@"the following single group properites is returned")]
        public void ThenTheFollowingSingleGroupProperitesIsReturned(Table table)
        {

            var response = ScenarioContext.Current.Get<RestResponse>("Response");
            var group = JsonConvert.DeserializeObject<GroupItemEntity<GroupItemsProperties>>(response.Content);
            table.CompareToInstance<GroupItemsProperties>(group.properties);

           // var response = ScenarioContext.Current.Get<RestResponse>("Response");
           // var menucycle = JsonConvert.DeserializeObject<MenuCycleEntity<MenuCycleProperties>>(response.Content);
           // table.CompareToInstance<MenuCycleProperties>(menucycle.properties);     
        }

        [Then(@"the following '(.*)' links returned for single group")]
        public void ThenTheFollowingLinksReturnedForSingleGroup(string links, Table table)
        {


            int id = menuCycleRecord.idList.First();

            var response = ScenarioContext.Current.Get<RestResponse>("Response");
            var embadedLinks = JsonConvert.DeserializeObject<GroupItemEntity<EmbeddedLink>>(response.Content);
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

           // var method = table.Rows.FirstOrDefault(row => row.FirstOrDefault(x => x.Key == "method")).Value;

           
        }
















    }


}
