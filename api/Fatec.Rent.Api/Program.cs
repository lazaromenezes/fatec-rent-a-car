using Fatec.Rent.Api;
using Fatec.Rent.Api.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSingleton<IVehicleService, VehicleService>();
builder.Services.AddSingleton<IVehicleRepository, VehicleRepository>();

var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
