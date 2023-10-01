namespace Wincubate.CompositeExamples
{
    class SingleItem : IOrderItem
    {
        public required string Description { get; init; }
        public required decimal Price { get; set; }

        public override string ToString() => $"{Description} [DKK {Price}]";
    }
}
