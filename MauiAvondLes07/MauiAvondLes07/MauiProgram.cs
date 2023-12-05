using MauiAvondLes07.Services;
using MauiAvondLes07.ViewModels;
using MauiAvondLes07.Views;
using CommunityToolkit.Maui;
namespace MauiAvondLes07;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseCommunityToolKit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});


		builder.Services.AddSingleton<PieOverviewViewModel>();
		builder.Services.AddTransient<PieOverviewView>();
		builder.Services.AddSingleton<PieDetailViewModel>();
		builder.Services.AddTransient<PieDetailView>();

		// data te kunnen gebruiken
		builder.Services.AddSingleton<IPieRepository, PieRepository>();

//#if DEBUG
//		builder.Logging.AddDebug();
//#endif

		return builder.Build();
	}


}
