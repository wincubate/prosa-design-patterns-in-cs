namespace Wincubate.StrategyExamples;

class Order
{
    public int Count { get; init; }
    public Product Product { get; init; }

    public decimal SuggestedSubtotal => Count * Product.SuggestedPrice;

    public Order(int count, Product product)
    {
        Count = count;
        Product = product;
    }
}
