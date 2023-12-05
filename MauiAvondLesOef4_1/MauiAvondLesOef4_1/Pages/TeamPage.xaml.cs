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
		players.Add(new Player() { Name = "Johan bakayoko", ImageUrl = "https://belgianfootball.s3.eu-central-1.amazonaws.com/s3fs-public/rbfa/img/players/internationals/football/men/6860.jpg" });
        players.Add(new Player() { Name = "Mitchy Batshuayi", ImageUrl = "https://belgianfootball.s3.eu-central-1.amazonaws.com/s3fs-public/rbfa/img/players/internationals/football/men/6211.jpg" });
        players.Add(new Player() { Name = "Arnaud Bodard", ImageUrl = "https://belgianfootball.s3.eu-central-1.amazonaws.com/s3fs-public/rbfa/img/players/internationals/football/men/6282.jpg" });
        players.Add(new Player() { Name = "Yannick Carrasco", ImageUrl = "https://belgianfootball.s3.eu-central-1.amazonaws.com/s3fs-public/rbfa/img/players/internationals/football/men/5581.jpg" });
        players.Add(new Player() { Name = "Timothy Castange", ImageUrl = "https://belgianfootball.s3.eu-central-1.amazonaws.com/s3fs-public/rbfa/img/players/internationals/football/men/6392.jpg" });
        players.Add(new Player() { Name = "Koen casteels", ImageUrl = "https://belgianfootball.s3.eu-central-1.amazonaws.com/s3fs-public/rbfa/img/players/internationals/football/men/5470.jpg" });
        players.Add(new Player() { Name = "Charles De Keteleare", ImageUrl = "https://belgianfootball.s3.eu-central-1.amazonaws.com/s3fs-public/rbfa/img/players/internationals/football/men/6791.jpg" });
        players.Add(new Player() { Name = "Zeno Debast", ImageUrl = "https://belgianfootball.s3.eu-central-1.amazonaws.com/s3fs-public/rbfa/img/players/internationals/football/men/6868.jpg" });
        players.Add(new Player() { Name = "Olivier Deman", ImageUrl = "https://belgianfootball.s3.eu-central-1.amazonaws.com/s3fs-public/rbfa/img/players/internationals/football/men/7087.jpg" });
        players.Add(new Player() { Name = "Jeremy Doku", ImageUrl = "https://belgianfootball.s3.eu-central-1.amazonaws.com/s3fs-public/rbfa/img/players/internationals/football/men/6725.jpg" });
        players.Add(new Player() { Name = "Wout Faes", ImageUrl = "https://belgianfootball.s3.eu-central-1.amazonaws.com/s3fs-public/rbfa/img/players/internationals/football/men/6379.jpg" });
        players.Add(new Player() { Name = "Thomas Kaminski", ImageUrl = "https://belgianfootball.s3.eu-central-1.amazonaws.com/s3fs-public/rbfa/img/players/internationals/football/men/5514.jpg" });
        players.Add(new Player() { Name = "Mandela Keita", ImageUrl = "https://belgianfootball.s3.eu-central-1.amazonaws.com/s3fs-public/rbfa/img/players/internationals/football/men/7140.jpg" });
        players.Add(new Player() { Name = "Romelu Lukaku", ImageUrl = "https://belgianfootball.s3.eu-central-1.amazonaws.com/s3fs-public/rbfa/img/players/internationals/football/men/5590.jpg" });
        players.Add(new Player() { Name = "Doki Lukebakio", ImageUrl = "" });
        players.Add(new Player() { Name = "Orel Mangala", ImageUrl = "" });
        players.Add(new Player() { Name = "Amadou Onana", ImageUrl = "" });
        players.Add(new Player() { Name = "Lois Openda", ImageUrl = "" });
        players.Add(new Player() { Name = "Matz Sels", ImageUrl = "" });
        players.Add(new Player() { Name = "Arthur Theate", ImageUrl = "" });
        players.Add(new Player() { Name = "Youri Tielemans", ImageUrl = "" });
        players.Add(new Player() { Name = "Zinho Vanheusden", ImageUrl = "" });
        players.Add(new Player() { Name = "Arthur Vermeeren", ImageUrl = "" });
        players.Add(new Player() { Name = "Jan Verthongen", ImageUrl = "" });

        ColViewPlayers.ItemsSource = players;
	}
}