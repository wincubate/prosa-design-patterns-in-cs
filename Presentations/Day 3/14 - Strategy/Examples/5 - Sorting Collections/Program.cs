using Wincubate.StrategyExamples;

List<Product> products = new()
{
    new Beer(),
    new Peanuts(),
    new BloodyArne(),
    new PepsiMax()
};

products.Sort();

foreach (Product product in products)
{
    Console.WriteLine($"{product.Name} of price {product.SuggestedPrice:c}");
}
