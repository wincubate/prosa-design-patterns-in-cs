namespace Wincubate.FacadeExamples.SettingsApi;

public class SettingsManager : ISettingsManager
{
    public IBluetoothSettings Bluetooth => _bluetooth;
    private IBluetoothSettings _bluetooth;

    public IGpsSettings Gps => _gps;
    private IGpsSettings _gps;

    public IMobileDataSettings MobileData => _mobileData;
    private IMobileDataSettings _mobileData;

    public IWifiSettings Wifi => _wifi;
    private readonly IWifiSettings _wifi;

    public SettingsManager()
    {
        _bluetooth = new BluetoothSettings();
        _gps = new GpsSettings();
        _mobileData = new MobileDataSettings();
        _wifi = new WifiSettings();
    }
}
