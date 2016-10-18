using System.Collections.Generic;

namespace ApiTests.Domain.Model
{
    public class SubEntity<EntityPropertyType, EmbeddedEntityType> : Entity<EntityPropertyType, EmbeddedEntityType>
    {
        public SubEntity()
        {
            rel = new List<string>();
        }
        public List<string> rel { get; set; }
    }
}
