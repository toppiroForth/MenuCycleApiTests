using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace MenuCyclesDataAccessLayer.Domain.Classes
{
    public class MealPeriodOperations
    {

        public bool MealPeriodsExistsInDb(MealPeriod mealPeriod, System.Data.SqlClient.SqlConnection connection)
        {
            var rows = connection.Query(String.Format(
            "SELECT COUNT(1) as 'Count' FROM [MenuServiceMain].[dbo].[MealPeriods] WHERE Name = '{0}'", mealPeriod.Name));
            return (int)rows.First().Count > 0;
        }

        public void SaveAsNewMenu(MealPeriod mealPeriod, System.Data.SqlClient.SqlConnection connection, out int identity)
        {
           
            const string sql = @"
            INSERT INTO [MenuServiceMain].[dbo].[MealPeriods] (Name, ExternalId, CustomerId, CreatedByExternalId, UpdatedByExternalId, DateCreatedUtc, DateUpdatedUtc)
            VALUES (@Name, @ExternalId, @CustomerId, @CreatedByExternalId, @UpdatedByExternalId, @DateCreatedUtc, @DateUpdatedUtc); 
            SELECT CAST(SCOPE_IDENTITY() as int)";
            identity = connection.Query<int>(sql, mealPeriod).Single();
        }






    }
}
