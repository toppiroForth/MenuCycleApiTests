using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace MenuCyclesDataAccessLayer.Domain.Classes
{
    public class GroupRecipesOperations
    {
        public void SaveAsNewGroupRecipes(GroupRecipes groupRecipes, SqlConnection connection)
        {
            const string sql = @"
            INSERT INTO [MenuServiceMain].[dbo].[GroupRecipes] (GroupId, RecipeId, CreatedByExternalId, UpdatedByExternalId, DateCreatedUtc, DateUpdatedUtc)
            VALUES (@GroupId, @RecipeId, @CreatedByExternalId, @UpdatedByExternalId, @DateCreatedUtc, @DateUpdatedUtc);";
            connection.Query<int>(sql, groupRecipes);
        }

        public bool GroupLocationsExistsInDb(Group group, Recipe recipe, SqlConnection connection)
        {
            var rows = connection.Query(String.Format(
            "SELECT COUNT(1) as 'Count' FROM [MenuServiceMain].[dbo].[GroupRecipes] WHERE [GroupId] = '{0}' and [RecipeId] = '{1}'",
            group.GroupId, recipe.RecipeId));
            return (int)rows.First().Count > 0;

        }
    }
}
