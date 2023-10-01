namespace Wincubate.ProxyExamples.WebShop;

public class Product
{
    public int Id { get; }
    public string Name { get; }
    public string Manufacturer { get; }
    public Category? Category { get; }

    public override string ToString()
        => $"[{Id}] {Category?.ToString() ?? "-"}: \"{Name}\" by {Manufacturer}";

    public Product( int id, string name, string manufacturer, Category? category = null )
    {
        Id = id;
        Name = name;
        Manufacturer = manufacturer;
        Category = category;
    }
}
