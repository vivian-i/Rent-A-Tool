using Microsoft.Data.SqlClient;
using System.Data;

namespace RentAToolWebApp.Data
{
    public class DatabaseConnection
    {
        private readonly IConfiguration _config;
        private readonly string _connString = "";

        public DatabaseConnection(IConfiguration config) 
        {
            _config = config;
            _connString = _config.GetConnectionString("DefaultConnection");
        }

        public IDbConnection CreateDbConnection()
        {
            return new SqlConnection(_connString);
        }

    }
}
