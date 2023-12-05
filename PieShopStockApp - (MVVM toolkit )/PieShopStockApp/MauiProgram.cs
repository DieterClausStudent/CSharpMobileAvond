using Microsoft.Extensions.Logging;
using PieShopStockApp.Services;
using PieShopStockApp.ViewModels;
using PieShopStockApp.Views;
using CommunityToolkit.Maui;

namespace PieShopStockApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddSingleton<PieOverviewViewModel>();
            builder.Services.AddSingleton<PieOverviewView>();
            builder.Services.AddTransient<PieDetailView>();
            builder.Services.AddTransient<PieDetailViewModel>();
            builder.Services.AddSingleton<IPieRepository, PieRepository>();
            builder.Services.AddSingleton<INavigationService, MauiNavigationService>();


#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}