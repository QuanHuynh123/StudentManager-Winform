using System;
using System.Data.SqlClient;

namespace DAL
{
    public class SqlConnectionData
    {
        private string connectionString = @"Server=TANVO-BE,1433;Database=student-management;User Id=root;Password=123;MultipleActiveResultSets=true;TrustServerCertificate=true";


        protected SqlConnection Connection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
