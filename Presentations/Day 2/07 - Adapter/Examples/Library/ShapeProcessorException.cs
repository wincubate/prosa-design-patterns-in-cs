using System.Runtime.Serialization;

namespace Wincubate.AdapterExamples.Library;

/// <summary>
/// Custom exception class for operations relating to the <see cref="ShapeProcessor"/>.
/// </summary>
[Serializable]
public class ShapeProcessorException : Exception
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ShapeProcessorException"/> class.
    /// </summary>
    public ShapeProcessorException()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ShapeProcessorException"/>
    /// class with a specified error message.
    /// </summary>
    /// <param name="message">The message that describes the error.</param>
    public ShapeProcessorException( string message ) : base(message)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ShapeProcessorException"/>
    /// class with a specified error message and a reference to the inner exception
    /// that is the cause of this exception.
    /// </summary>
    /// <param name="message">The message that describes the error.</param>
    /// <param name="inner">The exception that is the cause of the current exception,
    /// or a null reference if no inner exception is specified.</param>
    public ShapeProcessorException( string message, Exception inner ) : base(message, inner)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ShapeProcessorException"/> class
    /// with serialized data.
    /// </summary>
    /// <param name="info">The <see cref="SerializationInfo"/>that holds the
    /// serialized object data about the exception being thrown.</param>
    /// <param name="context">The <see cref="StreamingContext"/> that contains
    /// contextual information about the source or destination.</param>
    protected ShapeProcessorException( SerializationInfo info, StreamingContext context ) : base(info, context)
    {
    }
}