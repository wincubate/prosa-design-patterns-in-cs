namespace DocumentFun;

class Hyperlink : DocumentElement
{
    public string Url { get; }

    public Hyperlink( string text, string url ) : base(text)
    {
        Url = url;
    }
}
