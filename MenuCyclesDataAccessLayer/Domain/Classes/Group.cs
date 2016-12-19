using System;
using System.Collections.Generic;

namespace MenuCyclesDataAccessLayer.Domain.Classes
{
    public class Group
    {
        public Group()
        {

        }
        public Group(Customer customer, IEnumerable<Location> locations = null)
        {
            this.Customer = customer;
            if (locations != null) this._locations.AddRange(locations);
            this.CustomerId = customer.CustomerId;
        }

        public Customer Customer { get; set; }
        
        private readonly List<Location> _locations = new List<Location>();

        public int GroupId { get; set; }

        public Guid ExternalId { get; set; }

        public string Name { get; set; }

        public int CustomerId { get; set; }

        public DateTime DateCreatedUtc { get; set; }

        public DateTime DateUpdatedUtc { get; set; }

        public string UpdatedByExternalId { get; set; }

        public string CreatedByExternalId { get; set; }
    }
}
