using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using ApiTests.Domain;
using Dapper;

namespace ApiTests
{
    public class Helpers
    {
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["StarChefLoginDbConnection"].ConnectionString;

        public static IEnumerable<dynamic> GetValues(string sqlQuery)
        {
            using (var myConnection = new SqlConnection(ConnectionString))
            {
                myConnection.Open();
                return myConnection.Query(sqlQuery);
            }
        }

        public static void ExecuteQueryAgainstRowId(string sqlQuery, int id = 0)
        {
            using (var myConnection = new SqlConnection(ConnectionString))
            {
                myConnection.Open();
                myConnection.QueryMultiple(sqlQuery, new {id = id});
            }
        }

        public static void ExecuteQueryAgainstRowWithName(string sqlQuery, string name)
        {
            using (var myConnection = new SqlConnection(ConnectionString))
            {
                myConnection.Open();
                myConnection.QueryMultiple(sqlQuery, new { name = name });
            }
        }

        public static IEnumerable<dynamic> GetValueUsingId(string sqlQuery, int id = 0)
        {
            using (var myConnection = new SqlConnection(ConnectionString))
            {
                myConnection.Open();
                return myConnection.Query(sqlQuery, new { id = id });
            }
        }

        public static dynamic UpdateRecords(string sqlQuery)
        {
            object rowsAffected = null;
            using (var myConnection = new SqlConnection(ConnectionString))
            {
                myConnection.Open();
                rowsAffected = myConnection.Query(sqlQuery);
            }
            return rowsAffected;
        }

        public static IEnumerable<Domain.Group> GetGroupsFromDb(string query)
        {
            List<Domain.Group> item = null;
            using (var myConnection = new SqlConnection(ConnectionString))
            {
                item = (List<Domain.Group>) myConnection.Query<Domain.Group>(query);
            }
            return item;
        }

        public static IEnumerable<Domain.Group> ConvertFromDapperRowToGroupType(IEnumerable<dynamic> myList)
        {
            var stuff = myList.ToList();
            return stuff.Select(o => new Domain.Group()
            {
                GroupId = o.group_id,
                GroupCode = o.group_code,
                GroupName = o.group_name,
                GroupCurrencyCode = o.group_currency_code,
                SalesTaxName = o.sales_tax_name,
                ParentGroupCode = o.parent_group_code,
                TopMostGroupCode = o.top_most_group_code
            }).ToList();
        }

        public static IEnumerable<Domain.Group> ConvertFromDapperRowToGroupStagingType(IEnumerable<dynamic> myList)
        {
            var stuff = myList.ToList();
            return stuff.Select(o => new Domain.Group()
            {
                Id = o.id,
                GroupCode = o.group_code,
                GroupName = o.group_name,
                GroupCurrencyCode = o.group_currency_code,
                SalesTaxName = o.sales_tax_name,
                ParentGroupCode = o.parent_group_code,
                TopMostGroupCode = o.top_most_group_code
            }).ToList();
        }

        public static IEnumerable<StarchefDatabaseObject> ConvertFromDapperRowToStarchefDatabseRowType(IEnumerable<dynamic> myList)
        {
            var stuff = myList.ToList();
            return stuff.Select(o => new StarchefDatabaseObject()
            {
                DatabaseId = o.db_database_id,
                DatabaseName = o.database_name,
                DatabaseDesc = o.database_desc,
                DatabaseGuid = o.db_database_guid,
                ServerName = o.server_name,
                DatabaseConfig = o.database_config,
                IsOnline = o.is_online
            }).ToList();
        }

        internal static IEnumerable<Ingredient> ConvertFromDapperRowToIngredientType(IEnumerable<dynamic> myList)
        {
            var stuff = myList.ToList();
            return stuff.Select(o => new Ingredient()
            {
                IngredientId = o.ingredient_id,
                SupplierCode = o.supplier_code,
                CostPrice = o.cost_price,
            }).ToList();
        }

        internal static IEnumerable<StarChefMealPeriod> ConvertFromDapperRowToStarChefMealPeriod(IEnumerable<dynamic> myList)
        {
            var stuff = myList.ToList();
            return stuff.Select(o => new StarChefMealPeriod()
            {
                MealPeriodId = o.meal_period_id,
                MealPeriodName = o.meal_period_name,
                IsEnabled = o.is_enabled,
                MealPeriodGuid = o.meal_period_guid
            }).ToList();
        }

