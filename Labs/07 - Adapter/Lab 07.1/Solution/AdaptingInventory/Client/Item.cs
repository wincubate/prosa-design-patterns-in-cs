namespace Client;

class Item
{
    public string Name { get; init; }
    public string Supplier { get; init; }

    public Item(string name, string supplier)
    {
        Name = name;
        Supplier = supplier;
    }

    public override string ToString() => $"\"{Name}\" by {Supplier}";
}
