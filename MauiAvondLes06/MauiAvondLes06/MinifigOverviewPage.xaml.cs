using MauiAvondLes06.Models;
using System.Collections.ObjectModel;

namespace MauiAvondLes06;

public partial class MinifigOverviewPage : ContentPage
{
	public ObservableCollection<MiniFig> minfigs = new ObservableCollection<MiniFig>();
	public MinifigOverviewPage()
	{
		InitializeComponent();
        minfigs.Add(new MiniFig() { Name = "Bilbo", ImageUrl = "bilbo.jpg", Race = "Hobbit", Price = 10.50 });
        minfigs.Add(new MiniFig() { Name = "Elrond", ImageUrl = "elrond.jpg", Race = "Elf", Price = 11.00 });
        minfigs.Add(new MiniFig() { Name = "Sam", ImageUrl = "sam.jpg", Race = "Hobbit", Price = 10.50 });
        //BindingContext = minfigs;
        MiniFigsList.ItemsSource = minfigs;
    }

    private void AddButton_Clicked(object sender, EventArgs e)
    {
        minfigs.Add(new MiniFig() { Name = "elrond", ImageUrl = "elrond.jpg", Race = "Hobbit", Price = 8 });
    }
}