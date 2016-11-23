using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTests.Domain
{
    class IngredientPriceBand
    {
        public int Id { get; set; }

        public string SupplierName { get; set; }

        public string SupplierCode { get; set; }

        public string PriceBandName { get; set; }

        public string OverridePrice { get; set; }

    }
}
