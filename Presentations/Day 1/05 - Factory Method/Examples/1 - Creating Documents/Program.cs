using Wincubate.FactoryMethodExamples;
using Index = Wincubate.FactoryMethodExamples.Index;

Publication fiction = new("Harry Porter goes Beer-binging")
{
    new Chapter( 1 ),
    new Chapter( 2 ),
    new Chapter( 3 )
};
fiction.Print();

Console.WriteLine();

Publication technicalBook = new("Gang of Four Design Patterns in C#")
{
    new Foreword(),
    new Chapter( 1 ),
    new Chapter( 2 ),
    new Chapter( 3 ),
    new Index()
};
technicalBook.Print();

Console.WriteLine();

Publication tabloid = new("Krazy W00rld")
{
    new FakeNews(),
    new Gossip(),
    new Gossip(),
    new FakeNews()
};
tabloid.Print();