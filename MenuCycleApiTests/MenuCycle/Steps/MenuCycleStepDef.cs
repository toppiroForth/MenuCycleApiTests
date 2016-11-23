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
using ApiTests.Domain.Model;
using System.Net;
using NUnit.Framework;
using System.Collections;
using MenuCycleApiTests_ci.GlobalData;
using ApiTests.Domain.Siren;

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

        [Then(@"the following MenuCycle propertie collection is returned by the server")]
        public void ThenTheFollowingMenuCyclePropertieCollectionIsReturnedByTheServer(Table table)
        {
            var response = ScenarioContext.Current.Get<RestResponse>("Response");
            var menuCycles = JsonConvert.DeserializeObject<ApiTests.Domain.Siren.PagedCollectionEntity<MenuCycleEntity<MenuCycleProperties>>>(response.Content);
            //var propertiesList = menuCycles.entities.Select(x => x.properties);        
            table.CompareToSet<MenuCycleProperties>(menuCycles.entities.Select(x => x.properties));

        }

        [Then(@"the following MenuCycle entities are returned")]
        public void ThenTheFollowingMenuCycleEntitiesAreReturned(Table table)
        {
    
            var response = ScenarioContext.Current.Get<RestResponse>("Response");
            var embeddedLink = JsonConvert.DeserializeObject<PagedCollectionEntity<EmbeddedLink>>(response.Content);


            foreach (var entity in embeddedLink.entities)
            {
                var cls = entity.Class.First();
                var Rel = entity.rel.First();
                if ((cls == "MenuCycle") && (Rel == "/rels/menucycle"))
                {
                 
                    continue;
                }
                else
                {
                    throw new Exception("Links are not equal");
                }
            }
        }

        [Then(@"the follwing links are returned")]
        public void ThenTheFollwingLinksAreReturned(Table table)
        {

            var response = ScenarioContext.Current.Get<RestResponse>("Response");
            var _links = JsonConvert.DeserializeObject<ApiTests.Domain.Siren.PagedCollectionEntity<Link>>(response.Content);
            table.CompareToSet<Link>(_links.links);
        }

        [Then(@"the following Actions are returned")]
        public void ThenTheFollowingActionsAreReturned(Table table)
        {
            var response = ScenarioContext.Current.Get<RestResponse>("Response");
            var _actions = JsonConvert.DeserializeObject<ApiTests.Domain.Siren.PagedCollectionEntity<Actions>>(response.Content);
            table.CompareToSet<Actions>(_actions.Actions);
        }



        [Then(@"user should get the last menuCycleId from response")]
        public void ThenUserShouldGetTheLastMenuCycleIdFromResponse()
        {

            var response = ScenarioContext.Current.Get<RestResponse>("Response");
            var menuCycle = JsonConvert.DeserializeObject<MenuCycleEntity<MenuCycleProperties>>(response.Content);
            ///table.CompareToSet<MenuCycleProperties>(menuCycle.entities);
            //  var details = table.CreateDynamicSet();          
              menuCycleLastId._menuCycleId =  menuCycle.properties.menuCycleId;
      
            Console.WriteLine("MenuCycle id " + menuCycleLastId._menuCycleId);
        }

        [Then(@"No record found exception returned by server")]
        public void ThenNoRecordFoundExceptionReturnedByServer()
        {
            var response = ScenarioContext.Current.Get<RestResponse>("Response");
            Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode);
        }


    }
}
