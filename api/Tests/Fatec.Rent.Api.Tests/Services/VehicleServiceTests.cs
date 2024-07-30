using Fatec.Rent.Api.Repositories;
using Moq;

namespace Fatec.Rent.Api.Tests.Services;

public class VehicleServiceTests
{
    [Fact]
    public void ListVehicles_Returns_From_Repository()
    {
        var expected = new List<Vehicle>{ new() { Id = 1 } };

        var repository = new Mock<IVehicleRepository>();

        repository.Setup(r => r.GetAll()).Returns(expected);

        var subject = new VehicleService(repository.Object);

        var result = subject.ListVehicles();

        Assert.Equal(expected, result);
    }
}