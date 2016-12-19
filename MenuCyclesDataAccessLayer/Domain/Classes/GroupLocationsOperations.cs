using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace MenuCyclesDataAccessLayer.Domain.Classes
{
    public class GroupLocationsOperations
    {
        public void SaveAsNewGroupLocation(GroupLocations groupLocations, SqlConnection connection)
        {            
            const string sql = @"
            INSERT INTO [MenuServiceMain].[dbo].[GroupLocations] (GroupId, LocationId, CreatedByExternalId, UpdatedByExternalId, DateCreatedUtc, DateUpdatedUtc)
            VALUES (@GroupId, @LocationId, @CreatedByExternalId, @UpdatedByExternalId, @DateCreatedUtc, @DateUpdatedUtc);";
            connection.Query<int>(sql, groupLocations);
        }

        public bool GroupLocationsExistsInDb(Group group, Location location, SqlConnection connection)
        {
            var rows = connection.Query(String.Format(
            "SELECT COUNT(1) as 'Count' FROM [MenuServiceMain].[dbo].[GroupLocations] WHERE [GroupId] = '{0}' and [LocationId] = '{1}'",
            group.GroupId, location.LocationId));

            return (int)rows.First().Count > 0;
        }
    }
}
