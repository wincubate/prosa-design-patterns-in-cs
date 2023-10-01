namespace Client;

interface IInventoryRepository
{
    IEnumerable<ItemGroup> GetItemGroups();
}
