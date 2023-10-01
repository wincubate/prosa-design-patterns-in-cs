using Wincubate.DecoratorExamples;

IVehicle bmwX1 = new Car("BMW X1", VehicleColor.Black, CarBodyStyle.Sport, 5);
IVehicle bmwM2 = new Car("BMW M2", VehicleColor.CobaltBlue, CarBodyStyle.Coupe, 5);
IVehicle bmwi3 = new Car("BMW i3", VehicleColor.RubyRed, CarBodyStyle.Sedan, 5);
IVehicle kawasakiNinja400 = new Motorcycle("Kawasaki Ninja 400 2018", VehicleColor.LimeGreen, 2, 399);
IVehicle aprilia = new Motorcycle("Aprilia Shiver 900", VehicleColor.Black, 2, 896);

IEnumerable<IVehicle> vehicles = new List<IVehicle>
{
    bmwX1,
    bmwM2,
    bmwi3,
    kawasakiNinja400,
    aprilia
};
foreach (IVehicle vehicle in vehicles)
{
    Console.WriteLine(vehicle);
    Console.WriteLine($"{Environment.NewLine}-------------------------{Environment.NewLine}");
}
