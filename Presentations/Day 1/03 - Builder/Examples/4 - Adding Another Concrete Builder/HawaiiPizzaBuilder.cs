namespace Wincubate.BuilderExamples;

class HawaiiPizzaBuilder : PizzaBuilder
{
    public override void BuildCrust()
    {
        _pizza.Crust = CrustKind.Classic;
        _pizza.HasSauce = true;
        _pizza.Cheese = CheeseKind.Regular;
    }

    public override void AddToppings()
    {
        _pizza.Toppings = new List<ToppingKind>
        {
            ToppingKind.Ham,
            ToppingKind.Pineapple
        };
    }

    public override void AddSpices()
    {
        _pizza.Oregano = true;
    }
}