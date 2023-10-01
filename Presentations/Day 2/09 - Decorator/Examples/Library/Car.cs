namespace Wincubate.DecoratorExamples;

public class Car : Vehicle
{
    public CarBodyStyle BodyStyle { get; }
    public int Doors { get; }

    public override string ToString()
    {
        string s = $"Car:" + Environment.NewLine +
            base.ToString() +
            $"\t{BodyStyle} / {Doors} doors";

        return s;
    }

    public Car(string make, VehicleColor color, CarBodyStyle bodyStyle, int doors)
        : base(make, color)
    {
        BodyStyle = bodyStyle;
        Doors = doors;
    }
}