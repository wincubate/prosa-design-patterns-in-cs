namespace DocumentFun;

class Hyperlink : DocumentElement
{
    public string Url { get; }

    public override void Accept( IVisitor visitor ) => visitor.Visit(this);

    public Hyperlink( string text, string url ) : base(text)
    {
        Url = url;
    }
}
