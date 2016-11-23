using System;

namespace ApiTests.Domain
{
    public class Product
    {
        public int Id { get; set; }
        
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public decimal Number { get; set; }

        public decimal Quantity { get; set; }

        public int UnitId { get; set; }

        public int ProductTypeId { get; set; }

        public Guid ProductGuid { get; set; }

        public bool IsEnabled { get; set; }

        public decimal MinimumProductPrice { get; set; }

        public decimal MaximumProductPrice { get; set; }
    }
}
