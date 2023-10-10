using MauiAvondlesOef3._3.Models;

namespace MauiAvondlesOef3._3;

public partial class MainPage : ContentPage
{


	public MainPage()
	{
		InitializeComponent();
        /*
		List<Person> list = new List<Person>();
		list.Add(new Person() { Name="Dieter Claus", City="Sint-Truiden", ImageUrl= "bard.jpg" });
        list.Add(new Person() { Name = "Frederik Claus", City = "Sint-Truiden", ImageUrl = "bilbo.jpg" });
        list.Add(new Person() { Name = "Katjana Struys", City = "Sint-Truiden", ImageUrl = "elrond.jpg" });
        list.Add(new Person() { Name = "Arne Both", City = "Herk-De-Stad", ImageUrl = "galadriel.jpg" });
        list.Add(new Person() { Name = "Lola Claus", City = "Genk", ImageUrl = "gandalf.jpg" });
        list.Add(new Person() { Name = "Bertha Claus", City = "Hasselt", ImageUrl = "https://www.pxl.be/img/logo.png" });
        ColView.ItemsSource = list;
        */
        List<MiniFig> MiniFigs = new List<MiniFig>();
        MiniFigs.Add(new MiniFig() { Name = "bard", Race = "Hobbit", ImageUrl = "bard.jpg" });
        MiniFigs.Add(new MiniFig() { Name = "bilbo", Race = "Hobbit", ImageUrl = "bilbo.jpg" });
        MiniFigs.Add(new MiniFig() { Name = "elrond", Race = "Hobbit", ImageUrl = "elrond.jpg" });
        MiniFigs.Add(new MiniFig() { Name = "galadriel", Race = "Hobbit", ImageUrl = "galadriel.jpg" });
        MiniFigs.Add(new MiniFig() { Name = "gandalf", Race = "Wizard", ImageUrl = "gandalf.jpg" });
        MiniFigs.Add(new MiniFig() { Name = "Gollum", Race = "Monster", ImageUrl = "Gollum.jpg" });
        MiniFigs.Add(new MiniFig() { Name = "Legolas", Race = "Warrior", ImageUrl = "legolas.jpg" });
        MiniFigs.Add(new MiniFig() { Name = "Sam", Race = "Wizard", ImageUrl = "sam.jpg" });


        ColView.ItemsSource = MiniFigs;
    }


}

