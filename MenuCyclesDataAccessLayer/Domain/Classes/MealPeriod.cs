using System;

namespace MenuCyclesDataAccessLayer.Domain.Classes
{
    public class MealPeriod
    {

        public MealPeriod(Customer customer)
        {
            this.Customer = customer;
            this.CustomerId = customer.CustomerId;         
        }

        public Customer Customer { get; set; }

        public int MealPeriodId { get; set; }

        public Guid ExternalId { get; set; }

        public string Name { get; set; }

        public int CustomerId { get; set; }

        public DateTime DateCreatedUtc { get; set; }

        public DateTime DateUpdatedUtc { get; set; }

        public string UpdatedByExternalId { get; set; }

        public string CreatedByExternalId { get; set; }
    }
}
