using System.Collections.Generic;

namespace ApiTests.Domain.Model
{
    public class Link
    {
        public List<string> rel { get; set; }
        public string href { get; set; }
        public string method { get; set; }
        public string title { get; set; }
        public object type { get; set; }
    }
}
