using Fatec.Rent.Api.Repositories;

namespace Fatec.Rent.Api;

public class VehicleService : IVehicleService
{
    private readonly IVehicleRepository vehicleRepository;

    public VehicleService(IVehicleRepository vehicleRepository)
    {
        this.vehicleRepository = vehicleRepository;
    }

    public IEnumerable<Vehicle> ListVehicles()
    {
        return vehicleRepository.GetAll();
    }
}
