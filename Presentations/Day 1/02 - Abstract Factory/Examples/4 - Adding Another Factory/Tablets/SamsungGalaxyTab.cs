namespace Wincubate.AbstractFactoryExamples;

class SamsungGalaxyTab : ITablet
{
    public string Version { get; }

    public SamsungGalaxyTab( string version )
    {
        Version = version;
    }

    public void PowerOn()
    {
        Console.WriteLine($"Powering on a Samsung Galaxy Tab {Version} ready to 'droid");
    }

    public void PowerOff()
    {
        Console.WriteLine( "Plup! Shut down..!" );
    }
}
