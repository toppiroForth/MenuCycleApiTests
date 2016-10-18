using System;

namespace ApiTests.Domain.Model
{
        public class BuildInfo : SubEntity<BuildInfoProperties, Type>
        {

        }

        public class BuildInfoProperties
        {
            public string ApiBuild { get; set; }
            public string DatabaseBuild { get; set; }
            public string InstanceName { get; set; }
            public string PurchasingApi { get; set; }
        }
}
