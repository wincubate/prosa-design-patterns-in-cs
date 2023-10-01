using Client;
using Client.Adapter;

InventoryClient client = new(
    new ProductRepositoryAdapter(
        new WebShop.ProductRepository()
    )
);

client.DisplayInventory();
