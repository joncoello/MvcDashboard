using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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

        public async Task<List<Absence.API.Models.Absence>> List()
        {

            using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["main"].ConnectionString))
            {
                await conn.OpenAsync();

                using (var cmd = new SqlCommand("Absence.AbsenceRequest_List", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        var dt = new DataTable();
                        adapter.Fill(dt);

                        var list = new List<Absence.API.Models.Absence>();

                        foreach (DataRow row in dt.Rows)
                        {
                            list.Add(new Models.Absence() {
                                StartDate = Convert.ToDateTime(row["StartDate"]),
                                EndDate = Convert.ToDateTime(row["EndDate"])
                            });
                        }

                        return list;

                    }
                    
                }

            }

        }

    }
}