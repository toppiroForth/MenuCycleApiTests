using ApiTests.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MenuCycleApiTests_ci
{
    public class MenuCycleProperties
    {
        public int menuCycleId { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int parentId { get; set; }
        public bool isPublished { get; set; }
        public bool isMaster { get; set; }
        public int nonServingDays { get; set; }
    }



    public class MenuCycleEntity<T> : SubEntity<T, EmbeddedProperty> where T : class
    {

    }
}
