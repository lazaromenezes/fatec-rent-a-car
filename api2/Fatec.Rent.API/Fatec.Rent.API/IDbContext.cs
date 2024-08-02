using System.Data;

namespace Fatec.Rent.API
{
    public interface IDbContext
    {
        IDbConnection GetConnection();
    }
}
