// Manually created:

using Wincubate.BuilderLabs;

Pizza hawaii = new()
{
    Crust = CrustKind.Classic,
    HasSauce = true,
    Cheese = CheeseKind.Regular,
    Toppings = new List<ToppingKind>
    {
        ToppingKind.Ham,
        ToppingKind.Pineapple
    },
    Oregano = true
};


// Fluent API:

//FluentPizzaBuilder builder = new FluentPizzaBuilder();
//Pizza hawaii = builder
//    .Begin()
//    .WithCrust(CrustKind.Classic)
//    .Sauce
//    .AddCheese()
//    .AddTopping(ToppingKind.Ham)
//    .AddTopping(ToppingKind.Pineapple)
//    .Oregano
//    .Build();

Console.WriteLine( hawaii );
