using MauiAvondLesOef4_1.Models;

namespace MauiAvondLesOef4_1.Pages;

public partial class TeamPage : ContentPage
{
	private List<Player> players = new List<Player>();
	public TeamPage()
	{
		InitializeComponent();
		players.Add(new Player() {Name="Romelu Lukaku", ImageUrl = "https://img.a.transfermarkt.technology/portrait/big/96341-1661780981.jpg?lm=1" });
        players.Add(new Player() { Name = "Thibaut Coutois", ImageUrl = "https://www.realmadrid.com/img/vertical_380px/courtois_380x501_20230810054608.jpg" });


        ColViewPlayers.ItemsSource = players;
	}
}