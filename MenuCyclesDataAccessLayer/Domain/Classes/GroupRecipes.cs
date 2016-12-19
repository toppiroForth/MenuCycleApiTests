using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuCyclesDataAccessLayer.Domain.Classes
{
    public class GroupRecipes
    {
        public int GroupId { get; set; }

        public int RecipeId { get; set; }

        public string CreatedByExternalId { get; set; }

        public DateTime DateCreatedUtc { get; set; }

        public DateTime DateUpdatedUtc { get; set; }

        public string UpdatedByExternalId { get; set; }

       

    }
}
