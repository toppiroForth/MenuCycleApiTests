using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace MenuCyclesDataAccessLayer.Domain.Classes
{
    public class MenuOperations
    {

        private static SqlConnection _dbConnection;

        private static Helpers _helpers;

        private List<int> Identities;


       
        public bool MenuExistsInDb(Menu menu, SqlConnection connection)
        {
            var rows = connection.Query(String.Format(
            "SELECT COUNT(1) as 'Count' FROM [MenuServiceMain].[dbo].[menus] WHERE Name = '{0}'", menu.Name));
            return (int)rows.First().Count > 0;
        }


        public void SaveAsNewMenu(Menu menu, SqlConnection connection, out int identity)
        {
            const string sql = @"
            INSERT INTO [MenuServiceMain].[dbo].[menus] (Name, ExternalId, CustomerId, CreatedByExternalId, UpdatedByExternalId, DateCreatedUtc, DateUpdatedUtc,MenuType)
            VALUES (@Name, @ExternalId, @CustomerId, @CreatedByExternalId, @UpdatedByExternalId, @DateCreatedUtc, @DateUpdatedUtc,@MenuType); 
            SELECT CAST(SCOPE_IDENTITY() as int)";
            identity = connection.Query<int>(sql, menu).Single();
        }

        public Menu FindMenu(Menu menu, SqlConnection connection)
        {

            var menuCollection =
                connection.Query<Menu>("Select * FROM [MenuServiceMain].[dbo].[Menus] WHERE Name = @Name", menu.Name);
            return menuCollection.FirstOrDefault();
        }

        public void RemoveCustomer(Menu menu, SqlConnection connection)
        {
            connection.Execute("DELETE FROM [MenuServiceMain].[dbo].[Menus] WHERE CustomerId = @CustomerId",
            menu.CustomerId);
        }



    }
}
