using System.Collections.Generic;

namespace ApiTests.Domain.Model
{
    public class SubEntity<EntityPropertyType, EmbeddedEntityType> : Entity<EntityPropertyType, EmbeddedEntityType>
    {
        public List<string> rel { get; set; }
    }
}
