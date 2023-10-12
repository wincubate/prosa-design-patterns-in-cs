namespace Wincubate.StrategyExamples;

class Customer
{
    public BarTab Tab { get; }

    private readonly IBillingStrategy _billingStrategy;

    public Customer( IBillingStrategy billingStrategy )
    {
        _billingStrategy = billingStrategy;
        Tab = new BarTab();
    }

    public void PlaceOrder( Order order ) =>
        Tab.Add( new BarTabItem(
            order, 
            _billingStrategy.CalculatePricing( order )
            )
        );
}
