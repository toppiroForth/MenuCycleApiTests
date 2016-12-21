using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Net;
using MenuCycleApiTests_ci;
using NUnit.Framework;
using RestSharp;
using RestSharp.Authenticators;
using TechTalk.SpecFlow;
using MenuCycleApiTests_ci.GlobalData;

namespace MenuCycleApiTests_ci
{
    [Binding]
    public class GlobalStep
    {
        private readonly LoginData loginData;
        private readonly MenuCycleRecord menuCycleLastId;

        public GlobalStep(LoginData loginData,MenuCycleRecord menuCycleLastId)
        {
            this.loginData = loginData;
            this.menuCycleLastId = menuCycleLastId;
        }

    

        [Given(@"user can access the MenuService API with '(.*)' and '(.*)'")]
        public void GivenICanAccessTheMenuServiceAPIAsAnAuthenticatedUserWithAnd(string username, string password)
        {
            var rootUrl = ConfigurationManager.AppSettings.Get("RootUrl");
            var restClient = new RestClient(rootUrl)
            
            
            {
                Authenticator = new HttpBasicAuthenticator(loginData._userName = username, loginData._passWord = password)
            };

            ScenarioContext.Current.AddNewRemoveExisting("rootUrl", rootUrl);
            ScenarioContext.Current.AddNewRemoveExisting("RestClient", restClient);
        }


        [Given(@"user can access the MenuService API with userID '(.*)' and Org '(.*)' contentType '(.*)'")]
        public void GivenICanAccessTheMenuServiceAPIWithUserIDAndOrgContentType(string fourthID, string FourthOrg, string contentType)
        {         
            //get the root url from our app config
            var rootUrl = ConfigurationManager.AppSettings.Get("RootUrl");

            //get our header arguments from parameters specflow passes in
            var xFourthUserId = fourthID;
            var xFourthOrg = FourthOrg;
            var Content_Type = contentType;

            //set up our restsharp client
            var restClient = new RestClient(rootUrl);

            //add the standard headers          
            restClient.AddDefaultHeader("X-Fourth-UserID", xFourthUserId);
            restClient.AddDefaultHeader("X-Fourth-Org", xFourthOrg);
            restClient.AddDefaultHeader("Content-Type", Content_Type);

            ScenarioContext.Current.AddNewRemoveExisting("rootUrl", rootUrl);
            ScenarioContext.Current.AddNewRemoveExisting("RestClient", restClient);

        }


      

      
        [When(@"user issues '(.*)' request against the '(.*)' and '(.*)'")]
        public void WhenUserIssuesRequestAginestThe(string httpVerb, string resourceCollection, string individualResource = "")
        {
            // request method
            Method method;
            Method.TryParse(httpVerb, out method);

          
            // generate a request based on that URI
            var request = new RestRequest(resourceCollection + individualResource, method);

            request.AddHeader("Accept", "application/vnd.siren+json");

            // add standard headers
          // request.AddHeader("Content-Type", "application/vnd.siren+json");

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

        [When(@"the request has the following entity in the body")]
        public void WhenTheRequestHasTheFollowingEntityInTheBody(Table table)
        {
            Console.WriteLine("Develop phase");
        }

        [When(@"the request is sent to the server")]
        public void WhenTheRequestIsSentToTheServer()
        {
            // get the request
            var request = ScenarioContext.Current.Get<RestRequest>("Request");

            // get the client
            var restClient = ScenarioContext.Current.Get<RestClient>("RestClient");

            //execute request and add response to context for later processing
            ScenarioContext.Current.AddNewRemoveExisting("Response", restClient.Execute(request));

        }
      
        [Then(@"No errors are returned by server")]
        public void ThenNoErrorsAreReturnedByServer()
        {
            var response = ScenarioContext.Current.Get<RestResponse>("Response");
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            
        }

        [When(@"user issues '(.*)' request to delete last record against the '(.*)' and '(.*)'")]
        public void WhenUserIssuesRequestToDeleteLastRecordAgainstTheAnd(string httpVerb, string resourceCollection, string p2)
        {
            // request method
            Method method;
            Method.TryParse(httpVerb, out method);

            int lastMenucycleid = menuCycleLastId._menuCycleId;
         

            // generate a request based on that URI
            var request = new RestRequest(resourceCollection +"/"+lastMenucycleid,method);
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


        [When(@"user issues '(.*)' request against singel '(.*)' and '(.*)'")]
        public void WhenUserIssuesRequestAgainstSingelAnd(string httpVerb, string resourceCollection, string individualResource = "")
        {

            // request method
            Method method;
            Method.TryParse(httpVerb, out method);

            int lastMenuId = menuCycleLastId._menuId;


            // generate a request based on that URI
            var request = new RestRequest(resourceCollection + "/" + lastMenuId, method);
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

