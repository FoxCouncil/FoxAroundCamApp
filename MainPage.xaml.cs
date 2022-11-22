using Java.Util;
using Microsoft.Maui.Foldable;

namespace FoxAroundCamApp;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

        Device.StartTimer(new TimeSpan(0, 5, 0), TimerTick);
    }

    private bool TimerTick()
    {
        Wv1.Reload();
        Wv2.Reload();

        return true;
    }
}

