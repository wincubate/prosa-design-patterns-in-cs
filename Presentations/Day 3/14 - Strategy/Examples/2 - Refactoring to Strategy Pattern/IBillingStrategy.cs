namespace Wincubate.StrategyExamples;

interface IBillingStrategy
{
    decimal CalculatePricing( Order order );
}
