using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTests.Domain
{
    public class IngredientCategory
    {
        public int Id { get; set; }
        public string SupplierName { get; set; }
        public string SupplierCode { get; set; }
        public string CategoryTypeName { get; set; }
        public string MainCategoryName { get; set; }
        public string SubCategoryName { get; set; }
        public string IsDefault { get; set; }
    }
}
