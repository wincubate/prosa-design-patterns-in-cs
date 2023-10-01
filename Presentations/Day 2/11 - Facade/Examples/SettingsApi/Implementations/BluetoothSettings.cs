namespace Wincubate.FacadeExamples.SettingsApi;

public class BluetoothSettings : IBluetoothSettings
{
    public bool IsEnabled
    {
        get => _isEnabled;
        set
        {
            if( _isEnabled != value )
            {
                Console.WriteLine( $"Bluetooth is {(value ? "enabled" : "disabled")}");
                _isEnabled = value;
            }
        }
    }
    private bool _isEnabled;

    public BluetoothSettings()
    {
        _isEnabled = true;
    }
}
