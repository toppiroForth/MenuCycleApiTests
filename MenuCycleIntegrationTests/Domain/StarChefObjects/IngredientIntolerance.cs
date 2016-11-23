namespace ApiTests.Domain
{
    public class IngredientIntolerance
    {
        public int Id { get; set; }
        
        public string SupplierName { get; set; }

        public string SupplierCode { get; set; }

        public string IntoleranceCode { get; set; }

        public string IntoleranceValue { get; set; }
    }
}
