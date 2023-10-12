namespace Wincubate.StrategyExamples;

class BarTab
{
    public decimal Total => _items.Sum(ol => ol.Subtotal);

    private readonly List<BarTabItem> _items;

    public BarTab()
    {
        _items = new List<BarTabItem>();
    }

    public void Add(BarTabItem item) => _items.Add(item);

    public void Print()
    {
        Console.WriteLine($"===========- Ye Olde Compiler Bar -===========\t{DateTime.Now.ToString()}{Environment.NewLine}");

        foreach (BarTabItem item in _items)
        {
            Console.WriteLine($"{item.Order.Count} x {item.Order.Product} = {item.Subtotal:c}");
        }
        Console.WriteLine();
        Console.WriteLine($"Total Amount Due: {Total:c}");
        Console.WriteLine("===================================================================");
    }
}
