using System;
using System.Collections.Generic;

namespace ApiTests.Domain.Model
{
    public class Actions
    {
        public string Name { get; set; }
        public List<string> Class { get; set; }
        public Enums.HTTPMethod Method { get; set; }
        public Uri Href { get; set; }
        public string Title { get; set; }
        // The encoding type for the request. When omitted and the fields attribute exists, the default value is application/x-www-form-urlencoded. Optional.
        public string Type { get; set; }
        public Fields[] Fields { get; set; }
    }
}
