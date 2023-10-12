namespace Wincubate.StrategyExamples;

class Customer
{
    public BarTab Tab { get; }

    private readonly Func<Order, decimal> _billingStrategy;

    public Customer(Func<Order, decimal> billingStrategy)
    {
        _billingStrategy = billingStrategy;
        Tab = new BarTab();
    }

    public void PlaceOrder(Order order) =>
        Tab.Add(new BarTabItem(
            order,
            _billingStrategy(order)
            )
        );
}
