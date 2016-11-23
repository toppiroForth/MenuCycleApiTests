using System.Collections.Generic;

namespace ApiTests.Domain
{
    public class SuppliedPackSize
    {
        public string StarChefKey { get; set; }

        public string InternalCode { get; set; }

        public string ExternalCode { get; set; }

        public string SupplierGuid { get; set; }

        public string SupplierName { get; set; }

        public string SuppliedProductName { get; set; }

        public bool PreferredSupplier { get; set; }

        public string SupplierRef { get; set; }

        public string SupplierCode { get; set; }

        public string DistributorGuid { get; set; }

        public string DistributorName { get; set; }

        public string DistributorRef { get; set; }

        public string DistributorCode { get; set; }

        public double CostPrice { get; set; }

        public double PendingCostPrice { get; set; }

        public string PendingCostPriceEffectiveDate { get; set; }

        public SupplyQuantity SupplyQty { get; set; }

        public string SupplyQtyConversions { get; set; }

        public int RankOrder { get; set; }

        public List<CategoryType> Categories { get; set; }
    }
}
