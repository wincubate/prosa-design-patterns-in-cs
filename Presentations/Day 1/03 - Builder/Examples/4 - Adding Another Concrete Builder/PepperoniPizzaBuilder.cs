namespace Wincubate.BuilderExamples;

class PepperoniPizzaBuilder : PizzaBuilder
{
    public override void BuildCrust()
    {
        _pizza.Crust = CrustKind.StuffedCrust;
        _pizza.HasSauce = true;
        _pizza.Cheese = CheeseKind.Extra;
    }

    public override void AddToppings()
    {
        _pizza.Toppings = new List<ToppingKind>
        {
            ToppingKind.Pepperoni,
            ToppingKind.Jalapenos,
            ToppingKind.Pineapple
        };
    }

    public override void AddSpices()
    {
        _pizza.Oregano = true;
    }
}
