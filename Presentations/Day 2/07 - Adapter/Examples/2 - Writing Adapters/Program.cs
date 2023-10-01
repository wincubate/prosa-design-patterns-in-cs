using Wincubate.AdapterExamples;
using Wincubate.AdapterExamples.Client;
using Wincubate.AdapterExamples.Library;

Rectangle rectangle = new(1, 2, 3, 4);

AreaClient client = new(
    new ShapeProcessorAdapter(
        new ShapeProcessor()
    )
);

Console.WriteLine($"Area of {rectangle} is {client.GetArea(rectangle)}");
