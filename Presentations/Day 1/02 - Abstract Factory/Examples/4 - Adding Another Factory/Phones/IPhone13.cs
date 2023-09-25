namespace Wincubate.AbstractFactoryExamples;

class IPhone13 : IMobilePhone
{
    public int MemoryGb { get; }

    public IPhone13( int memoryGb )
    {
        MemoryGb = memoryGb;
    }

    public void Call( string who )
    {
        Console.WriteLine($"Calling {who} from an iPhone 13 with {MemoryGb} GB of memory");
    }
}
