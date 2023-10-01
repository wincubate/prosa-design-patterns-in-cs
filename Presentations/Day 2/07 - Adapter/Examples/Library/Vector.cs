namespace Wincubate.AdapterExamples.Library;

/// <summary>
/// Value object capturing a single 2D vector.
/// </summary>
public struct Vector
{
    /// <summary>
    /// X-coordinate of vector.
    /// </summary>
    public double X { get; set; }

    /// <summary>
    /// Y-coordinate of vector.
    /// </summary>
    public double Y { get; set; }

    /// <summary>
    /// Gets the length of the <see cref="Vector"/>.
    /// </summary>
    public readonly double Length => Math.Sqrt(X * X + Y * Y);

    /// <summary>
    /// Returns a string representation of current <see cref="Vector"/>.
    /// </summary>
    /// <returns>String representation of current <see cref="Vector"/>.</returns>
    public override readonly string ToString() => $"({X},{Y})";

    /// <summary>
    /// Creates a new vector value using the x-coordinate specified by <paramref name="x"/>
    /// and y-coordinate specified by <paramref name="y"/>.
    /// </summary>
    /// <param name="x">X-coordinate of <see cref="Vector"/>.</param>
    /// <param name="y">Y-coordinate of <see cref="Vector"/>.</param>
    public Vector( double x, double y )
    {
        X = x;
        Y = y;
    }
}