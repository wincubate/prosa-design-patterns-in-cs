using Wincubate.CompositeExamples;

IOrderItem burger = new SingleItem { Description = "Mic Bag Burger", Price = 25 };
IOrderItem fries = new SingleItem { Description = "Curly Braces Fries", Price = 11 };
IOrderItem drink = new SingleItem { Description = "Pepsi Minimum", Price = 16 };
IOrderItem wrap = new SingleItem { Description = "Panel Wrap", Price = 22 };
IOrderItem shake = new SingleItem { Description = "Sharp Shake", Price = 15 };

IOrderItem[] order = 
{
    new GroupItem
    (
        "Curly Mic Combo",
        15,
        burger,
        fries,
        drink
    ),
    wrap,
    shake
};

foreach (IOrderItem item in order)
{
    Console.WriteLine( item );
}
