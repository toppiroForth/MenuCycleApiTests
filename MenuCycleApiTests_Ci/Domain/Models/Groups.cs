using MenuCycleApiTests_ci.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuCycleApiTests_ci.Domain.Models
{
    public class GroupItemsProperties
    {
        public int groupid { get; set; }
        public string Name { get; set; }
    }

    public class EmbeddedGroupItemProperty : EmbeddedLink
    {
        public GroupItemsProperties Properties { get; set; }
    }

    public class GroupItemEntity<T>: SubEntity<T,EmbeddedGroupItemProperty> where T : class
    {

    }


   





}
