using PieShopStockApp.ViewModels;

namespace PieShopStockApp.Views;

public partial class PieOverviewView : ContentPage
{
	public PieOverviewView(PieOverviewViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}