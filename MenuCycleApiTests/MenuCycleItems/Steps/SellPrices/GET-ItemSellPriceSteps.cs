using ApiTests.Domain.Model;
using ApiTests.Domain.Siren;
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

namespace MenuCycleApiTests_ci.MenuCycleItems.Steps.SellPrices
{

    [Binding]
    public class GET_ItemSellPriceSteps
    {

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

                if ((cls == "SellPrice") && (Rel == "/rel/SellPrice"))
                {

                    continue;
                }
                else
                {
                    throw new Exception("Entites are not equal");
                }
            }

        }


    }

}
