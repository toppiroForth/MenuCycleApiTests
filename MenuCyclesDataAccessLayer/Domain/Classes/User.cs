using System;
using System.Collections.Generic;

namespace MenuCyclesDataAccessLayer.Domain.Classes
{
    public class User
    {
    
        public List<Group> Groups = new List<Group>();
        public User(Customer customer, IEnumerable<Group> groups = null)
        {
            this.Customer = customer;
            this.CustomerId = customer.CustomerId;
            if (groups != null) Groups.AddRange(groups);
        }

        public Customer Customer { get; set; }

        public int UserId { get; set; }

        public string Name { get; set; }

        public string ExternalId { get; set; }

        public string IsCentral { get; set; }

        public int CustomerId { get; set; }

        public DateTime DateCreatedUtc { get; set; }

        public string CreatedByExternalId { get; set; }

        public DateTime DateUpdatedUtc { get; set; }

        public string UpdatedByExternalId { get; set; }
    }
}
