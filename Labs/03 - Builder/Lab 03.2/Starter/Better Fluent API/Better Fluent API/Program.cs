using Wincubate.BuilderLabs;

FluentPizzaBuilder builder = new();
Pizza hawaii = builder
    .Begin()
    .WithCrust(CrustKind.Classic)
    .Sauce
    .AddCheese()
    .AddTopping(ToppingKind.Ham)
    .AddTopping(ToppingKind.Pineapple)
    .Oregano
    .Build();

Console.WriteLine( hawaii );
