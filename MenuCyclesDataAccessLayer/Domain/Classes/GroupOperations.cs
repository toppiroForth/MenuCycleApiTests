using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace MenuCyclesDataAccessLayer.Domain.Classes
{
    public class GroupOperations
    {
        private static SqlConnection _dbConnection;

        private static Helpers _helpers;

        private List<int> Identities;

        public void SaveAsNewLocation(Group group, SqlConnection connection, out int identity)
        {
            const string sql = @"
            INSERT INTO [MenuServiceMain].[dbo].[Groups] (Name, ExternalId, CustomerId, CreatedByExternalId, UpdatedByExternalId, DateCreatedUtc, DateUpdatedUtc)
            VALUES (@Name, @ExternalId, @CustomerId, @CreatedByExternalId, @UpdatedByExternalId, @DateCreatedUtc, @DateUpdatedUtc); SELECT CAST(SCOPE_IDENTITY() as int)";
            identity = connection.Query<int>(sql, group).Single();
        }

        public Group FindGroup(Group group, SqlConnection connection)
        {
            var groupCollection =
                connection.Query<Group>("Select * FROM [MenuServiceMain].[dbo].[Groups] WHERE Name = @Name", group.Name);
            return groupCollection.FirstOrDefault();
        }

        public void RemoveCustomer(Group group, SqlConnection connection)
        {
            connection.Execute("DELETE FROM [MenuServiceMain].[dbo].[Groups] WHERE CustomerId = @CustomerId",
                group.CustomerId);
        }

        public bool GroupExistsInDb(Group group, SqlConnection connection)
        {
            var rows = connection.Query(String.Format(
            "SELECT COUNT(1) as 'Count' FROM [MenuServiceMain].[dbo].[Groups] WHERE Name = '{0}'",
            group.Name));

            return (int)rows.First().Count > 0;
        }
    }
}
