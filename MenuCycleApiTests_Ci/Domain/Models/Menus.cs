using MenuCycleApiTests_ci.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuCycleApiTests_ci.Domain.Models
{
   public class MenusItemsProperties
    {
        public int menuId { get; set; }
        public string name { get; set; }
        public int menuType { get; set; }
    }


   public class EmbeddedMenesItemProperty : EmbeddedLink
   {
       public MenusItemsProperties Properties { get; set; }
   }


   //Root
   public class MenusItemEntity<T> : SubEntity<T, EmbeddedMenesItemProperty> where T : class
   {


   }


}
