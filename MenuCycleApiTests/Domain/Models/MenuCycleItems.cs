using ApiTests.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuCycleApiTests_ci.Domain.Models
{

    

    public class MenuCycleItemsEntityProperties
    {
        public int menuCycleItemId { get; set; }
        public int day { get; set; }
        public int order { get; set; }
        public int menuCycleItemType { get; set; }
        public int menuType { get; set; }
        public string menuName { get; set; }
        public string course { get; set; }
        public int menuId { get; set; }
        public int mealPeriodId { get; set; }
        public string mealPeriodName { get; set; }
        public int? parentId { get; set; }
        public int? recipeId { get; set; }
        public string recipeName { get; set; }
        public double? cost { get; set; }
        public decimal? costQuantity { get; set; }
        public string costUnitOfMeasure { get; set; }
    }

    public class EmbeddedMenuCycleItemProperty : EmbeddedLink
    {
        public MenuCycleItemsEntityProperties Properties { get; set; }
    }


    //Root
    public class MenuCycleItemEntity<T> : SubEntity<T, EmbeddedMenuCycleItemProperty> where T : class
    {

    }

   


}
