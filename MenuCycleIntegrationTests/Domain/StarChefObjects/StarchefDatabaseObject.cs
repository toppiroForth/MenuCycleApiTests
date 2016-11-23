using System;

namespace ApiTests.Domain
{
    public class StarchefDatabaseObject
    {
        public int DatabaseId { get; set; }

        public string DatabaseName { get; set; }

        public string ServerName { get; set; }

        public string DatabaseDesc { get; set; }    

        public int DatabaseConfig { get; set; }

        public bool IsOnline { get; set; }

        public Guid DatabaseGuid { get; set; }
    }
}
