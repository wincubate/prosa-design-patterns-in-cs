namespace WebShop;

public class ProductRepository
{
    private readonly List<Product> _products;

    public ProductRepository()
    {
        _products = new List<Product>
        {
            new Product( 1, "HoloLens", "Microsoft", Category.Hardware ),
            new Product( 2, "Business Suit Boba Goes Looking for Love in Aldaraan Places", "Wincubate Games", Category.Software ),
            new Product( 3, "Design Patterns in C#", "Gang of One", Category.Book ),
            new Product( 4, "How to survive without Internet", "Chris MacDonald", Category.Book ),
            new Product( 5, "Switch", "Nintendo", Category.Hardware ),
            new Product( 6, "Switch Controller", "Nintendo", Category.Hardware )
        };
    }

    public IEnumerable<Product> GetAll()
    {
        return _products.ToList();
    }
}
