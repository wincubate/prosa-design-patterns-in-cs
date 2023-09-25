namespace Wincubate.FactoryMethodExamples;

class Chapter : IPart
{
    public int Number { get; }

    public override string ToString() => $"{nameof(Chapter)} {Number}";

    public Chapter(int number)
    {
        Number = number;
    }
}
