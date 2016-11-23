using System;
using System.Collections.Generic;

namespace ApiTests.Domain.Model
{
    public class EmbeddedLink
    {
        public List<string> Class { get; set; }
        public List<string> Rel { get; set; }
        public Uri Href { get; set; }
        public string Type { get; set; }
    }
}
