using Fatec.Rent.Api.Repositories;
using Moq;

namespace Fatec.Rent.Api.Tests.Services;

public class VehicleServiceTests
{
    [Fact]
    public async Task ListVehicles_Returns_From_Repository()
    {
        // ARRANGE
        var expected = new List<Vehicle>{ new() { Id = Guid.NewGuid() } };
        
        var repository = new Mock<IVehicleRepository>();
        repository.Setup(r => r.GetAll()).ReturnsAsync(expected);

        var subject = new VehicleService(repository.Object);

        // ACT
        var result = await subject.ListVehicles();

        // ASSERT
        Assert.Equal(expected, result);
    }
}