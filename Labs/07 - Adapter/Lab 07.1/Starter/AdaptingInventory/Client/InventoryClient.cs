namespace Client;

class InventoryClient
{
    private readonly IInventoryRepository _repository;

    public InventoryClient( IInventoryRepository repository )
    {
        _repository = repository;
    }

    public void DisplayInventory()
    {
        IEnumerable<ItemGroup> groups = _repository.GetItemGroups();

        foreach (ItemGroup group in groups)
        {
            Console.WriteLine($"Category: {group.Name}");

            foreach (Item item in group.Items)
            {
                Console.WriteLine( $"\t{item}");
            }

            Console.WriteLine();
        }
    }
}
