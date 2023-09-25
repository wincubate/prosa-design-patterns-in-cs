namespace Wincubate.BuilderExamples;

abstract class PizzaBuilder
{
    public Pizza Product { get; } = new Pizza();

    public abstract void BuildCrust();
    public abstract void AddToppings();
    public abstract void AddSpices();
}
