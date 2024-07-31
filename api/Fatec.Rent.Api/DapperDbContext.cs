
using Microsoft.Data.SqlClient;
using System.Data;

namespace Fatec.Rent.Api
{
    public class DapperDbContext: IDbContext
    {
        private readonly string? connectionString;

        public DapperDbContext(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("rentDb");
        }

        public IDbConnection CreateConnection() => new SqlConnection(connectionString);
    }
}
