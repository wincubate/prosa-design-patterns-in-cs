namespace Wincubate.AdapterExamples;

public static class TupleExtensions
{
    public static Library.Vertex ToVertex( this (int x, int y) t ) => new Library.Vertex(t.x, t.y);
}
