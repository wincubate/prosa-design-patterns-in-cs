using Wincubate.BuilderLabs;

Pizza hawaii = new FluentPizzaBuilder()
    .Begin()
    .WithCrust(CrustKind.Classic)
    .WithSauce()
    .AddCheese()
    .AddTopping(ToppingKind.Ham)
    .AddTopping(ToppingKind.Pineapple)
    .WithOregano()
    .Build();

Console.WriteLine(hawaii);
