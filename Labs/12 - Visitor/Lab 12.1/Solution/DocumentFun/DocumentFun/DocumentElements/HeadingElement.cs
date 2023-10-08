namespace DocumentFun;

class HeadingElement : DocumentElement
{
    public int Level { get; }

    public override void Accept( IVisitor visitor ) => visitor.Visit(this);

    public HeadingElement( string text, int level ) : base(text)
    {
        Level = level;
    }
}
