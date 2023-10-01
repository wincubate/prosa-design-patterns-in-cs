namespace Wincubate.FacadeExamples.SettingsApi;

public class WifiSettings : IWifiSettings
{
    public bool IsEnabled
    {
        get => _isEnabled;
        set
        {
            if (_isEnabled != value)
            {
                Console.WriteLine($"Wifi is {(value ? "enabled" : "disabled")}");
                _isEnabled = value;
            }
        }
    }
    private bool _isEnabled;

    public WifiSettings()
    {
        _isEnabled = true;
    }
}
