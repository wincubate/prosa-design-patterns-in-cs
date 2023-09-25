namespace Wincubate.FactoryMethodExamples;

class Book : Publication
{
    public Book( string title ) : base(title)
    {
    }

    protected override IList<IPart> CreateParts() => new List<IPart>
    {
        new Chapter( 1 ),
        new Chapter( 2 ),
        new Chapter( 3 )
    };
}
