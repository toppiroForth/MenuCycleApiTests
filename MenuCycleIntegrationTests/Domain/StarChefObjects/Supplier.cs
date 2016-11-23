namespace ApiTests.Domain
{
    public class Supplier
    {
        public string AccountNumber { get; set; }

        public string SupplierName { get; set; }

        public string AlternateSupplierName { get; set; }

        public string CountryGuid { get; set; }

        public bool IsCountryLibrary { get; set; }

        public string SupplierCurrencyCode { get; set; }

        public string CompareStatus { get; set; }

        public bool IsEnabled { get; set; }
    }
}
