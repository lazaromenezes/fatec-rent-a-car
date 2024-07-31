namespace Fatec.Rent.Api;

public interface IVehicleService
{
    Task<IEnumerable<Vehicle>> ListVehicles();
}
