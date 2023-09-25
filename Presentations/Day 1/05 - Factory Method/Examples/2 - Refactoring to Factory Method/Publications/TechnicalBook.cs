namespace Wincubate.FactoryMethodExamples;

class TechnicalBook : Book
{
    protected override IList<IPart> CreateParts()
    {
        IList<IPart> parts = base.CreateParts();
        parts.Insert(0, new Foreword());
        parts.Add(new Index());

        return parts;
    }

    public TechnicalBook( string title ) : base(title)
    {
    }
}
