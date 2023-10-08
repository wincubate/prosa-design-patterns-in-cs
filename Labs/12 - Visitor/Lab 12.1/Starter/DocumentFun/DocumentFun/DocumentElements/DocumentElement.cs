namespace DocumentFun;

abstract class DocumentElement
{
    public string Text { get; }

    public DocumentElement( string text ) => Text = text;
}
