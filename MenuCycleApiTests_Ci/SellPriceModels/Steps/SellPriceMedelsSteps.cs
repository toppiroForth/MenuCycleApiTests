using MenuCycleApiTests_ci.Domain.Models;
using MenuCycleApiTests_ci.Domain.Siren;
using MenuCycleApiTests_ci.GlobalData;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
namespace MenuCycleApiTests_ci.SellPriceModels.Steps
{

    [Binding]
    public class SellPriceMedelsSteps
    {

        private readonly MenuCycleRecord menuCycleRecord;

        public SellPriceMedelsSteps(MenuCycleRecord menuCycleRecord)
        {
            this.menuCycleRecord = menuCycleRecord;
        }

        [Then(@"user should get the first SellPriceModelId from response")]
        public void ThenUserShouldGetTheFirstSellPriceModelIdFromResponse()
        {

            var response = ScenarioContext.Current.Get<RestResponse>("Response");
            var sellPriceModels = JsonConvert.DeserializeObject<PagedCollectionEntity<SellPriceModelsItemEntity<SellPriceModelsItemProperties>>>(response.Content);
            foreach (var sellPriceModel in sellPriceModels.entities)
            {
                menuCycleRecord.idList.Add(sellPriceModel.properties.sellPriceModelId);
            }
            menuCycleRecord.Id = menuCycleRecord.idList.First();
            Console.WriteLine("the last menu id " + menuCycleRecord.Id);
        }

        [Then(@"the following sellPriceModels propertie collection is returned by the server")]
        public void ThenTheFollowingSellPriceModelsPropertieCollectionIsReturnedByTheServer(Table table)
        {
            var response = ScenarioContext.Current.Get<RestResponse>("Response");
            var sellPriceModels = JsonConvert.DeserializeObject<PagedCollectionEntity<SellPriceModelsItemEntity<SellPriceModelsItemProperties>>>(response.Content);
            table.CompareToSet<SellPriceModelsItemProperties>(sellPriceModels.entities.Select(x => x.properties));                
        }


        [Then(@"the following single sellpriceModel properties are returned")]
        public void ThenTheFollowingSingleSellpriceModelPropertiesAreReturned(Table table)
        {

            var response = ScenarioContext.Current.Get<RestResponse>("Response");
            var sellpriceModels = JsonConvert.DeserializeObject<SellPriceModelsItemEntity<SellPriceModelsItemProperties>>(response.Content);
            table.CompareToInstance<SellPriceModelsItemProperties>(sellpriceModels.properties);
           
        }





    }
}
