
using Dapper;

namespace Fatec.Rent.Api.Repositories
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly IDbContext dbContext;

        public VehicleRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<Vehicle>> GetAll()
        {
            const string QUERY = "SELECT * FROM Vehicle";

            using var connection = dbContext.CreateConnection();

            return await connection.QueryAsync<Vehicle>(QUERY);
        }
    }
}
