namespace DocumentFun;

abstract class DocumentElement : IElement
{
    public string Text { get; }

    public DocumentElement( string text ) => Text = text;

    public abstract void Accept( IVisitor visitor );
}
