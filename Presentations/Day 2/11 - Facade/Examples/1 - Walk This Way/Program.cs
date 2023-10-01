using Wincubate.FacadeExamples.ApplicationApi;
using Wincubate.FacadeExamples.SettingsApi;

IApplicationController applicationController = new ApplicationController();
ISettingsManager settingsManager = new SettingsManager();

//
// Save old settings
//
IBluetoothSettings bluetooth = settingsManager.Bluetooth;
bool wasBluetoothEnabled = bluetooth.IsEnabled;

IGpsSettings gps = settingsManager.Gps;
bool wasGpsEnabled = gps.IsEnabled;

IMobileDataSettings mobileData = settingsManager.MobileData;
bool wasMobileDataEnabled = mobileData.IsEnabled;

IWifiSettings wifi = settingsManager.Wifi;
bool wasWifiEnabled = wifi.IsEnabled;

//
// Set settings for Long Walk
//
bluetooth.IsEnabled = false;
gps.IsEnabled = true;
mobileData.IsEnabled = true;
wifi.IsEnabled = false;

//
// Start applications for Long Walk
//
string musicAppName = "Dotify";
string trackerAppName = "Exomondo";
bool wasMusicRunning = applicationController.Start(musicAppName);
applicationController.Start(trackerAppName);

//
// Long Walk.....................
//
Console.WriteLine( $"{Environment.NewLine}Long Walk beginning... :-)" );
Thread.Sleep(5000);
Console.WriteLine($"Long Walk ended :-){Environment.NewLine}");

//
// Shutdown applications
//
if ( wasMusicRunning == false )
{
    applicationController.Stop(musicAppName);
}
applicationController.Stop(trackerAppName);

//
// Revert settings back to old values before Long Walk
//
bluetooth.IsEnabled = wasBluetoothEnabled;
gps.IsEnabled = wasGpsEnabled;
mobileData.IsEnabled = wasMobileDataEnabled;
wifi.IsEnabled = wasWifiEnabled;
