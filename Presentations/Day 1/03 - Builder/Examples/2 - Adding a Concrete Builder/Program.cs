using Wincubate.BuilderExamples;

HawaiiPizzaBuilder builder = new();
builder.Build();
Pizza hawaii = builder.Product;

Console.WriteLine(hawaii);
