namespace Wincubate.DecoratorExamples;

public abstract class VehicleDecorator : IVehicle
{
    protected readonly IVehicle _decoratee;

    public string Make => _decoratee.Make;
    public VehicleColor Color => _decoratee.Color;

    public override string? ToString() => _decoratee.ToString();

    public VehicleDecorator( IVehicle decoratee )
    {
        _decoratee = decoratee;
    }
}
