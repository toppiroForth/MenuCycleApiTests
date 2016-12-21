using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MenuCycleApiTests_ci.MenuCycle.Steps
{
    [Binding]
    public class DeleteMenuCycle
    {
        [Then(@"Not Found response returen by server")]
        public void ThenNotFoundResponseReturenByServer()
        {
            var response = ScenarioContext.Current.Get<RestResponse>("Response");
            Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode);
           
        }


    }

}
