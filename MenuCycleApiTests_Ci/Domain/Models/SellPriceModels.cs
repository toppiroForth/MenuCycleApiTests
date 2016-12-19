using MenuCycleApiTests_ci.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuCycleApiTests_ci.Domain.Models
{

    public class SellPriceModelsItemProperties
    {
        public int recipeId { get; set; }
        public string name { get; set; }
        public double cost { get; set; }
        public int costQuantity { get; set; }
        public string costUnitOfMeasure { get; set; }
        public double minimumCost { get; set; }
        public double maximumCost { get; set; }
        public string sellPriceModel { get; set; }
        public double sellPriceModelValue { get; set; }
    }
    public class EmbadedSellPriceModelsItemProperties
    {
        SellPriceModelsItemProperties properties { get; set; }
    }

    public class SellPriceModelsItemEntity<T> : SubEntity<T, EmbadedSellPriceModelsItemProperties> where T : class
    {

    }




}

