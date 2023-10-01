namespace Wincubate.AdapterExamples;

class ShapeProcessorClassAdapter : Library.ShapeProcessor, Client.IAreaCalculator
{
    public double Compute( Client.Rectangle rectangle )
    {
        // Adapt rectangle to become two triangles
        Library.TriangleStrip triangles = new Library.TriangleStrip(
            new Library.Vertex( rectangle.BottomLeft.x, rectangle.TopRight.y ), // v1
            rectangle.BottomLeft.ToVertex(),                                    // v2
            rectangle.TopRight.ToVertex(),                                      // v3
            new Library.Vertex(rectangle.TopRight.x, rectangle.BottomLeft.y)    // v4            
        );

        return GetArea(triangles);
    }
}
