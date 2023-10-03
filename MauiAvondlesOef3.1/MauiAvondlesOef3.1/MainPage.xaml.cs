namespace MauiAvondlesOef3._1;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

    

    private void SwSwitch_Toggled(object sender, ToggledEventArgs e)
    {
        //if (SwSwitch.IsToggled == true)
        //{
        //	EdEditor.Text = "Switch is toggled on (Retrun value true)";
        //}
        //else
        //{
        //	EdEditor.Text = "Switch is toggled off (Retrun value false)";
        //      }
        EdEditor.Text = string.Empty;
        EdEditor.Text = (SwSwitch.IsToggled) ? "Switch is toggled on (Return value true)" : "Switch is toggled off (Return value false)";
        AiActivityIndicator.IsRunning = (SwSwitch.IsToggled) ? true : false;
        PbProgressBar.Progress += 0.1D;
        if (PbProgressBar.Progress == 1)
            EdEditor.Text = "Progressbar is full!";
    }

    private void DpDatePicker_DateSelected(object sender, DateChangedEventArgs e)
    {
		EdEditor.Text = string.Empty;
        EdEditor.Text = DpDatePicker.Date.ToString();
    }

  
}

