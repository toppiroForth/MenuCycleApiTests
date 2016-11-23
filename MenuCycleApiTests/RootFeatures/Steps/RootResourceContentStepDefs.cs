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

namespace MenuCycleApiTests_ci.RootFeatuer
{
    [Binding]
    public class RootResourceContent
    {

        [Then(@"the following root properites are returned")]
        public void ThenTheFollowingRootProperitesAreReturned(Table table)
        {
            //var responce = ScenarioContext.Current.Get<RestResponse>("Response");
           // var root = JsonConvert.DeserializeObject<MenuCycleEntity<RootProperties>>(responce.Content);
          // tableproperites = table.CreateInstance<MenuCycleEntity<RootProperties>>();
         

        }


    
    }
}
