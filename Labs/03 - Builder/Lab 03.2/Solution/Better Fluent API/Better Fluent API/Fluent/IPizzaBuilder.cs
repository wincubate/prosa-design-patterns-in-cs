namespace Wincubate.BuilderLabs;

internal interface ICrustBuilder
{
    ISauceBuilder WithCrust(CrustKind crust = CrustKind.Classic);
}

internal interface ISauceBuilder
{
    ICheeseBuilder WithSauce();
    ICheeseBuilder WithoutSauce();
}

internal interface ICheeseBuilder
{
    IToppingsBuilder AddCheese(CheeseKind cheese = CheeseKind.Regular);
}

internal interface IToppingsBuilder : IPizzaBuilder
{
    IToppingsBuilder AddTopping(ToppingKind topping);
    IPizzaBuilder WithOregano();
}

internal interface IPizzaBuilder
{
    Pizza Build();
}
