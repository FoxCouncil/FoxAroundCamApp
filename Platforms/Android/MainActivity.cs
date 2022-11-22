using Android.App;
using Android.Content.PM;
using Android.OS;

namespace FoxAroundCamApp;

[Activity(
    Label = "CAMS",
    Theme = "@style/Maui.SplashTheme", 
    MainLauncher = true, 
    ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density,
    ScreenOrientation = ScreenOrientation.Portrait)]
public class MainActivity : MauiAppCompatActivity
{

    protected override void OnCreate(Bundle savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        Window.AddFlags(Android.Views.WindowManagerFlags.KeepScreenOn);
        Window.AddFlags(Android.Views.WindowManagerFlags.Fullscreen);
        
        Window.ClearFlags(Android.Views.WindowManagerFlags.ForceNotFullscreen);
    }
}
