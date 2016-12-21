using MenuCycleApiTests_ci.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuCycleApiTests_ci.Domain.Models
{

    public class TariffsItemProperties
    {
        public int tariffId { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }

    public class EmbadedTariffsItemProperties
    {
        TariffsItemProperties properties { get; set; }
    }

    public class TariffsItemEntity<T> : SubEntity<T, EmbadedTariffsItemProperties> where T : class
    {

    }









}
