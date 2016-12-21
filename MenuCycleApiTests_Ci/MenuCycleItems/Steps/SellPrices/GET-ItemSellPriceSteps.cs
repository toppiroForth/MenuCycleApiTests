using MenuCycleApiTests_ci.Domain.Model;
using MenuCycleApiTests_ci.Domain.Siren;
using MenuCycleApiTests_ci.Domain.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using MenuCycleApiTests_ci.GlobalData;

namespace MenuCycleApiTests_ci.MenuCycleItems.Steps.SellPrices
{

    [Binding]
    public class GET_ItemSellPriceSteps
    {
        private readonly MenuCycleRecord menuCyclitemId;


        public GET_ItemSellPriceSteps(MenuCycleRecord menuCyclitemId)
        {
            this.menuCyclitemId = menuCyclitemId;
        }


        [Then(@"the following itemSellPrice propertie collection is returned")]
        public void ThenTheFollowingItemSellPricePropertieCollectionIsReturned(Table table)
        {
            var response = ScenarioContext.Current.Get<RestResponse>("Response");
            var listOfSellPrices = JsonConvert.DeserializeObject<PagedCollectionEntity<SellPriceEntity<SellPricesProperties>>>(response.Content);
            table.CompareToSet<SellPricesProperties>(listOfSellPrices.entities.Select(x => x.properties));

        }


        [Then(@"the following sellprices entities are returned")]
        public void ThenTheFollowingSellpricesEntitiesAreReturned(Table table)
        {


            var response = ScenarioContext.Current.Get<RestResponse>("Response");
            var embeddedLink = JsonConvert.DeserializeObject<PagedCollectionEntity<EmbeddedLink>>(response.Content);

            //var output = embeddedLink.entities.Select(x => new EmbeddedLink
            //{
            //    Class = x.Class,
            //    rel = x.rel
            //});

            foreach (var entity in embeddedLink.entities)
            {
                var cls = entity.Class.First();
                var Rel = entity.rel.First();


                if ((cls == "SellPrice" && Rel == "/rels/menucycle/item/sellprice"))
                {
                    continue;
                }
                else
                {
                    throw new Exception("Entites are not equal");
                }
            }

        }

        [When(@"user issues '(.*)' request against the sellPrices '(.*)' and '(.*)' and '(.*)' added")]
        public void WhenUserIssuesRequestAgainstTheSellPricesAndAndAdded(string httpVerb, string resourceCollection, string individualResource = "", string secondIndividualResource = "")
        {

            // request method
            Method method;
            Method.TryParse(httpVerb, out method);
            int lastMenucycleItemId = menuCyclitemId._menuCycleId;
            // Generate a request based on that URI
            var request = new RestRequest(resourceCollection + lastMenucycleItemId +individualResource+menuCyclitemId._menuCycleItemId+ secondIndividualResource, method);

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



        [Then(@"the following '(.*)' links returned for sellprices")]
        public void ThenTheFollowingLinksReturnedForSellprices(string links, Table table)
        {

            int id = menuCyclitemId._menuCycleId;
            int menucycleitemid = menuCyclitemId._menuCycleItemId;

            if (links == "herf")
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
                        menuCyclitemId.href.Add(string.Format(item, id, menucycleitemid));
                    }
                }

                var result = Enumerable.SequenceEqual(
                    _links.links.Select(y => y.href).ToList().OrderBy(x => x),
                    menuCyclitemId.href.OrderBy(m => m));
            }
            else if (links == "Action href")
            {
                var response = ScenarioContext.Current.Get<RestResponse>("Response");
                var _actions = JsonConvert.DeserializeObject<PagedCollectionEntity<Actions>>(response.Content);

                foreach (var row in table.Rows)
                {
                    var item = row.FirstOrDefault(x => x.Key == "href").Value;
                    if (!string.IsNullOrEmpty(item))
                    {
                        menuCyclitemId.href.Add(string.Format(item, id, menucycleitemid));
                    }
                }

                var result = Enumerable.SequenceEqual(
                    _actions.Actions.Select(y => y.Href.AbsoluteUri).ToList().OrderBy(x => x),
                     menuCyclitemId.href.OrderBy(m => m));

            }       
           
        }


        [When(@"user issues '(.*)' request against the sellPrices '(.*)' and '(.*)'")]
        public void WhenUserIssuesRequestAgainstTheSellPricesAnd(string httpVerb, string resourceCollection, string individualResource = "")
        {


            // request method
            Method method;
            Method.TryParse(httpVerb, out method);
            int lastMenucycleItemId = menuCyclitemId._menuCycleItemId;
            // Generate a request based on that URI
            var request = new RestRequest(resourceCollection + lastMenucycleItemId + individualResource, method);

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



    }

}
