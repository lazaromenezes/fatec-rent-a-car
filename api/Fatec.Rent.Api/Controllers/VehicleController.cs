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
        public ActionResult<List<Vehicle>> List(){
            return Ok(vehicleService.ListVehicles());
        }
    }
}