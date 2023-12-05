using PieShopStockApp.ViewModels;

namespace PieShopStockApp.Views;

public partial class PieDetailView : ContentPage
{
	public PieDetailView(PieDetailViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}