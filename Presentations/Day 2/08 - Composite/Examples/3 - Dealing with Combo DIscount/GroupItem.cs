using System.Diagnostics.CodeAnalysis;

namespace Wincubate.CompositeExamples;

class GroupItem : IOrderItem
{
    public required string Description { get; init; }
    public int DiscountPercentage { get; init; } = 0;
    public decimal Price =>
        ((100 - DiscountPercentage)/100.0m) * _items.Sum(item => item.Price);

    private readonly List<IOrderItem> _items;

    public override string ToString() =>
        $"{Description} [DKK {Price}] ({DiscountPercentage}% discount)" +
            Environment.NewLine +
            string.Join(
                Environment.NewLine,
                _items.Select(item =>
                    $"\t{item.ToString()?.Replace(Environment.NewLine, Environment.NewLine + "\t")}" )
            );

    public void Add( IOrderItem item ) => _items.Add(item);

    [SetsRequiredMembers]
    public GroupItem( string description, int discountPercentage, params IOrderItem[] items )
        : this( description, discountPercentage, items.AsEnumerable())
    {
    }

    [SetsRequiredMembers]
    public GroupItem( string description, int discountPercentage, IEnumerable<IOrderItem> items )
    {
        Description = description;
        DiscountPercentage = discountPercentage;
        _items = new List<IOrderItem>(items);
    }
}