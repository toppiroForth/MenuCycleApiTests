using MenuCycleApiTests_ci.Domain.Models;
using MenuCycleApiTests_ci.GlobalData;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MenuCycleApiTests_ci.MenuCycleItems.Steps.SellPrices
{
    [Binding]
    public class DELSellPriceStepDef
    {
        private readonly MenuCycleRecord menuCycleLastId;

        public DELSellPriceStepDef(MenuCycleRecord menuCycleLastId)
        {
            this.menuCycleLastId = menuCycleLastId;
        }

        [When(@"the delete request contains SellpriceModel (.*) and tariffId (.*) and value (.*) and Vat (.*) quantity (.*) price (.*) minprice (.*) maxprice (.*)")]
        public void WhenTheDeleteRequestContainsSellpriceModelAndTariffIdAndValueAndVatQuantityPriceMinpriceMaxprice(int sellPriceModel, int tariffId, int value, int vat, int qantity, int price, int minPrice, int MaxPrice)
        {
            // get the request
            var request = ScenarioContext.Current.Get<RestRequest>("Request");
            //add body to request 
            var entity = new SellPriceEntity<Dictionary<string, object>>();
            entity.@class.Add("SellPrices");

            entity.entities = new List<EmbeddedSellPriceProperty>
            {
                new EmbeddedSellPriceProperty
                {

                     Class = new List<string>{"SellPrice"},
                     rel =new List<string>{" "},

                     Properties = new SellPricesProperties
                     {
                          menuCycleItemId =menuCycleLastId.itemvalue,
                          sellPricesModel = sellPriceModel.ToString(),
                          tariffId = tariffId, 
                          value = value,
                          vat=vat,
                          quantity=qantity,
                          price = price,
                          minimumPrice= minPrice,
                          maximumPrice=MaxPrice                            
                     }
                }
            };

            //changing PropertyNames into CamelCase
            var settings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };
            var obj = JsonConvert.SerializeObject(entity, Formatting.None, settings);

            request.AddParameter("application/vnd.siren+json", obj, ParameterType.RequestBody);

            // get the client
            var restClient = ScenarioContext.Current.Get<RestClient>("RestClient");

            //execute request and add response to context for later processing
            ScenarioContext.Current.AddNewRemoveExisting("Response", restClient.Execute(request));

        }

        [When(@"user issue '(.*)' request against the '(.*)' and '(.*)'")]
        public void WhenUserIssueRequestAgainstTheAnd(string httpVerb, string resourceCollection, string individualResource = "")
        {
            // request method
            Method method;
            Method.TryParse(httpVerb, out method);

            string[] individual_Resource = individualResource.Split('/');
            menuCycleLastId.itemvalue = Convert.ToInt32(individual_Resource[3]);

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





    }
}
