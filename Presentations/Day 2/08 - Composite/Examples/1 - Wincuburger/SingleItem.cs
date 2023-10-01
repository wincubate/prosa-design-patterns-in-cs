namespace Wincubate.CompositeExamples;

class SingleItem
{
    public required string Description { get; init; }
    public required decimal Price { get; init; }

    public override string ToString() => $"{Description} [DKK {Price}]";
}
