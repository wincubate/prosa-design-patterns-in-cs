namespace Wincubate.StrategyExamples;

class Customer
{
    public BarTab Tab { get; }

    public Customer()
    {
        Tab = new BarTab();
    }

    public void PlaceOrder(Order order, Func<Order, decimal> billingStrategy) =>
        Tab.Add(new BarTabItem(
            order,
            billingStrategy(order)
            )
        );
}
