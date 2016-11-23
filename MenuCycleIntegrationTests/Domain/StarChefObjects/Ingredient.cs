using System;
using Microsoft.SqlServer.Server;

namespace ApiTests.Domain
{
    public class Ingredient
    {
        public int IngredientId { get; set; }
        
        public Guid IngredientGuid { get; set; }

        public string IngredientName { get; set; }

        public bool Sellable { get; set; }

        public string ShortName { get; set; }

        public string Description { get; set; }

        public string SupplierName { get; set; }

        public string SupplierCode { get; set; }

        public decimal SupplyQuantityNumber { get; set; }

        public decimal SupplyQuantity { get; set; }

        public string SupplyQuantityUnit { get; set; }

        public decimal CostPrice { get; set; }

        public string IngredientSets { get; set; }

        public string InternalCode { get; set; }
    }

    public class StagingIngredient
    {
        public int Id { get; set; }

        public string IngredientName { get; set; }

        public string SupplierName { get; set; }

        public string SupplierCode { get; set; }

        public string SupplyQuantityNumber { get; set; }

        public string SupplyQuantity { get; set; }

        public string SupplyQuantityUnit { get; set; }

        public string CostPrice { get; set; }

        public string IngredientSets { get; set; }

        public string InternalCode { get; set; }
    }
}
