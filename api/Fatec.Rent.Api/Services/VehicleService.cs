using Fatec.Rent.Api.Repositories;

namespace Fatec.Rent.Api;

public class VehicleService : IVehicleService
{
    private readonly IVehicleRepository vehicleRepository;

    public VehicleService(IVehicleRepository vehicleRepository)
    {
        this.vehicleRepository = vehicleRepository;
    }

    public Task<IEnumerable<Vehicle>> ListVehicles()
    {
        return vehicleRepository.GetAll();
    }
}
