using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;

namespace MenuCyclesDataAccessLayer.Domain.Classes
{
    public class TariffOperations
    {

        public bool TariffExistsInDb(Tariffs tariff, SqlConnection connection)
        {
            var rows = connection.Query(String.Format(
            "SELECT COUNT(1) as 'Count' FROM [MenuServiceMain].[dbo].[Tariffs] WHERE Name = '{0}'", tariff.Name));
            return (int)rows.First().Count > 0;
        }

        public void SaveAsNewTariff(Tariffs tariff, SqlConnection connection, out int identity)
        {
            const string sql = @"
            INSERT INTO [MenuServiceMain].[dbo].[Tariffs] (Name, Description, Customer_CustomerId, CreatedByExternalId, UpdatedByExternalId, DateCreatedUtc, DateUpdatedUtc)
            VALUES (@Name,@Description, @Customer_CustomerId, @CreatedByExternalId, @UpdatedByExternalId, @DateCreatedUtc, @DateUpdatedUtc); 
            SELECT CAST(SCOPE_IDENTITY() as int)";
            identity = connection.Query<int>(sql, tariff).Single();
        }

    }
}
