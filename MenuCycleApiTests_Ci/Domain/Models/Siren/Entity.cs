using System.Collections.Generic;

namespace MenuCycleApiTests_ci.Domain.Model
{
    public class Entity<EntityPropertyType, EmbeddedEntityType>
    {
        public Entity()
        {
            @class = new List<string>();
            links = new List<Link>();
            Actions = new List<Actions>();
            entities = new List<EmbeddedEntityType>();
        }
        public EntityPropertyType properties { get; set; }
        public List<string> @class { get; set; }
        public List<EmbeddedEntityType> entities { get; set; }
        public List<Link> links { get; set; }
        public List<Actions> Actions { get; set; }
        public string Title { get; set; }
    }
}


