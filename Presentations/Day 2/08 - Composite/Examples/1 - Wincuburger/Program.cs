using Wincubate.CompositeExamples;

SingleItem burger = new() { Description = "Mic Bag Burger", Price = 25 };
SingleItem fries = new() { Description = "Curly Braces Fries", Price = 11 };
SingleItem drink = new() { Description = "Pepsi Minimum", Price = 16 };
SingleItem wrap = new() { Description = "Panel Wrap", Price = 22 };
SingleItem shake = new() { Description = "Sharp Shake", Price = 15 };

SingleItem[] order =
{
    burger,
    fries,
    drink,
    wrap,
    shake
};

foreach (SingleItem item in order)
{
    Console.WriteLine( item );
}
