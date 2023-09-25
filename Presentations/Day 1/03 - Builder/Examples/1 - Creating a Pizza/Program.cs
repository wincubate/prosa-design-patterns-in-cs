using Wincubate.BuilderExamples;

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

Console.WriteLine(hawaii);
