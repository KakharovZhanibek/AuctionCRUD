using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction
{
    public class OrganizationRepository
    {
        private string GetTableName()
        {
            return $"[dbo].[Organizations]";
        }

        public Organization Read(Guid Id)
        {
            DataSet dataSet = new DataSet();
            Organization organization = new Organization();
            
            string selectSql = $"SELECT * FROM {GetTableName()} WHERE OrganizationId = {Id}";
            using (SqlConnection connection = new SqlConnection(ApplicationSettings.CONNECTION_STRING))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(selectSql, connection))
                {
                    adapter.Fill(dataSet, "Organizations");
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
                    DataRow row = dataSet.Tables["Organizations"].Rows[0];
                }
            }
            return null;
        }
    }
}
