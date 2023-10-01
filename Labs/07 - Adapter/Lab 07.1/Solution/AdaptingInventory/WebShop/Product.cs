namespace WebShop;

public class Product
{
    public int Id { get; }
    public string Name { get; }
    public string Manufacturer { get; }
    public Category? Category { get; }

    public Product( int id, string name, string manufacturer, Category? category = null )
    {
        Id = id;
        Name = name;
        Manufacturer = manufacturer;
        Category = category;
    }
}
