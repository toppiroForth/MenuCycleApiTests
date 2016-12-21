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

namespace MenuCycleApiTests_ci.Locations.Steps
{

    [Binding]
    public class LocationStepDef
    {
        private readonly MenuCycleRecord menuCycleRecord;
        public LocationStepDef(MenuCycleRecord menuCycleRecord)
        {
            this.menuCycleRecord = menuCycleRecord;
        }

        [Then(@"user should get the first locationId from response")]
        public void ThenUserShouldGetTheFirstLocationIdFromResponse()
        {

            var response = ScenarioContext.Current.Get<RestResponse>("Response");
            var locations = JsonConvert.DeserializeObject<PagedCollectionEntity<LocationItemEntity<LocationsItemProperties>>>(response.Content);
            foreach (var location in locations.entities)
            {
                menuCycleRecord.idList.Add(location.properties.locationId);
            }
            menuCycleRecord.Id = menuCycleRecord.idList.First();
            Console.WriteLine("the last menu id " + menuCycleRecord.Id);

        }

        [Then(@"the following locations propertie collection is returned by the server")]
        public void ThenTheFollowingLocationsPropertieCollectionIsReturnedByTheServer(Table table)
        {
            var response = ScenarioContext.Current.Get<RestResponse>("Response");
            var locations = JsonConvert.DeserializeObject<PagedCollectionEntity<LocationItemEntity<LocationsItemProperties>>>(response.Content);
            table.CompareToSet<LocationsItemProperties>(locations.entities.Select(x => x.properties));
           
        }


        [Then(@"the following single location properties are returned")]
        public void ThenTheFollowingSingleLocationPropertiesAreReturned(Table table)
        {

            var response = ScenarioContext.Current.Get<RestResponse>("Response");
            var locations = JsonConvert.DeserializeObject<LocationItemEntity<LocationsItemProperties>>(response.Content);
            table.CompareToInstance<LocationsItemProperties>(locations.properties);
            
        }


















    }
}
