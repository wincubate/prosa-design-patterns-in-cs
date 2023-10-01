using Wincubate.DecoratorExamples;

IVehicle bmwX1 = new Car("BMW X1", VehicleColor.Black, CarBodyStyle.Sport, 5);
IVehicle bmwM2 = new Car("BMW M2", VehicleColor.CobaltBlue, CarBodyStyle.Coupe, 5);
IVehicle bmwi3 = new Car("BMW i3", VehicleColor.RubyRed, CarBodyStyle.Sedan, 5);
IVehicle kawasakiNinja400 = new Motorcycle("Kawasaki Ninja 400 2018", VehicleColor.LimeGreen, 2, 399);
IVehicle aprilia = new Motorcycle("Aprilia Shiver 900", VehicleColor.Black, 2, 896);

Rental rentalBmwX1 = new Rental(bmwX1, true);
Rental rentalBmwM2 = new Rental(bmwM2, false);
Rental rentalBmwi3 = new Rental(bmwi3, true);
Rental rentalKawasakiNinja400 = new Rental(kawasakiNinja400, true);
Rental rentalAprilia = new Rental(aprilia, true);

// Rent and return
Console.WriteLine(rentalBmwX1);
Console.WriteLine($"{Environment.NewLine}-------------------------{Environment.NewLine}");

rentalBmwX1.Rent("Thorkild Thyrring");

Console.WriteLine(rentalBmwX1);
Console.WriteLine($"{Environment.NewLine}-------------------------{Environment.NewLine}");

rentalBmwX1.Return();

Console.WriteLine(rentalBmwX1);
Console.WriteLine($"{Environment.NewLine}-------------------------{Environment.NewLine}");

//IEnumerable<IVehicle> vehicles = new List<IVehicle>
//{
//    rentalBmwX1,
//    rentalBmwM2,
//    rentalBmwi3,
//    rentalKawasakiNinja400,
//    rentalAsprilia
//};
//foreach (IVehicle vehicle in vehicles)
//{
//    Console.WriteLine(vehicle);
//    Console.WriteLine($"{Environment.NewLine}-------------------------{Environment.NewLine}");
//}
