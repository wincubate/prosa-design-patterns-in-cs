namespace Wincubate.DecoratorExamples;

public abstract class Vehicle : IVehicle
{
    public string Make { get; }
    public VehicleColor Color { get; }

    public override string ToString() => $"\t{Make} [{Color}]{Environment.NewLine}";

    public Vehicle(string make, VehicleColor color)
    {
        Make = make;
        Color = color;
    }
}