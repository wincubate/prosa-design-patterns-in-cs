namespace Wincubate.AbstractFactoryExamples;

class Ipad : ITablet
{
    public string Version { get; }
    public double ScreenSizeInch { get; }

    public void PowerOn()
    {
        Console.WriteLine($"Powering on the {ScreenSizeInch}\" screen of an iPad {Version}");
    }

    public void PowerOff()
    {
        Console.WriteLine("Shutting down...");
    }

    public Ipad( string version, double screenSizeInch )
    {
        Version = version;
        ScreenSizeInch = screenSizeInch;
    }
}
