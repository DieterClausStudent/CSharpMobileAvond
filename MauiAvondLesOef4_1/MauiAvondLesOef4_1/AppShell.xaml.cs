using MauiAvondLesOef4_1.Pages;

namespace MauiAvondLesOef4_1;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
        Routing.RegisterRoute(nameof(TeamPage), typeof(TeamPage));
        Routing.RegisterRoute(nameof(SettingsPage), typeof(SettingsPage));
        Routing.RegisterRoute(nameof(AboutPage), typeof(AboutPage));


    }




}
