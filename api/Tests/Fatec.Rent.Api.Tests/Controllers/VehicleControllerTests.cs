using Fatec.Rent.Api.Controllers;
using Moq;

namespace Fatec.Rent.Api.Tests.Controllers
{
    public class VehicleControllerTests
    {
        [Fact]
        public async Task GET_vehicle_returns_from_service()
        {
            // Arrange
            var expected = new List<Vehicle>();
            
            var service = new Mock<IVehicleService>();
            service.Setup(s => s.ListVehicles()).ReturnsAsync(expected);
            
            var subject = new VehicleController(service.Object);

            // Act
            var result = await subject.List();

            // Assert
            Assert.Equal(expected, result?.Value);
        }
    }
}
