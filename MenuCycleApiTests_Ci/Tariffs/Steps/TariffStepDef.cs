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

namespace MenuCycleApiTests_ci.Tariffs.Steps
{

    [Binding]
    public class TariffStepDef
    {

         private readonly MenuCycleRecord menuCycleRecord;

         public TariffStepDef(MenuCycleRecord menuCycleRecord)
        {
            this.menuCycleRecord = menuCycleRecord;
        }

        [Then(@"user should get the first tarifflId from response")]
        public void ThenUserShouldGetTheFirstTarifflIdFromResponse()
        {
            var response = ScenarioContext.Current.Get<RestResponse>("Response");
            var tariffs = JsonConvert.DeserializeObject<PagedCollectionEntity<TariffsItemEntity<TariffsItemProperties>>>(response.Content);
            foreach (var tariff in tariffs.entities)
            {
                menuCycleRecord.idList.Add(tariff.properties.tariffId);
            }
            menuCycleRecord.Id = menuCycleRecord.idList.First();
            Console.WriteLine("the last menu id " + menuCycleRecord.Id);     
        }

        [Then(@"the following tariffs propertie collection is returned by the server")]
        public void ThenTheFollowingTariffsPropertieCollectionIsReturnedByTheServer(Table table)
        {

            var response = ScenarioContext.Current.Get<RestResponse>("Response");
            var tariffs = JsonConvert.DeserializeObject<PagedCollectionEntity<TariffsItemEntity<TariffsItemProperties>>>(response.Content);
            table.CompareToSet<TariffsItemProperties>(tariffs.entities.Select(x => x.properties));                
        
        }
        [Then(@"the following single tariff properties are returned")]
        public void ThenTheFollowingSingleTariffPropertiesAreReturned(Table table)
        {
            var response = ScenarioContext.Current.Get<RestResponse>("Response");
            var tariffs = JsonConvert.DeserializeObject<TariffsItemEntity<TariffsItemProperties>>(response.Content);
            table.CompareToInstance<TariffsItemProperties>(tariffs.properties);        
        }







    }
}
