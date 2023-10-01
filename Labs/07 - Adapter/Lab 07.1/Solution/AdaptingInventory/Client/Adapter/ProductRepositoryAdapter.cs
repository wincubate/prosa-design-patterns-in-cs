namespace Client.Adapter;

class ProductRepositoryAdapter : IInventoryRepository
{
    private readonly WebShop.ProductRepository _proxee;
    public ProductRepositoryAdapter(WebShop.ProductRepository proxee)
    {
        _proxee = proxee;
    }

    public IEnumerable<ItemGroup> GetItemGroups()
    {
        IEnumerable<WebShop.Product> products = _proxee.GetAll();

        IEnumerable<ItemGroup> query = products
            .GroupBy(product => product.Category?.ToString() ?? "Uncategorized")
            .Select(group => new ItemGroup
            (
                group.Key,
                group.Select(product => new Item(
                    product.Name,
                    product.Manufacturer
                ))
            ))
            ;

        return query;
    }
}
