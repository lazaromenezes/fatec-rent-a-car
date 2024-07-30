namespace Fatec.Rent.Api;

public class Vehicle
{
    public int Id {get; set;}
    public string? Modelo {get; set;}

    public string[] Features {get; set;} = [];
}
