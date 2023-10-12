namespace Wincubate.StrategyExamples;

class StudentBillingStrategy : IBillingStrategy
{
    public decimal CalculatePricing( Order order ) =>
        (order.Product is Beer ?
            order.SuggestedSubtotal - (order.Count * 5) :
            order.SuggestedSubtotal);
}
