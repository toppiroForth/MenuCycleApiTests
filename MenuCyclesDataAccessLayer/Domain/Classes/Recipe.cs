using System;
using System.Collections.Generic;

namespace MenuCyclesDataAccessLayer.Domain.Classes
{
    public class Recipe
    {
        public List<Group> Groups = new List<Group>();

        public Recipe(Customer customer, IEnumerable<Group> groups = null)
        {
            this.Customer = customer;
            this.CustomerId = customer.CustomerId;
            if (groups != null) Groups.AddRange(groups);
        }
        public Customer Customer { get; set; }

        public int RecipeId { get; set; }

        public Guid ExternalId { get; set; }

        public string Name { get; set; }

        public decimal Cost { get; set; }

        public float CostQuantity { get; set; }

        public string CostUnitOfMeasure { get; set; }

        public int CustomerId { get; set; }

        public decimal MinimumCost { get; set; }

        public decimal MaximumCost { get; set; }

        public int SellPriceModel { get; set; }

        public decimal SellPriceModelValue { get; set; }

        public DateTime DateCreatedUtc { get; set; }

        public DateTime DateUpdatedUtc { get; set; }

        public string UpdatedByExternalId { get; set; }

        public string CreatedByExternalId { get; set; }
    }
}
