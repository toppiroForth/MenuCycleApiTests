using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace MenuCyclesDataAccessLayer.Domain.Classes
{
   public class MenuRecipeOperations
    {

        public void SaveAsNewMenuRecipe(MenuRecipes menuRecipes, SqlConnection connection)
        {
            const string sql = @"
            INSERT INTO [MenuServiceMain].[dbo].[MenuRecipes] (MenuId, RecipeId, Course,CreatedByExternalId, UpdatedByExternalId, DateCreatedUtc, DateUpdatedUtc)
            VALUES (@MenuId, @RecipeId,@Course, @CreatedByExternalId, @UpdatedByExternalId, @DateCreatedUtc, @DateUpdatedUtc);";
            connection.Query<int>(sql, menuRecipes);
        }

        public bool MenuRecipesExistsInDb(Menu menu, Recipe recipe, SqlConnection connection)
        {
            var rows = connection.Query(String.Format(
            "SELECT COUNT(1) as 'Count' FROM [MenuServiceMain].[dbo].[MenuRecipes] WHERE [MenuId] = '{0}' and [recipeId] = '{1}'",
            menu.MenuId, recipe.RecipeId));

            return (int)rows.First().Count > 0;
        }
    }
}
