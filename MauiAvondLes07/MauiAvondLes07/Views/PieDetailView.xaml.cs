using MauiAvondLes07.ViewModels;

namespace MauiAvondLes07.Views;

public partial class PieDetailView : ContentPage
{
	public PieDetailView(PieDetailViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}