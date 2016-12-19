using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace MenuCyclesDataAccessLayer.Domain.Classes
{

    public class RecipeOperations
    {
        private static SqlConnection _dbConnection;

        private static Helpers _helpers;

        private List<int> Identities;


        public bool RecipeExistsInDb(Recipe recipe, SqlConnection connection)
        {
            var rows = connection.Query(String.Format(
            "SELECT COUNT(1) as 'Count' FROM [MenuServiceMain].[dbo].[Recipes] WHERE Name = '{0}'", recipe.Name));
            return (int)rows.First().Count > 0;
        }

        //need to change the quary. 
        public void SaveAsNewRecipe(Recipe recipe, SqlConnection connection, out int identity)
        {
            const string sql = @"
            INSERT INTO [MenuServiceMain].[dbo].[Recipes] (Name, ExternalId, CustomerId, CreatedByExternalId, UpdatedByExternalId, DateCreatedUtc, DateUpdatedUtc,Cost,CostQuantity,CostUnitOfMeasure,MinimumCost,MaximumCost,SellPriceModel,SellPriceModelValue)
            VALUES (@Name, @ExternalId, @CustomerId, @CreatedByExternalId, @UpdatedByExternalId, @DateCreatedUtc, @DateUpdatedUtc,@Cost,@CostQuantity,@CostUnitOfMeasure,@MinimumCost,@MaximumCost,@SellPriceModel,@SellPriceModelValue); 
            SELECT CAST(SCOPE_IDENTITY() as int)";
            identity = connection.Query<int>(sql, recipe).Single();
        }

        public Recipe FindRecipe(Recipe recipe, SqlConnection connection)
        {

            var menuCollection =
                connection.Query<Recipe>("Select * FROM [MenuServiceMain].[dbo].[Recipes] WHERE Name = @Name", recipe.Name);
            return menuCollection.FirstOrDefault();
        }

        public void RemoveCustomer(Recipe recipe, SqlConnection connection)
        {
            connection.Execute("DELETE FROM [MenuServiceMain].[dbo].[Recipes] WHERE CustomerId = @CustomerId",
                recipe.CustomerId);
        }



    }
}
