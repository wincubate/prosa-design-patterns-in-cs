using Wincubate.StrategyExamples;

List<Product> products = new List<Product>
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
