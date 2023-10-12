namespace Wincubate.StrategyExamples;

class BarTabItem
{
    public Order Order { get; }
    public decimal Subtotal { get; }

    public BarTabItem( Order order, decimal subtotal )
    {
        Order = order;
        Subtotal = subtotal;
    }
}
