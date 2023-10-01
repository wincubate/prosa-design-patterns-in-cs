namespace Wincubate.FacadeExamples.ApplicationApi;

public class ApplicationController : IApplicationController
{
    public bool Start(string applicationName)
    {
        Console.WriteLine($"{applicationName} started");

        return false;
    }

    public void Stop(string applicationName)
    {
        Console.WriteLine($"{applicationName} stopped");
    }
}