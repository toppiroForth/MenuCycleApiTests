using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace MenuCyclesDataAccessLayer.Domain.Classes
{
    public class LocationOperations
    {
        private static SqlConnection _dbConnection;

        private static Helpers _helpers;

        private List<int> Identities;

        public void SaveAsNewLocation(Location location, SqlConnection connection, out int identity)
        {
            const string sql = @"
            INSERT INTO [MenuServiceMain].[dbo].[Locations] (Name, ExternalId, CustomerId, CreatedByExternalId, UpdatedByExternalId, DateCreatedUtc, DateUpdatedUtc)
            VALUES (@Name, @ExternalId, @CustomerId, @CreatedByExternalId, @UpdatedByExternalId, @DateCreatedUtc, @DateUpdatedUtc); SELECT CAST(SCOPE_IDENTITY() as int)";
            identity = connection.Query<int>(sql, location).Single();
        }

        public bool LocationExistsInDb(Location location, SqlConnection connection)
        {
            var rows = connection.Query(String.Format(
            "SELECT COUNT(1) as 'Count' FROM [MenuServiceMain].[dbo].[Locations] WHERE Name = '{0}'",
            location.Name));

            return (int)rows.First().Count > 0;
        }

        public Location FindLocation(Location location, SqlConnection connection)
        {
            var customerCollection =
                connection.Query<Location>("Select * FROM [MenuServiceMain].[dbo].[Locations] WHERE Name = @Name", location.Name);
            return customerCollection.FirstOrDefault();
        }

        public void RemoveCustomer(Customer customer, SqlConnection connection)
        {
            connection.Execute("DELETE FROM [MenuServiceMain].[dbo].[Locations] WHERE CustomerId = @CustomerId",
                customer.CustomerId);
        }
    }
}
