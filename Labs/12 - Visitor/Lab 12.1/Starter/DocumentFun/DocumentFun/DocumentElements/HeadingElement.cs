namespace DocumentFun;

class HeadingElement : DocumentElement
{
    public int Level { get; }

    public HeadingElement( string text, int level ) : base(text)
    {
        Level = level;
    }
}
