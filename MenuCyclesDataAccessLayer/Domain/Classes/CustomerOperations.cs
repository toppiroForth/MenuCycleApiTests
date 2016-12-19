using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace MenuCyclesDataAccessLayer.Domain.Classes
{
    public class CustomerOperations
    {
        private static SqlConnection _dbConnection;

        private static Helpers _helpers;

        private List<int> Identities; 

        public void SaveAsNewCustomer(Customer customer, SqlConnection connection, out int identity)
        {
            const string sql = @"
            INSERT INTO [MenuServiceMain].[dbo].[Customers] (Name, ExternalId, CreatedByExternalId, UpdatedByExternalId, DateCreatedUtc, DateUpdatedUtc)
            VALUES (@Name, @ExternalId, @CreatedByExternalId, @UpdatedByExternalId, @DateCreatedUtc, @DateUpdatedUtc); SELECT CAST(SCOPE_IDENTITY() as int)";
            identity = connection.Query<int>(sql, customer).Single();
        }

        public bool CustomerExistsInDb(Customer customer, SqlConnection connection)
        {
            var rows = connection.Query(String.Format(
            "SELECT COUNT(1) as 'Count' FROM [MenuServiceMain].[dbo].[Customers] WHERE Name = '{0}'",
            customer.Name));

            return (int)rows.First().Count > 0;
        }

        public bool CustomerExistsInDbById(int customerId, SqlConnection connection)
        {
            var rows = connection.Query(String.Format(
            "SELECT COUNT(1) as 'Count' FROM [MenuServiceMain].[dbo].[Customers] WHERE CustomerId = {0}",
            customerId));
            return (int)rows.First().Count > 0;
        }

        public Customer FindCustomer(Customer customer, SqlConnection connection)
        {
            var customerCollection = 
                connection.Query<Customer>("FROM [MenuServiceMain].[dbo].[Customers] WHERE Name = @Name", customer.Name);
            return customerCollection.FirstOrDefault();
        }

        public Customer FindCustomerById(int customerId, SqlConnection connection)
        {
            var customerCollection =
                connection.Query<Customer>("SELECT * FROM [MenuServiceMain].[dbo].[Customers] WHERE CustomerId = @CustomerId", new { CustomerId = customerId });
            return customerCollection.FirstOrDefault();
        }

        public List<Group> FindGroups(int customerId, SqlConnection connection)
        {
            var customerCollection =
                connection.Query<Group>("SELECT * FROM [MenuServiceMain].[dbo].[Groups] WHERE CustomerId = @CustomerId", new { CustomerId = customerId });
            return customerCollection.ToList();
        }

        public void RemoveCustomer(Customer customer, SqlConnection connection)
        {
            connection.Execute("FROM [MenuServiceMain].[dbo].[Customers] WHERE CustomerId = @CustomerId", 
                customer.CustomerId);
        }
    }
}
