using MenuCyclesDataAccessLayer.Domain.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace MenuCyclesDataAccessLayer.Domain
{
    public class GroupMenusOperations
    {
        public void SaveAsNewGroupMenus(GroupMenus groupMenus, SqlConnection connection)
        {
            const string sql = @"
            INSERT INTO [MenuServiceMain].[dbo].[GroupMenus] (GroupId, MenuId, CreatedByExternalId, UpdatedByExternalId, DateCreatedUtc, DateUpdatedUtc)
            VALUES (@GroupId, @MenuId, @CreatedByExternalId, @UpdatedByExternalId, @DateCreatedUtc, @DateUpdatedUtc);";
            connection.Query<int>(sql, groupMenus);
        }

        public bool GroupLocationsExistsInDb(Group group, Menu menu, SqlConnection connection)
        {
            var rows = connection.Query(String.Format(
            "SELECT COUNT(1) as 'Count' FROM [MenuServiceMain].[dbo].[GroupMenus] WHERE [GroupId] = '{0}' and [MenuId] = '{1}'",
            group.GroupId, menu.MenuId));
            return (int)rows.First().Count > 0;

        }


    }
}
