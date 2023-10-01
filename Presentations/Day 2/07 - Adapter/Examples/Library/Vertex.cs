namespace Wincubate.AdapterExamples.Library;

/// <summary>
/// Value object capturing a single 2D vertex.
/// </summary>
public struct Vertex
{
    /// <summary>
    /// X-coordinate of vertex.
    /// </summary>
    public double X { get; set; }

    /// <summary>
    /// Y-coordinate of vertex.
    /// </summary>
    public double Y { get; set; }

    /// <summary>
    /// Returns a string representation of current <see cref="Vertex"/>.
    /// </summary>
    /// <returns>String representation of current <see cref="Vertex"/>.</returns>
    public override readonly string ToString() => $"({X},{Y})";

    /// <summary>
    /// Computes a <see cref="Vector"/> describing the vector from
    /// vertex <paramref name="v1"/> and vertex <paramref name="v2"/>.
    /// </summary>
    /// <param name="v1">Start vertex of vector.</param>
    /// <param name="v2">End vertex of vector.</param>
    /// <returns></returns>
    public static Vector operator -(Vertex v1, Vertex v2) =>
        new(v2.X - v1.X, v2.Y - v1.Y);

    /// <summary>
    /// Creates a new vertex value using the x-coordinate specified by <paramref name="x"/>
    /// and y-coordinate specified by <paramref name="y"/>.
    /// </summary>
    /// <param name="x">X-coordinate of <see cref="Vertex"/>.</param>
    /// <param name="y">Y-coordinate of <see cref="Vertex"/>.</param>
    public Vertex(double x, double y)
    {
        X = x;
        Y = y;
    }
}