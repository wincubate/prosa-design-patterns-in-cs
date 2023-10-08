namespace DocumentFun;

class BoldText : DocumentElement
{
    public override void Accept( IVisitor visitor ) => visitor.Visit(this);

    public BoldText( string text ) : base(text)
    {
    }
}
