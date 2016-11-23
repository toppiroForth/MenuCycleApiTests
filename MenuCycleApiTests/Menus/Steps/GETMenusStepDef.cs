using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using MenuCycleApiTests_ci.Domain.Models;
using ApiTests.Domain.Siren;
using TechTalk.SpecFlow.Assist;
using ApiTests.Domain.Model;
namespace MenuCycleApiTests_ci.Menus.Steps
{

    [Binding]
    public class GETMenusStepDef
    {

        [Then(@"the following Menus propertie collection is returned by the server")]
        public void ThenTheFollowingMenusPropertieCollectionIsReturnedByTheServer(Table table)
        {
            var response = ScenarioContext.Current.Get<RestResponse>("Response");
            var Menus = JsonConvert.DeserializeObject<PagedCollectionEntity<MenusItemEntity<MenusItemsProperties>>>(response.Content);
            table.CompareToSet<MenusItemsProperties>(Menus.entities.Select(x => x.properties));

        }



        [Then(@"the following Menu entities are class '(.*)' and rel '(.*)'are returned")]
        public void ThenTheFollowingMenuEntitiesAreClassAndRelAreReturned(string Class, string rel)
        {

            var response = ScenarioContext.Current.Get<RestResponse>("Response");
            var embeddedLink = JsonConvert.DeserializeObject<PagedCollectionEntity<EmbeddedLink>>(response.Content);

            foreach (var entity in embeddedLink.entities)
            {
                var cls = entity.Class.First();
                var Rel = entity.rel.First();

                if ((cls == Class) && (Rel == rel))
                {
                    continue;
                }
                else
                {
                    throw new Exception("Items links Mealperiods and rels are not Found!");
                }
            }
        }


        [Then(@"the following menu propertie are returned by the server")]
        public void ThenTheFollowingMenuPropertieAreReturnedByTheServer(Table table)
        {
            var response = ScenarioContext.Current.Get<RestResponse>("Response");
            var menu = JsonConvert.DeserializeObject<MenusItemEntity<MenusItemsProperties>>(response.Content);
            table.CompareToInstance<MenusItemsProperties>(menu.properties);

 
        }

        [Then(@"the following Menusentites entities are returned")]
        public void ThenTheFollowingMenusentitesEntitiesAreReturned(Table table)
        {
            ScenarioContext.Current.Pending();
        }



    }
}
