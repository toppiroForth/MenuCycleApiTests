using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace MenuCyclesDataAccessLayer.Domain.Classes
{
   public class UserOperations
    {
        public void SaveAsNewUser(User user, SqlConnection connection, out int identity)
        {
            const string sql = @"
            INSERT INTO [MenuServiceMain].[dbo].[Users] (Name,ExternalId,IsCentral,CustomerId,CreatedByExternalId, UpdatedByExternalId, DateCreatedUtc, DateUpdatedUtc)
            VALUES (@Name, @ExternalId, @IsCentral, @CustomerId, @CreatedByExternalId, @UpdatedByExternalId, @DateCreatedUtc, @DateUpdatedUtc); SELECT CAST(SCOPE_IDENTITY() as int)";
            identity = connection.Query<int>(sql, user).Single();

            if (user.Groups.Any())
            {
                foreach (var group in user.Groups)
                {
                    string sql1 = @"
                        INSERT INTO [MenuServiceMain].[dbo].[GroupUsers] (GroupId,UserId,CreatedByExternalId, UpdatedByExternalId, DateCreatedUtc, DateUpdatedUtc)
                        VALUES (@GroupId, @UserId, @CreatedByExternalId, @UpdatedByExternalId, @DateCreatedUtc, @DateUpdatedUtc);";

                    connection.Execute(sql1, new 
                    { 
                        GroupId = group.GroupId,
                        UserId = identity,
                        CreatedByExternalId = user.CreatedByExternalId,
                        UpdatedByExternalId = user.UpdatedByExternalId,
                        DateCreatedUtc = user.DateCreatedUtc,
                        DateUpdatedUtc = user.DateUpdatedUtc

                    });
                }
            }
        }

        public bool UserExistsInDb(User user, SqlConnection connection)
        {
            var rows = connection.Query(String.Format(
            "SELECT COUNT(1) as 'Count' FROM [MenuServiceMain].[dbo].[Users] WHERE Name = '{0}'",
            user.Name));

            return (int)rows.First().Count > 0;
        }

        public Customer FindUser(User user, SqlConnection connection)
        {
            var userCollection =
                connection.Query<Customer>("FROM [MenuServiceMain].[dbo].[Users] WHERE Name = @Name", user.Name);
            return userCollection.FirstOrDefault();
        }

        public void RemoveUser(User user, SqlConnection connection)
        {
            connection.Execute("FROM [MenuServiceMain].[dbo].[Users] WHERE UserId = @UserId",
                user.UserId);
        }



    }
}
