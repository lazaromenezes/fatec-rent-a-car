namespace Fatec.Rent.Api.Repositories
{
    public interface IVehicleRepository
    {
        IEnumerable<Vehicle> GetAll();
    }
}
