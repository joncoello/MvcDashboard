using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Absence.API.Repositories
{
    public class AbsenceRepository
    {
        public async Task Create(Models.Absence absence) {

            using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["main"].ConnectionString))
            {
                await conn.OpenAsync();

                using (var cmd = new SqlCommand("Absence.AbsenceRequest_Create", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@StartDate", absence.StartDate));
                    cmd.Parameters.Add(new SqlParameter("@EndDate", absence.EndDate));

                    await cmd.ExecuteNonQueryAsync();

                }

            }

        }
    }
}