namespace DocumentFun;

class RegularText : DocumentElement
{
    public override void Accept( IVisitor visitor ) => visitor.Visit(this);

    public RegularText( string text ) : base(text)
    {
    }
}
