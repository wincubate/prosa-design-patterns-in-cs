namespace Wincubate.BuilderLabs;

class FluentPizzaBuilder :
    ICrustBuilder,
    ISauceBuilder,
    ICheeseBuilder,
    IToppingsBuilder,
    IPizzaBuilder
{
    private readonly Pizza _pizza;

    public FluentPizzaBuilder()
    {
        _pizza = new Pizza();
    }

    public ICrustBuilder Begin() => this;

    ISauceBuilder ICrustBuilder.WithCrust(CrustKind crust)
    {
        _pizza.Crust = crust;
        return this;
    }

    ICheeseBuilder ISauceBuilder.WithSauce()
    {
        _pizza.HasSauce = true;
        return this;
    }

    ICheeseBuilder ISauceBuilder.WithoutSauce()
    {
        _pizza.HasSauce = false;
        return this;
    }

    IToppingsBuilder ICheeseBuilder.AddCheese(CheeseKind cheese)
    {
        _pizza.Cheese = cheese;
        return this;
    }

    IToppingsBuilder IToppingsBuilder.AddTopping(ToppingKind topping)
    {
        IEnumerable<ToppingKind> existingToppings = _pizza.Toppings;
        _pizza.Toppings = existingToppings.Union(new ToppingKind[] { topping });
        return this;
    }

    IPizzaBuilder IToppingsBuilder.WithOregano()
    {
        _pizza.Oregano = true;
        return this;
    }

    Pizza IPizzaBuilder.Build() => _pizza;
}