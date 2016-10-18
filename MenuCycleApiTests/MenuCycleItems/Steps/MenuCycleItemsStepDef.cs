using RestSharp;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Newtonsoft.Json;
using MenuCycleApiTests.Domain.Models;

namespace MenuCycleApiTests.MenuCycleItems.MenuCycleItemsStepDef
{
    [Binding]
    public class MenuCycleItemCollectionsSteps
    {
        [Then(@"the following MenuCycleitem propertie collection is returned")]
        public void ThenTheFollowingMenuCycleitemPropertieCollectionIsReturned(Table table)
        {
            var response = ScenarioContext.Current.Get<RestResponse>("Response");
            // var listOfMenuCycles = JsonConvert.DeserializeObject<ApiTests.Domain.Siren.PagedCollectionEntity<MenuCycleItemsEntity<MenuCycleItemsEntityProperties>>>(response.Content);
            var listOfMenuCycles = JsonConvert.DeserializeObject<ApiTests.Domain.Siren.PagedCollectionEntity<MenuCycleItemsEntity<MenuCycleItemsEntityProperties>>>(response.Content);

           // table.CompareToSet<MenuCycleItemsEntity<MenuCycleItemsEntityProperties>>(listOfMenuCycles.entities);
           
            
            //


            foreach (var entite in listOfMenuCycles.entities)
            {
            //    entite.Equals(account);
            }

            //var menuCycle = JsonConvert.DeserializeObject<ApiTests.Domain.Siren.PagedCollectionEntity<MenuCycleItemsEntityProperties>>(response.Content);
           

        }
    }
}
