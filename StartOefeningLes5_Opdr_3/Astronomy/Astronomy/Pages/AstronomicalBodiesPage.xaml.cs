namespace Astronomy.Pages;

public partial class AstronomicalBodiesPage : ContentPage
{
	public AstronomicalBodiesPage()
	{
		InitializeComponent();

        btnComet.Clicked += async (s, e) => await Shell.Current.GoToAsync("Astronomicalbodydetails?astroName=comet"); //$"{nameof(AstronomicalBodiesPage)}" als je nameof hebt gbruikt
        btnEarth.Clicked += async(s,e) => await Shell.Current.GoToAsync("Astronomicalbodydetails?astroName=earth");
        btnSun.Clicked += async( s,e) => await Shell.Current.GoToAsync("Astronomicalbodydetails?astroName=sun");
        btnMoon.Clicked += async (s, e) => await Shell.Current.GoToAsync("Astronomicalbodydetails?astroName=moon");
    }

  

   
}