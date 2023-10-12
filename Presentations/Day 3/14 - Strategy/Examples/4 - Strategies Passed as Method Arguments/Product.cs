namespace Wincubate.StrategyExamples;

abstract class Product
{
    public abstract string Name { get; }
    public abstract decimal SuggestedPrice { get; }

    public override string ToString() => Name;

    public override bool Equals(object? obj)
    {
        if (obj is Product p)
        {
            return Name.Equals(p.Name);
        }

        return false;
    }
    public override int GetHashCode() => Name.GetHashCode();
}
