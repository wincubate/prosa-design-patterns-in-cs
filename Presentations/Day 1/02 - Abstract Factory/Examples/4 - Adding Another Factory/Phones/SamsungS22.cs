namespace Wincubate.AbstractFactoryExamples;

enum S22Kind
{
    Regular,
    Plus
}

class SamsungS22 : IMobilePhone
{
    public S22Kind Kind { get; }

    public SamsungS22(S22Kind kind)
    {
        Kind = kind;
    }

    public void Call(string who)
    {
        Console.WriteLine($"Calling {who} from an Samsung S22{(Kind == S22Kind.Plus ? "+" : "")}");
    }
}
