using MenuCycleApiTests_ci.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuCycleApiTests_ci.Domain.Models
{
    public class LocationsItemProperties
    {
        public int locationId { get; set; }
        public string name { get; set; }
    }

    public class EmbadedLocationItemProperties
    {

        LocationsItemProperties properties { get; set; }
    }

    public class LocationItemEntity<T> : SubEntity<T, EmbadedLocationItemProperties> where T : class
    {

    }




}
