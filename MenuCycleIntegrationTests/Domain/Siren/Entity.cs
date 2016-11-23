using System.Collections.Generic;

namespace ApiTests.Domain.Model
{
    public class Entity<TEntityPropertyType, TEmbeddedEntityType>
    {
        public TEntityPropertyType properties { get; set; }
        public List<string> @class { get; set; }
        public List<TEmbeddedEntityType> entities { get; set; }
        public List<Link> links { get; set; }
        public List<Actions> Actions { get; set; }
        public string Title { get; set; }
    }
}
