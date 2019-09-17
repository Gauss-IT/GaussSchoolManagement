using System;
using System.Data.SqlClient;

namespace GaussSchoolManagement.DataModel
{
    class ConnectionStringBuilder
    {
        public static string Construct()
        {
            var newConnStringBuilder = new SqlConnectionStringBuilder
            {
                InitialCatalog = "GaussSchool",
                DataSource = $"{Environment.MachineName}\\SQLEXPRESS",
                IntegratedSecurity = true,
                MultipleActiveResultSets = true
            };
            
            return newConnStringBuilder.ToString();
        }
    }
}
