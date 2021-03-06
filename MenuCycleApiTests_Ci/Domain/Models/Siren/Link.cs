﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace MenuCycleApiTests_ci.Domain.Model
{

    public class Link
    {

        public List<string> rel { get; set; }

        public string href { get; set; }

        public string method { get; set; }

        public string title { get; set; }

        public string type { get; set; }

    }
}
