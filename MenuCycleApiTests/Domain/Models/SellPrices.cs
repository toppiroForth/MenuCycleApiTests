using ApiTests.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuCycleApiTests_ci.Domain.Models
{
    public class SellPricesProperties 
    {
    
            public int menuCycleId { get; set; }
            public int menuCycleItemId { get; set; }
            public string sellPricesModel { get; set; }
            public int tariffId { get; set; }
            public decimal value { get; set; }
            public decimal vat { get; set; }
            public int quantity { get; set; }
            public decimal price { get; set; }
            public decimal minimumPrice { get; set; }
            public decimal maximumPrice { get; set; }
        
    }


    public class EmbeddedSellPriceProperty : EmbeddedLink
    {
        public SellPricesProperties Properties { get; set; }
    }

    public class SellPriceEntity<T> : SubEntity<T, EmbeddedSellPriceProperty> where T : class
    {

    }








}
