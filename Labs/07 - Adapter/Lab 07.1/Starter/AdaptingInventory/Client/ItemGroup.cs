namespace Client;

class ItemGroup
{
    public string Name { get; init; }
    public List<Item> Items { get; set; }

    public ItemGroup(string name, IEnumerable<Item> items)
    {
        Name = name;
        Items = items.ToList();
    }

    public override string ToString() => $"\"{Name} ({Items.Count} item(s))";
}
