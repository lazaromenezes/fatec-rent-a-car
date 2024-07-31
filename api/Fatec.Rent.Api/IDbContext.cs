using System.Data;

namespace Fatec.Rent.Api
{
    public interface IDbContext
    {
        IDbConnection CreateConnection();
    }
}
