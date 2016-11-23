using MenuCycleApiTests_ci.GlobalData;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MenuCycleApiTests_ci.MenuCycleItems.Steps
{

    [Binding]
    public class DeleteMenuCycleItemStep
    {

         private readonly MenuCycleRecord menuCycleLastId;

         public DeleteMenuCycleItemStep(LoginData loginData, MenuCycleRecord menuCycleLastId)
        {
        
            this.menuCycleLastId = menuCycleLastId;
        }

        [When(@"user issues '(.*)' request to delete last item against the '(.*)' and '(.*)'")]
         public void WhenUserIssuesRequestToDeleteLastItemAgainstTheAnd(string httpVerb, string resourceCollection, string individualResource = "")
        {
            // request method
            Method method;
            Method.TryParse(httpVerb, out method);

            int lastMenucycleItemid = menuCycleLastId._menuCycleItemId;


            // generate a request based on that URI
            var request = new RestRequest(resourceCollection + individualResource + "/" + lastMenucycleItemid, method);
            Console.WriteLine("this is the request " + request);


            request.AddHeader("Accept", "application/vnd.siren+json");
            // add standard headers
            //GlobalSteps.AddJsondHeadersToRequest(request);

            switch (method)
            {
                case Method.GET:
                    // get the client
                    // add request to context for later processing (add additional headers)
                    ScenarioContext.Current.AddNewRemoveExisting("Request", request);

                    break;

                case Method.PUT:
                    // add request to context for later processing (add additional headers)
                    ScenarioContext.Current.AddNewRemoveExisting("Request", request);
                    break;

                case Method.POST:
                    // add request to context for later processing (add additional headers)
                    ScenarioContext.Current.AddNewRemoveExisting("Request", request);
                    break;

                case Method.DELETE:
                    // execute request and add response to context for later processing
                    ScenarioContext.Current.AddNewRemoveExisting("Request", request);
                    break;
            }

        }


    }
}
