using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuCyclesDataAccessLayer.Domain.Classes
{
    public class Customer
    {
        public int CustomerId { get; set; }
        
        public string Name { get; set; }

        public string ExternalId { get; set; }

        public DateTime DateCreatedUtc { get; set; }

        public string CreatedByExternalId { get; set; }

        public DateTime DateUpdatedUtc { get; set; }

        public string UpdatedByExternalId { get; set; }
    }
}
