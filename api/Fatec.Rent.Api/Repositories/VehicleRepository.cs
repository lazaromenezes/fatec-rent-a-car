
namespace Fatec.Rent.Api.Repositories
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly List<Vehicle> vehicles = [
            new Vehicle {Id = 1, Modelo = "Hatch", Features = ["ar", "4 portas", "direção hidraulica"]},
            new Vehicle {Id = 2, Modelo = "Sedan", Features = ["ar", "4 portas", "direção hidraulica", "cambio automatico"]},
            new Vehicle {Id = 3, Modelo = "SUV", Features = ["ar", "4 portas", "direção hidraulica", "cambio automatico", "7 lugares"]}
        ];

        public IEnumerable<Vehicle> GetAll()
        {
            return vehicles;
        }
    }
}
