using Microsoft.AspNetCore.Mvc;

namespace Fatec.Rent.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleService vehicleService;

        public VehicleController(IVehicleService vehicleService)
        {
            this.vehicleService = vehicleService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vehicle>>> List(){
            var vehicles = await vehicleService.ListVehicles();

            return vehicles.ToList();
        }
    }
}