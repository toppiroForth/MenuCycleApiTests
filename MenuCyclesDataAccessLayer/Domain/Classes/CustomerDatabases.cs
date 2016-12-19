using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuCyclesDataAccessLayer.Domain.Classes
{
    public class CustomerDatabases
    {
        public int Id { get; set; }

        public string OrganisationId { get; set; }

        public string Server { get; set; }

        public string Database { get; set; }

        public string UserId { get; set; }

        public string Password { get; set; }
    }
}
