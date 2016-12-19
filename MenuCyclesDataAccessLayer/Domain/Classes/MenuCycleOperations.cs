using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace MenuCyclesDataAccessLayer.Domain.Classes
{
    public class MenuCycleOperations
    {
        private static SqlConnection _dbConnection;

        private static Helpers _helpers;

        public static void SaveAsNewMenuCycle(MenuCycle menuCycle, SqlConnection connection)
        {
            connection.Execute(@"
            INSERT INTO MenuCycles (Name, Description, ParentId, IsPublished, IsMaster, IsDeleted, NonServingDays, CustomerId, CreatedByExternalId, UpdatedByExternalId)
            VALUES (@Name, @Description, @ParentId, @IsPublished, @IsMaster, @IsDeleted, @NonServingDays, @CustomerId, @CreatedByExternalId, @UpdatedByExternalId)",
                menuCycle);
        }

        public static bool MenuCycleExistsInDb(MenuCycle menuCycle, SqlConnection connection)
        {
            var rows = connection.Query(String.Format(
                "SELECT COUNT(1) as 'Count' FROM [MenuServiceMain].[dbo].[MenuCycles] WHERE Name = '{0}'",
                menuCycle.Name));

            return (int) rows.First().Count > 0;
        }

        //public static void AddMultipleMenuCycles(int amount)
        //{
        //    var user = new User()
        //    {
        //        Name = "Victor",
        //        ExternalId = "1",
        //        IsCentral = "Yes",
        //        CustomerId = 1
        //    };

        //    var baseMenuCycleName = String.Format("{0}{1}{2}{3}{4}{5}", DateTime.Now.Year.ToString().PadLeft(2, '0'),
        //        DateTime.Now.Month.ToString().PadLeft(2, '0'),
        //        DateTime.Now.Day.ToString().PadLeft(2, '0'),
        //        DateTime.Now.Hour.ToString().PadLeft(2, '0'),
        //        DateTime.Now.Minute.ToString().PadLeft(2, '0'),
        //        DateTime.Now.Second.ToString().PadLeft(2, '0'));

        //    for (var i = 0; i < amount; i++)
        //    {
        //        var tempMenuCycle = new MenuCycle(user)
        //        {
        //            Name = String.Format("{0}{1}",
        //                baseMenuCycleName, _helpers.RandomString(4)),
        //                Description = "ApiTest MenuCycle Description",
        //                ParentId = 0,
        //                IsPublished = false,
        //                IsMaster = false,
        //                IsDeleted = false,
        //                NonServingDays = 4523,
        //                CustomerId = user.CustomerId,
        //                CreatedByExternalId = user.ExternalId,
        //                UpdatedByExternalId = user.ExternalId
        //        };

        //        SaveAsNewMenuCycle(tempMenuCycle, _dbConnection);
        //    }
        //}
    }
}
