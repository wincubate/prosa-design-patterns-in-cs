using System.Collections;

namespace Wincubate.FactoryMethodExamples;

class Publication : IEnumerable<IPart>
{
    public string Title { get; }
    public IList<IPart> Parts { get; }

    public Publication( string title )
    {
        Title = title;
        Parts = new List<IPart>();
    }

    public void Add( IPart part ) => Parts.Add(part);

    public void Print()
    {
        Console.WriteLine($"{Title.ToUpper()}:{Environment.NewLine}{new string('=', Title.Length)}");

        foreach (IPart part in Parts)
        {
            Console.WriteLine(part);
        }
    }

    #region IEnumerable<IPart> Members

    public IEnumerator<IPart> GetEnumerator()
    {
        return Parts.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    #endregion
}
