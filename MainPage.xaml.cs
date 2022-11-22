using Microsoft.Maui.Foldable;

namespace FoxAroundCamApp;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();

        DualScreenInfo.Current.SpanMode = Microsoft.Maui.Controls.Foldable.TwoPaneViewMode.Tall;
    }
}

