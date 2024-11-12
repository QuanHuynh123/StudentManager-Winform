using System;
using System.Data.SqlClient;

namespace DAL
{
    public class SqlConnectionData
    {
        private string connectionString = @"Data Source=DESKTOP-KOJMG1E;Initial Catalog=QLSV;Integrated Security=True;";


        protected SqlConnection Connection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
