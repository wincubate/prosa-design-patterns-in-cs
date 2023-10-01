namespace Wincubate.AdapterExamples.Library;

/// <summary>
/// Essentially wraps a vertex sequence and interprets it as a
/// triangle strip.
/// </summary>
/// <remarks>See https://msdn.microsoft.com/en-us/library/windows/desktop/bb206274(v=vs.85).aspx</remarks>
public class TriangleStrip
{
    /// <summary>
    /// Gets the <see cref="Vertex"/> sequence of the <see cref="TriangleStrip"/> instance.
    /// </summary>
    public IEnumerable<Vertex> Vertices => _vertices;
    private readonly List<Vertex> _vertices;

    /// <summary>
    /// Creates a new <see cref="TriangleStrip"/> from a <see cref="Vertex"/> sequence.
    /// </summary>
    /// <param name="vertices">Array of <see cref="Vertex"/> values.</param>
    public TriangleStrip( params Vertex[] vertices ) : this( vertices.AsEnumerable() )
    {
    }

    /// <summary>
    /// Creates a new <see cref="TriangleStrip"/> from a <see cref="Vertex"/> sequence.
    /// </summary>
    /// <param name="vertices">Sequence of <see cref="Vertex"/> values.</param>
    public TriangleStrip( IEnumerable<Vertex> vertices )
    {
        if (vertices.Count() < 3)
        {
            throw new ShapeProcessorException($"Must be at least three vertices supplied in {nameof(vertices)}");
        }

        _vertices = vertices.ToList();
    }
}