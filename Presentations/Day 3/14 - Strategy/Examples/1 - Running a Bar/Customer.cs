namespace Wincubate.StrategyExamples;

class Customer
{
    public BarTab Tab { get; }

    private readonly Billing _billing;

    public Customer( Billing billing )
    {
        _billing = billing;
        Tab = new BarTab();
    }

    public void PlaceOrder( Order order )
    {
        decimal adjustedSubtotal = 0.0m;
        switch (_billing)
        {
            case Billing.Normal:
                adjustedSubtotal = CalculateNormalPricing(order);
                break;
            case Billing.StudentDiscount:
                adjustedSubtotal = CalculateStudentPricing(order);
                break;
            case Billing.Regular:
                adjustedSubtotal = CalculateRegularPricing(order);
                break;
            default:
                throw new NotSupportedException($"Billing not specified for this customer");
        }


        Tab.Add(new BarTabItem(order, adjustedSubtotal));
    }

    private decimal CalculateNormalPricing( Order order ) => order.SuggestedSubtotal;

    private decimal CalculateStudentPricing( Order order ) =>
        (order.Product is Beer ?
            order.SuggestedSubtotal - (order.Count * 5) :
            order.SuggestedSubtotal
        );

    private decimal CalculateRegularPricing( Order order ) =>
        0.9m * order.SuggestedSubtotal - (order.Count * 5);
}
