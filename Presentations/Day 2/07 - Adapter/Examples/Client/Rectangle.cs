namespace Wincubate.AdapterExamples.Client;

public readonly struct Rectangle
{
    public (int x, int y) BottomLeft { get; }
    public (int x, int y) TopRight { get; }

    public override readonly string ToString() => $"[{BottomLeft},{TopRight}]";

    public Rectangle(int x1, int y1, int x2, int y2)
    {
        BottomLeft = (x1, y1);
        TopRight = (x2, y2);
    }
}
