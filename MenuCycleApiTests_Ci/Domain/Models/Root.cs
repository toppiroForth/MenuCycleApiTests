using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuCycleApiTests_ci.Domain.Model;

namespace MenuCycleApiTests_ci.Domain.Models
{
    public class RootProperties
    {
        public string apiVersion { get; set; }
        public string gitVersion { get; set; }
        public string buildNumber { get; set; }
        public string buildDate { get; set; }
    }

    public class RootEntity<T> : SubEntity<T, EmbeddedProperty> where T : class
    {
        
    }
}
