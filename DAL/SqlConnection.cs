using System;
using System.Data.SqlClient;

namespace DAL
{
    public class SqlConnectionData
    {
        private string connectionString = @"Server=DESKTOP-KOJMG1E,1433;Database=student-management;User Id=sa;Password=123;MultipleActiveResultSets=true;TrustServerCertificate=true";

        protected SqlConnection Connection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
