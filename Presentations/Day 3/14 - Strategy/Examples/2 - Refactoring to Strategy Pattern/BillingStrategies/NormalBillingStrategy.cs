namespace Wincubate.StrategyExamples;

class NormalBillingStrategy : IBillingStrategy
{
    public decimal CalculatePricing( Order order ) => order.SuggestedSubtotal;
}
