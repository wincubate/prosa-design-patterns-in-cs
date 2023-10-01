namespace Wincubate.CompositeExamples;

class GroupItem : IOrderItem
{
    public string Description { get; set; }
    public int DiscountPercentage { get; set; }
    public decimal Price =>
        ((100 - DiscountPercentage) / 100.0m) * _items.Sum(item => item.Price);

    private readonly List<IOrderItem> _items;

    public override string ToString() =>
        $"{Description} [DKK {Price}] " +
        $"{(DiscountPercentage > 0 ? $"({DiscountPercentage}% discount)" : string.Empty )}" +
            Environment.NewLine +
            string.Join(
                Environment.NewLine, 
                _items.Select( item =>
                    $"\t{item.ToString()?.Replace(Environment.NewLine, Environment.NewLine + "\t")}" )
            );

    public void Add( IOrderItem item ) => _items.Add(item);

    public GroupItem( string description, int discountPercentage, params IOrderItem[] items )
        : this( description, discountPercentage, items.AsEnumerable())
    {
    }

    public GroupItem( string description, int discountPercentage, IEnumerable<IOrderItem> items )
    {
        Description = description;
        DiscountPercentage = discountPercentage;
        _items = new List<IOrderItem>(items);
    }
}