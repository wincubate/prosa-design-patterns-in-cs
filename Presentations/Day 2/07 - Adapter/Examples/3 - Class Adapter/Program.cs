using Wincubate.AdapterExamples;
using Wincubate.AdapterExamples.Client;

Rectangle rectangle = new(1, 2, 3, 4);

AreaClient client = new(
    new ShapeProcessorClassAdapter()
);

Console.WriteLine($"Area of {rectangle} is {client.GetArea(rectangle)}");
