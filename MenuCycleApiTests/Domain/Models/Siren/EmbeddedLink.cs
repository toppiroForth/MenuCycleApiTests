using System;
using System.Collections.Generic;

namespace ApiTests.Domain.Model
{
    public class EmbeddedLink
    {
        public List<string> Class { get; set; }
        public List<string> rel { get; set; }
        public Uri href { get; set; }
    }

    public class EmbeddedProperty : EmbeddedLink
    {
        public Properties2 Properties { get; set; }
    }

    public class Properties2
    {
        public int groupId { get; set; }
    }

    public class EmbeddedEntity
    {
        public List<string> Class { get; set; }
        public List<string> rel { get; set; }
        public Uri href { get; set; }
    }
}
