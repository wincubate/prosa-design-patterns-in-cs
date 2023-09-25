namespace Wincubate.BuilderExamples;

class HawaiiPizzaBuilder
{
    public Pizza Product { get; } = new Pizza();

    public void Build()
    {
        BuildCrust();
        AddToppings();
        AddSpices();
    }

    private void BuildCrust()
    {
        Product.Crust = CrustKind.Classic;
        Product.HasSauce = true;
        Product.Cheese = CheeseKind.Regular;
    }

    private void AddToppings()
    {
        Product.Toppings = new List<ToppingKind>
        {
            ToppingKind.Ham,
            ToppingKind.Pineapple
        };
    }

    private void AddSpices()
    {
        Product.Oregano = true;
    }
}