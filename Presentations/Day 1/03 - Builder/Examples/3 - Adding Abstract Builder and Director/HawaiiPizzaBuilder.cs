namespace Wincubate.BuilderExamples;

class HawaiiPizzaBuilder : PizzaBuilder
{
    public override void BuildCrust()
    {
        Product.Crust = CrustKind.Classic;
        Product.HasSauce = true;
        Product.Cheese = CheeseKind.Regular;
    }

    public override void AddToppings()
    {
        Product.Toppings = new List<ToppingKind>
        {
            ToppingKind.Ham,
            ToppingKind.Pineapple
        };
    }

    public override void AddSpices()
    {
        Product.Oregano = true;
    }
}