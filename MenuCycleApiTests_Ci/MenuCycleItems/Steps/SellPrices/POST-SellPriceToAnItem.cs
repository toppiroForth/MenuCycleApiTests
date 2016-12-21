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
    public class POST_SellPriceToAnItem
    {
        private readonly MenuCycleRecord menuCyclitemId;

        public POST_SellPriceToAnItem(MenuCycleRecord menuCyclitemId)
        {
            this.menuCyclitemId = menuCyclitemId;
        }


        [When(@"the request contains with SellPriceModel '(.*)' and tariffId (.*) and value (.*) and Vat (.*) quantity (.*) price (.*) minprice (.*) maxprice (.*)")]
        public void WhenTheRequestContainsWithSellPriceModelAndTariffIdAndValueAndVatQuantityPriceMinpriceMaxprice(string sellPriceModel, int tariffId, int value, int vat, int qantity, int price, int minPrice, int MaxPrice)
        {

            // get the request
            var request = ScenarioContext.Current.Get<RestRequest>("Request");
            //add body to request 
            var entity = new SellPriceEntity<Dictionary<string, object>>();
            entity.@class.Add("SellPrices");
            int _menuCycleItemId = menuCyclitemId._menuCycleItemId;


            entity.entities = new List<EmbeddedSellPriceProperty>
            {
                new EmbeddedSellPriceProperty
                {

                     Class = new List<string>{"SellPrice"},
                     rel =new List<string>{" "},

                     Properties = new SellPricesProperties
                     {

                          menuCycleItemId = _menuCycleItemId,
                          sellPricesModel = sellPriceModel,
                          tariffId = tariffId, 
                          value = value,
                          vat=vat,
                          quantity = qantity,
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


        [When(@"the request contains SellpriceModel (.*) and tariffId (.*) and value (.*) and Vat (.*) quantity (.*) price (.*) minprice (.*) maxprice (.*)")]
        public void WhenTheRequestContainsSellpriceModelAndTariffIdAndValueAndVatQuantityPriceMinpriceMaxprice(int sellPriceModel, int tariffId, int value, int vat, int qantity, int price, int minPrice, int MaxPrice)
        {

            // get the request
            var request = ScenarioContext.Current.Get<RestRequest>("Request");
            //add body to request 
            var entity = new SellPriceEntity<Dictionary<string, object>>();
            entity.@class.Add("SellPrices");
            int _menuCycleItemId = menuCyclitemId._menuCycleItemId;

            entity.entities = new List<EmbeddedSellPriceProperty>
            {
                new EmbeddedSellPriceProperty
                {

                     Class = new List<string>{"SellPrice"},
                     rel =new List<string>{" "},

                     Properties = new SellPricesProperties
                     {
                          menuCycleItemId = _menuCycleItemId,
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


    }
}
