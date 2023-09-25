namespace Wincubate.BuilderExamples;

class PizzaDirector
{
    public PizzaBuilder Builder { get; }

    public PizzaDirector( PizzaBuilder builder )
    {
        Builder = builder;
    }

    public Pizza Build()
    {
        Builder.BuildCrust();
        Builder.AddToppings();
        Builder.AddSpices();

        return Builder.Product;
    }
}
