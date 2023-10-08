using System.Collections;

namespace DocumentFun;

class Document : IEnumerable<DocumentElement>
{
    private readonly IList<DocumentElement> _elements;

    public Document( params DocumentElement[] elements ) : this(elements.AsEnumerable())
    {
    }

    public Document( IEnumerable<DocumentElement> elements )
    {
        _elements = elements.ToList();
    }

    public IEnumerator<DocumentElement> GetEnumerator() => _elements.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
