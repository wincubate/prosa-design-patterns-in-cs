namespace Wincubate.DecoratorExamples;

public class Motorcycle : Vehicle
{
    public int Wheels { get; }
    public int Cc { get; }

    public override string ToString()
    {
        string s = $"Motorcycle:" + Environment.NewLine +
            base.ToString() +
            $"\t{Wheels} wheels / {Cc}CC";

        return s;
    }

    public Motorcycle(string make, VehicleColor color, int wheels, int cc)
        : base(make, color)
    {
        Wheels = wheels;
        Cc = cc;
    }
}
