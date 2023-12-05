using MauiAvondLes06.Models;

namespace MauiAvondLes06;

public partial class DataBindingPage : ContentPage
{
    public MiniFig  MiniFig { get; set; }
    public DataBindingPage()
	{
		InitializeComponent();
        MiniFig = new MiniFig() { Name = "Bilbo", ImageUrl = "bilbo.png", Race = "Hobbit", Price = 15 };
        this.BindingContext = MiniFig;
	}

    private void SaveButton_Clicked(object sender, EventArgs e)
    {
        string Name = MiniFig.Name;
    }
}