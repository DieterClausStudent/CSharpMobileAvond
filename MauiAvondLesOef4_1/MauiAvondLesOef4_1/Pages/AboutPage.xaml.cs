namespace MauiAvondLesOef4_1.Pages;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();
	}

    private async void BtnBack_Clicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync("..");
    }
}