namespace Wincubate.FactoryMethodExamples;

class Tabloid : Publication
{
    public Tabloid( string title ) : base(title)
    {
    }

    protected override IList<IPart> CreateParts() => new List<IPart>
    {
            new FakeNews(),
            new Gossip(),
            new Gossip(),
            new FakeNews()
    };
}
