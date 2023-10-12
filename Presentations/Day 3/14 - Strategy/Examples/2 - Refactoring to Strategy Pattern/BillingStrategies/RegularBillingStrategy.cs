namespace Wincubate.StrategyExamples;

class RegularBillingStrategy : IBillingStrategy
{
    public decimal CalculatePricing( Order order ) =>
        0.9m * order.SuggestedSubtotal - (order.Count * 5);
}
