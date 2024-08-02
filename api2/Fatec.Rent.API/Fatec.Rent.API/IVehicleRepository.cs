namespace Fatec.Rent.API
{
    public interface IVehicleRepository
    {
        Task<IEnumerable<Vehicle>> GetAll();
    }
}
