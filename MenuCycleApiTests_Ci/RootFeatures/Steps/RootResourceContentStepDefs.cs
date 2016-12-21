using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using RestSharp;
using Newtonsoft.Json;
using TechTalk.SpecFlow.Assist;
using MenuCycleApiTests_ci.Domain.Models;
using NUnit.Framework;
using MenuCycleApiTests_ci.Domain.Siren;
using MenuCycleApiTests_ci.Domain.Model;

namespace MenuCycleApiTests_ci.RootFeatuer
{
    [Binding]
    public class RootResourceContent
    {

        [Then(@"the following root properites are returned")]
        public void ThenTheFollowingRootProperitesAreReturned(Table table)
        {
            var responce = ScenarioContext.Current.Get<RestResponse>("Response");
            var root = JsonConvert.DeserializeObject<RootEntity<RootProperties>>(responce.Content);                     
            table.CompareToInstance<RootProperties>(root.properties);
         
        }

        [Then(@"the following root entities are returned")]
        public void ThenTheFollowingRootEntitiesAreReturned(Table table)
        {


            var response = ScenarioContext.Current.Get<RestResponse>("Response");
            var embadedLinks = JsonConvert.DeserializeObject<PagedCollectionEntity<EmbeddedLink>>(response.Content);

            foreach (var entity in embadedLinks.entities)
            {
                var cls = entity.Class.First();
                var Rel = entity.rel.First();
                var herf = entity.href.AbsoluteUri;
                var valid = table.Rows.Any(x => x["Class"] == cls && x["rel"] == Rel && x["href"] == herf);
                if (!valid)
                {
                    throw new Exception("Items Menu entities class  and rels are not Found!");
                }
            }

           
        }

    }
}
