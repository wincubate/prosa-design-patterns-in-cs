using System.Diagnostics.CodeAnalysis;

namespace Wincubate.CompositeExamples;

class GroupItem : IOrderItem
{
    public required string Description { get; init; }
    public decimal Price => _items.Sum(item => item.Price);

    private readonly List<IOrderItem> _items;

    public override string ToString() =>
        $"{Description} [DKK {Price}]" + Environment.NewLine +
        string.Join(
            Environment.NewLine,
            _items.Select(item => $"\t{item.ToString()}")
        );

    public void Add(IOrderItem item) => _items.Add(item);

    [SetsRequiredMembers]
    public GroupItem(string description, params IOrderItem[] items)
        : this(description, items.AsEnumerable())
    {
    }

    [SetsRequiredMembers]
    public GroupItem(string description, IEnumerable<IOrderItem> items)
    {
        Description = description;
        _items = new List<IOrderItem>(items);
    }
}
