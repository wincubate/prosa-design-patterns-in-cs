using Wincubate.AdapterExamples.Client;

namespace Wincubate.AdapterExamples;

class ShapeProcessorAdapter : IAreaCalculator
{
    private Library.ShapeProcessor _adaptee;

    public ShapeProcessorAdapter( Library.ShapeProcessor adaptee )
    {
        _adaptee = adaptee;
    }

    public double Compute( Rectangle rectangle )
    {
        // Adapt rectangle to become two triangles
        Library.TriangleStrip triangles = new Library.TriangleStrip(
            new Library.Vertex( rectangle.BottomLeft.x, rectangle.TopRight.y ), // v1
            rectangle.BottomLeft.ToVertex(),                                    // v2
            rectangle.TopRight.ToVertex(),                                      // v3
            new Library.Vertex(rectangle.TopRight.x, rectangle.BottomLeft.y)    // v4            
        );

        return _adaptee.GetArea(triangles);
    }
}
