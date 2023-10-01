namespace Wincubate.FacadeExamples.SettingsApi;

public interface ISettingsManager
{
    IBluetoothSettings Bluetooth { get; }
    IGpsSettings Gps { get; }
    IMobileDataSettings MobileData { get; }
    IWifiSettings Wifi { get; }
}
