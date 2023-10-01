using static System.Math;

namespace Wincubate.AdapterExamples.Library;

/// <summary>
/// Library class for computing various properties of
/// general geometric shapes specified as instances of
/// <see cref="TriangleStrip"/>.
/// </summary>
public class ShapeProcessor
{
    /// <summary>
    /// Computes the area of the <see cref="TriangleStrip"/> specified by <paramref name="ts"/>.
    /// </summary>
    /// <param name="ts"><see cref="TriangleStrip"/> object containing vertices.</param>
    /// <returns>Area of total shape specified by <paramref name="ts"/>.</returns>
    public double GetArea( TriangleStrip ts )
    {
        Vertex[] vertices = ts.Vertices.ToArray();
        if (vertices.Length < 3)
        {
            throw new ShapeProcessorException("Too few vertices");
        }

        double area = 0;

        for( int i = 0; i < vertices.Length - 2; i++ )
        {
            double a = (vertices[i+1] - vertices[i]).Length;
            double b = (vertices[i+2] - vertices[i]).Length;
            double c = (vertices[i+2] - vertices[i+1]).Length;

            area += GetTriangleArea(a, b, c);
        }

        return area;
    }

    /// <summary>
    /// Uses Heron's Formula for computing the area given the three sides
    /// <paramref name="a"/>, <paramref name="b"/>, and <paramref name="c"/>
    /// of the specified triangle.
    /// </summary>
    /// <remarks>See https://en.wikipedia.org/?title=Triangle#Computing_the_area_of_a_triangle</remarks>
    /// <param name="a">First side length of the specified triangle.</param>
    /// <param name="b">Second side length of the specified triangle.</param>
    /// <param name="c">Third side length of the specified triangle.</param>
    /// <returns>Area of the specified triangle.</returns>
    private double GetTriangleArea( double a, double b, double c )
    {
        double s = (a + b + c) / 2.0;
        return Sqrt(s * (s - a) * (s - b) * (s - c));
    }
}
