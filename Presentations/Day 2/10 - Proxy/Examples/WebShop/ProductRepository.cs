namespace Wincubate.ProxyExamples.WebShop;

public class ProductRepository : IProductRepository
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

    public virtual Product GetById(int id) =>
        _products.SingleOrDefault(p => p.Id == id) ??
            throw new ProductException($"Product ID {id} does not exist");

    public virtual IEnumerable<Product> GetAll() => _products.ToList();

    public virtual void Add(Product product)
    {
        if (product == null)
        {
            throw new ArgumentNullException(nameof(product));
        }

        int existingIndex = _products.FindIndex(p => p.Id == product.Id);
        if (existingIndex >= 0)
        {
            _products[existingIndex] = product;
        }
        else
        {
            _products.Add(product);
        }
    }
}
