namespace Wincubate.FacadeExamples.ApplicationApi;

public interface IApplicationController
{
    bool Start(string applicationName);
    void Stop(string applicationName);
}