        internal static IEnumerable<Product> ConvertFromDapperRowToProduct(IEnumerable<dynamic> myList)
        {
            var stuff = myList.ToList();
            return stuff.Select(o => new Product()
            {
                ProductId = o.product_id,
                ProductName = o.product_name,
                Number = o.number,
                Quantity = o.quantity,
                UnitId = o.unit_id,
                ProductTypeId = o.product_type_id,
                ProductGuid = o.product_guid,
                IsEnabled = o.is_enabled,
                MinimumProductPrice = o.min_product_price,
                MaximumProductPrice = o.max_product_price
            }).ToList();
        }

        internal static IEnumerable<StagingIngredient> ConvertFromDapperRowToStagingIngredient(IEnumerable<dynamic> myList)
        {
            var stuff = myList.ToList();
            return stuff.Select(o => new StagingIngredient()
            {
                Id = o.id,
                IngredientName = o.ingredient_name,
                SupplierName = o.supplier_name,
                SupplierCode = o.supplier_code,
                SupplyQuantityNumber = o.supply_quantity_number,
                SupplyQuantity = o.supply_quantity,
                InternalCode = o.internal_code,
                SupplyQuantityUnit = o.supply_quantity_unit,
                CostPrice = o.cost_price,
                IngredientSets = o.ingredient_sets
            }).ToList();
        }
            
        internal static IEnumerable<Domain.MenuCycle> ConvertFromDapperRowToMenuCycleType(IEnumerable<dynamic> myList)
        {
            var stuff = myList.ToList();
            return stuff.Select(o => new Domain.MenuCycle()
            {
              Name = o.mcycle_name,
              ShortName = o.short_name,
              Description = o.mcycle_desc,
              StartDate = o.start_date,
              EndDate = o.end_date
            }).ToList();
        }

        internal static IEnumerable<Set> ConvertFromDapperRowToSetStagingType(IEnumerable<dynamic> myList)
        {
            var stuff = myList.ToList();
            return stuff.Select(o => new Set()
            {
                SetName = o.set_name,
                SetTypeName = o.set_type_name,
                ProductTypeId = o.product_type_id,
                Notes = o.notes,
                Id = o.id
            }).ToList();
        }

        internal static IEnumerable<Set> ConvertFromDapperRowToSetType(IEnumerable<dynamic> myList)
        {
            var stuff = myList.ToList();
            return stuff.Select(o => new Set()
            {
                SetName = o.set_name,
                SetTypeName = o.set_type_name,
                ProductTypeId = o.product_type_id,
                Notes = o.pset_notes,
                SetId = o.pset_id
            }).ToList();
        }

        internal static IEnumerable<IngredientIntolerance> ConvertFromDapperRowToIngredientIntoleranceStagingType(List<dynamic> myList)
        {
            var stuff = myList.ToList();
            return stuff.Select(o => new IngredientIntolerance()
            {
                SupplierCode = o.supplier_code,
                SupplierName = o.supplier_name,
                IntoleranceCode = o.intolerance_code,
                IntoleranceValue = o.intolerance_value,
                Id = o.id
            }).ToList();
        }

        internal static IEnumerable<IngredientCategory> ConvertFromDapperRowToIngredientCategoryStagingType(List<dynamic> myList)
        {
            var stuff = myList.ToList();
            return stuff.Select(o => new IngredientCategory()
            {
                SupplierCode = o.supplier_code,
                SupplierName = o.supplier_name,
                CategoryTypeName = o.category_type_name,
                MainCategoryName = o.main_category_name,
                SubCategoryName = o.sub_category_name,
                IsDefault = o.is_default,
                Id = o.id
            }).ToList();
        }

        internal static IEnumerable<IngredientNutrient> ConvertFromDapperRowToIngredientNutrientStagingType(List<dynamic> myList)
        {
            var stuff = myList.ToList();
            return stuff.Select(o => new IngredientNutrient()
            {
                SupplierCode = o.supplier_code,
                SupplierName = o.supplier_name,
                NutrientName = o.nutrient_name,
                NutrientValue = o.nutrient_value,
                Id = o.Id
            }).ToList();
        }

        internal static IEnumerable<IngredientPriceBand> ConvertFromDapperRowToIngredientPriceBandStagingType(List<dynamic> myList)
        {
            var stuff = myList.ToList();
            return stuff.Select(o => new IngredientPriceBand()
            {
                SupplierCode = o.supplier_code,
                SupplierName = o.supplier_name,
                PriceBandName = o.price_band_name,
                OverridePrice = o.override_price,
                Id = o.Id
            }).ToList();
        }



    }
}
