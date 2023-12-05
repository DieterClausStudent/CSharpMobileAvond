using MauiAvondLes07.ViewModels;

namespace MauiAvondLes07.Views;

public partial class PieOverviewView : ContentPage
{
	public PieOverviewView(PieOverviewViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}