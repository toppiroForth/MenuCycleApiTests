using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuCyclesDataAccessLayer.Domain.Classes
{
    public class Tariffs
    {

        public Tariffs(Customer customer)
        {
            this.Customer = customer;
            this.Customer_CustomerId = customer.CustomerId;         
        }

        public Customer Customer { get; set; }

         public int TariffId { get; set; }
 
        public string Name { get; set; }

        public string description { get; set; }

        public int Customer_CustomerId { get; set; }

        public DateTime DateCreatedUtc { get; set; }

        public DateTime DateUpdatedUtc { get; set; }

        public string UpdatedByExternalId { get; set; }

        public string CreatedByExternalId { get; set; }

                
        }


    }

