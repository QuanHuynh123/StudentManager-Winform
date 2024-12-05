using System;
using System.Data.SqlClient;

namespace DAL
{
    public class SqlConnectionData
    {
        private string connectionString = @"Server=DESKTOP-HDSVCNH\SQLEXPRESS;Database=stm-3;User Id=sa;Password=123;MultipleActiveResultSets=true;TrustServerCertificate=true";

        protected SqlConnection Connection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
