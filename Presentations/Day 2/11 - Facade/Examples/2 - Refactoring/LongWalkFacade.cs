using Wincubate.FacadeExamples.ApplicationApi;
using Wincubate.FacadeExamples.SettingsApi;

namespace Wincubate.FacadeExamples;

class LongWalkFacade
{
    private readonly IApplicationController _applicationController;
    private readonly ISettingsManager _settingsManager;

    private SettingsState? _settingsState;
    private bool? _applicationsState;

    private static readonly string _musicAppName = "Dotify";
    private static readonly string _trackerAppName = "Exomondo";

    public LongWalkFacade()
    {
        _applicationController = new ApplicationController();
        _settingsManager = new SettingsManager();
    }

    public void Set()
    {
        SaveExistingSettings();
        SetNewSettings();
        StartApps();
    }

    public void Revert()
    {
        StopApps();
        RestorePreviousSettings();
    }

    #region Settings

    private void SaveExistingSettings()
    {
        IBluetoothSettings bluetooth = _settingsManager.Bluetooth;
        bool wasBluetoothEnabled = bluetooth.IsEnabled;

        IGpsSettings gps = _settingsManager.Gps;
        bool wasGpsEnabled = gps.IsEnabled;

        IMobileDataSettings mobileData = _settingsManager.MobileData;
        bool wasMobileDataEnabled = mobileData.IsEnabled;

        IWifiSettings wifi = _settingsManager.Wifi;
        bool wasWifiEnabled = wifi.IsEnabled;

        _settingsState = new SettingsState
        {
            IsBluetoothEnabled = wasBluetoothEnabled,
            IsGpsEnabled = wasGpsEnabled,
            IsMobileDataEnabled = wasMobileDataEnabled,
            IsWifiEnabled = wasWifiEnabled
        };
    }

    private void SetNewSettings()
    {
        IBluetoothSettings bluetooth = _settingsManager.Bluetooth;
        bluetooth.IsEnabled = false;

        IGpsSettings gps = _settingsManager.Gps;
        gps.IsEnabled = true;

        IMobileDataSettings mobileData = _settingsManager.MobileData;
        mobileData.IsEnabled = true;

        IWifiSettings wifi = _settingsManager.Wifi;
        wifi.IsEnabled = false;
    }

    private void RestorePreviousSettings()
    {
        if (_settingsState.HasValue)
        {
            IBluetoothSettings bluetooth = _settingsManager.Bluetooth;
            bluetooth.IsEnabled = _settingsState.Value.IsBluetoothEnabled;

            IGpsSettings gps = _settingsManager.Gps;
            gps.IsEnabled = _settingsState.Value.IsGpsEnabled;

            IMobileDataSettings mobileData = _settingsManager.MobileData;
            mobileData.IsEnabled = _settingsState.Value.IsMobileDataEnabled;

            IWifiSettings wifi = _settingsManager.Wifi;
            wifi.IsEnabled = _settingsState.Value.IsWifiEnabled;
        }
    }

    #endregion

    #region Applications

    private void StartApps()
    {
        bool wasMusicRunning = _applicationController.Start(_musicAppName);
        _applicationController.Start(_trackerAppName);

        _applicationsState = wasMusicRunning;
    }

    private void StopApps()
    {
        if (_applicationsState.HasValue && _applicationsState.Value == false)
        {
            _applicationController.Stop(_musicAppName);
        }
        _applicationController.Stop(_trackerAppName);
    }

    #endregion
}