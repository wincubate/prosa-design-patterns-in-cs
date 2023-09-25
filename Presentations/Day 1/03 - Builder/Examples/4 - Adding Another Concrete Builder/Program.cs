using Wincubate.BuilderExamples;

PizzaDirector maker = new(
    new HawaiiPizzaBuilder()
);
Pizza hawaii = maker.Build();

Console.WriteLine( hawaii );

maker = new PizzaDirector(
    new PepperoniPizzaBuilder()
);
Pizza pepperoni = maker.Build();

Console.WriteLine(pepperoni);
