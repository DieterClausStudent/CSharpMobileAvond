namespace MauiAvondLesOef4_1.Pages;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}

    private async void BtnGoToTeamPage_Clicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync(nameof(TeamPage));
    }

    private async void BtnGoToSettingsPage_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(SettingsPage));
    }

    private async void BtnGoToAboutPage_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(AboutPage));
    }
}