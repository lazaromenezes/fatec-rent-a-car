using Fatec.Rent.API.Controllers;
using Microsoft.Extensions.Logging;
using Moq;

namespace Fatec.Rent.API.Tests
{
    public class VehicleControllerTests
    {
        VehicleController subject;
        Mock<IVehicleRepository> repositorio;

        public VehicleControllerTests()
        {
            // ARRANGE [preparar]
            repositorio = new Mock<IVehicleRepository>();

            subject = new VehicleController(
                Mock.Of<ILogger<VehicleController>>(),
                repositorio.Object
            );
        }

        [Fact]
        public async Task GET_retorna_uma_lista_de_veiculos()
        {
            // ACT [agir]
            var veiculos = await subject.Get();

            // ASSERT [validar]
            Assert.IsAssignableFrom<IEnumerable<Vehicle>>(veiculos);
        }

        [Fact]
        public async Task GET_retorna_a_lista_retornada_do_repositorio()
        {
            // ARRANGE [preparar]
            var esperado = new List<Vehicle>();
            repositorio.Setup(r => r.GetAll()).ReturnsAsync(esperado);

            // ACT [agir]
            var veiculos = await subject.Get();

            // ASSERT [validar]
            Assert.Same(esperado, veiculos);
        }
    }
}