namespace Wincubate.BuilderExamples;

abstract class PizzaBuilder
{
    public Pizza Product => _pizza;
    protected Pizza _pizza;

    public PizzaBuilder()
    {
        _pizza = new Pizza();
    }

    public abstract void BuildCrust();
    public abstract void AddToppings();
    public abstract void AddSpices();
}
