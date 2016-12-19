using System;

namespace MenuCyclesDataAccessLayer.Domain.Classes
{
    public class MenuCycle
    {
        public MenuCycle(User user)
        {
            this.CustomerId = user.CustomerId;
        }
        
        public int MenuCycleId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int ParentId { get; set; }

        public bool IsPublished { get; set; }

        public bool IsMaster { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int NonServingDays { get; set; }

        public int CustomerId { get; set; }

        public DateTime DateCreatedUtc { get; set; }

        public DateTime DateUpdatedUtc { get; set; }

        public string CreatedByExternalId { get; set; }

        public string UpdatedByExternalId { get; set; }        
    }
}
