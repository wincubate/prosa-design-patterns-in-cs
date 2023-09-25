using Wincubate.BuilderExamples;

PizzaDirector maker = new(
    new HawaiiPizzaBuilder()
);
Pizza hawaii = maker.Build();

Console.WriteLine(hawaii);
