using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTests.Domain
{
    public class StarChefMealPeriod
    {
        public int MealPeriodId { get; set; }

        public string MealPeriodName { get; set; }

        public bool IsEnabled { get; set; }

        public Guid MealPeriodGuid { get; set; }
    }
}
