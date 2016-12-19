using MenuCycleApiTests_ci.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuCycleApiTests_ci.Domain.Models
{
    public class MealPeriodsItemProperties 
    {
        public int mealPeriodId { get; set; }
        public string name { get; set; }

    }

    public class EmbeddedMealperiodsItemProperty : EmbeddedLink
    {
        public MealPeriodsItemProperties Properties { get; set; }
    }

    //Root
    public class MealPeriodItemEntity<T> : SubEntity<T, EmbeddedMealperiodsItemProperty> where T : class
    {

    }


















}
