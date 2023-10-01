namespace Wincubate.FacadeExamples.SettingsApi;

public class MobileDataSettings : IMobileDataSettings
{
    public bool IsEnabled
    {
        get => _isEnabled;
        set
        {
            if (_isEnabled != value)
            {
                Console.WriteLine($"Mobile Data is {(value ? "enabled" : "disabled")}");
                _isEnabled = value;
            }
        }
    }
    private bool _isEnabled;

    public MobileDataSettings()
    {
        _isEnabled = true;
    }
}
