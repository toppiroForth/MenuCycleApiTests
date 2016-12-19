using System;

namespace MenuCyclesDataAccessLayer.Domain.Classes
{
    public class UserLocation
    {
        public int UserId { get; set; }

        public int LocationId { get; set; }

        public DateTime DateCreatedUtc { get; set; }

        public DateTime DateUpdatedUtc { get; set; }

        public string UpdatedByExternalId { get; set; }

        public string CreatedByExternalId { get; set; }
    }
}
