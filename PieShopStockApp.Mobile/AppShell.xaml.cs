using PieShopStockApp.Views;
namespace PieShopStockApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(PieOverviewView),typeof(PieOverviewView));
            Routing.RegisterRoute(nameof(PieDetailView),typeof(PieDetailView));
        }
    }
}