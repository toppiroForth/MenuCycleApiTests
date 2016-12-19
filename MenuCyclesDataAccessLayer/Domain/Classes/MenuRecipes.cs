using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuCyclesDataAccessLayer.Domain.Classes
{
    public class MenuRecipes
    {

        public int MenuId { get; set; }

        public int RecipeId { get; set; }

        public string Course { get; set; }

        public DateTime DateCreatedUtc { get; set; }

        public DateTime DateUpdatedUtc { get; set; }

        public string UpdatedByExternalId { get; set; }

        public string CreatedByExternalId { get; set; }

    }
}
