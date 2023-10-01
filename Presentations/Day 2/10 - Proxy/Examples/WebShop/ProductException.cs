using System.Runtime.Serialization;

namespace Wincubate.ProxyExamples.WebShop;

/// <summary>
/// Custom exception class for operations relating to the <see cref="ProductRepository"/>.
/// </summary>
[Serializable]
public class ProductException : Exception
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductException"/> class.
    /// </summary>
    public ProductException()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ProductException"/>
    /// class with a specified error message.
    /// </summary>
    /// <param name="message">The message that describes the error.</param>
    public ProductException(string message) : base(message)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ProductException"/>
    /// class with a specified error message and a reference to the inner exception
    /// that is the cause of this exception.
    /// </summary>
    /// <param name="message">The message that describes the error.</param>
    /// <param name="inner">The exception that is the cause of the current exception,
    /// or a null reference if no inner exception is specified.</param>
    public ProductException(string message, Exception inner) : base(message, inner)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ProductException"/> class
    /// with serialized data.
    /// </summary>
    /// <param name="info">The <see cref="SerializationInfo"/>that holds the
    /// serialized object data about the exception being thrown.</param>
    /// <param name="context">The <see cref="StreamingContext"/> that contains
    /// contextual information about the source or destination.</param>
    protected ProductException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}