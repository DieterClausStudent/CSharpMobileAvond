namespace MauiAvondlesOef3._3;

public partial class DynamicResourcesPage : ContentPage
{
    private bool _isActive = true;
	public DynamicResourcesPage()
	{
		InitializeComponent();
        Resources["aButtonStyle"] = App.Current.Resources["RegularButtonStyle"];
    }

    private void TestSwitch_Toggled(object sender, ToggledEventArgs e)
    {
        if (_isActive)
        {
            Resources["aButtonStyle"] = App.Current.Resources["DarkButtonStyle"];
        }
        else
        {
            Resources["aButtonStyle"] = App.Current.Resources["RegularButtonStyle"];
        }
        _isActive = !_isActive;
        

    }
}