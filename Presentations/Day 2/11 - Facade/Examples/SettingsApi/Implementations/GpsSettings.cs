namespace Wincubate.FacadeExamples.SettingsApi;

public class GpsSettings : IGpsSettings
{
    public bool IsEnabled
    {
        get => _isEnabled;
        set
        {
            if (_isEnabled != value)
            {
                Console.WriteLine($"GPS is {(value ? "enabled" : "disabled")}");
                _isEnabled = value;
            }
        }
    }
    private bool _isEnabled;

    public GpsSettings()
    {
        _isEnabled = true;
    }
}
