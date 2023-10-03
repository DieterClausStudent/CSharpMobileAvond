namespace MauiAvondlesOef3._3;

public partial class MainPage : ContentPage
{


	public MainPage()
	{
		InitializeComponent();
		List<Person> list = new List<Person>();
		list.Add(new Person() { Name="Dieter Claus", City="Sint-Truiden", ImageUrl= "https://www.pxl.be/img/logo.png" });
        list.Add(new Person() { Name = "Frederik Claus", City = "Sint-Truiden", ImageUrl = "https://www.pxl.be/img/logo.png" });
        list.Add(new Person() { Name = "Katjana Struys", City = "Sint-Truiden", ImageUrl = "https://www.pxl.be/img/logo.png" });
        list.Add(new Person() { Name = "Arne Both", City = "Herk-De-Stad", ImageUrl = "https://www.pxl.be/img/logo.png" });
        list.Add(new Person() { Name = "Lola Claus", City = "Genk", ImageUrl = "https://www.pxl.be/img/logo.png" });
        list.Add(new Person() { Name = "Bertha Claus", City = "Hasselt", ImageUrl = "https://www.pxl.be/img/logo.png" });
        ColView.ItemsSource = list;
	}


}

