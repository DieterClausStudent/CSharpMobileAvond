using System.Text;

namespace MauiAvondlesOef3._2;

public partial class MainPage : ContentPage
{
    StringBuilder sb = new StringBuilder();
     StringBuilder sb2 = new StringBuilder();
    double getal1;
    double getal2;

	public MainPage()
	{
		InitializeComponent();
	}
    private void Show()
    {
        LblResult.Text = sb.ToString();
    }
    private void Show2()
    {
       sb2.Append(sb.ToString());
        Show();
        sb.Clear();
        
    }
    private void BtnSix_Clicked(object sender, EventArgs e)
    {
        sb.Append("6");
        Show();
    }

    private async void BtnMaal_Clicked(object sender, EventArgs e)
    {
        try
        {
            getal1 = Convert.ToDouble(sb.ToString());

            sb.Append(" * ");
            Show2();
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", $"error met: {ex}", "ok");
        }
    }

    private void BtnSeven_Clicked(object sender, EventArgs e)
    {
        sb.Append("7");
        Show();
    }

    private void BtnEight_Clicked(object sender, EventArgs e)
    {
        sb.Append("8");
        Show();
    }

    private void BtnNine_Clicked(object sender, EventArgs e)
    {
        sb.Append("9");
        Show();
    }

    private async void BtnDelen_Clicked(object sender, EventArgs e)
    {
        try
        {
            getal1 = Convert.ToDouble(sb.ToString());

            sb.Append(" / ");
            Show2();
            sb.Clear();
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", $"error met: {ex}", "ok");
        }
    }

    private void BtnFour_Clicked(object sender, EventArgs e)
    {
        sb.Append("4");
        Show();
    }

    private void BtnFive_Clicked(object sender, EventArgs e)
    {
        sb.Append("5");
        Show();
    }

    private void BtnOne_Clicked(object sender, EventArgs e)
    {
        sb.Append("1");
        Show();
    }

    private void BtnTwo_Clicked(object sender, EventArgs e)
    {
        sb.Append("2");
        Show();
    }

    private void BtnThree_Clicked(object sender, EventArgs e)
    {
        sb.Append("3");
        Show();
    }

    private async void BtnMinus_Clicked(object sender, EventArgs e)
    {
        try
        {
            getal1 = Convert.ToDouble(sb.ToString());

            sb.Append(" - ");
            Show2();
        }       
         catch (Exception ex)
        {
            await DisplayAlert("Error", $"error met: {ex}", "ok");
        }
    
    }

    private void BtnZero_Clicked(object sender, EventArgs e)
    {
        sb.Append("0");
        Show();
    }

    private async void BtnPlus_Clicked(object sender, EventArgs e)
    {
        try
        {
            getal1 = Convert.ToDouble(sb.ToString());

            sb.Append(" + ");
            Show2();
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", $"error met: {ex}", "ok");
        }
    }

    private void BtnClear_Clicked(object sender, EventArgs e)
    {
        sb.Clear();
        sb2.Clear();
        LblResult.Text = string.Empty;
        getal1 = 0;
        getal2 = 0;
    }

    private async void BtnResult_Clicked(object sender, EventArgs e)
    {
        try
        {
            getal2 = Convert.ToDouble(sb.ToString());
            string test = sb2.ToString();
            if (test.Contains('+'))
                LblResult.Text = (getal1 + getal2).ToString();
            else if (test.Contains("-"))
                LblResult.Text = (getal1 - getal2).ToString();
            else if (test.Contains("*"))
                LblResult.Text = (getal1 * getal2).ToString();
            else if (test.Contains("/"))
                LblResult.Text = (getal1 / getal2).ToString();
        }
        catch(Exception ex)
        {
            await DisplayAlert("Error", $"error met: {ex}", "ok");
        }
        //string test = sb.ToString();
        //switch (test)
        //{
        //    case test.Contains("+") : LblResult.Text = (getal1 + getal2).ToString(); break;
        //    case test.Contains("-"): LblResult.Text = (getal1 - getal2).ToString(); break;
        //    case test.Contains("*"): LblResult.Text = (getal1 * getal2).ToString(); break;
        //    case test.Contains("/"): LblResult.Text = (getal1 / getal2).ToString(); break;
        //}
    }

    private void BtnClear_Clicked_1(object sender, EventArgs e)
    {
        if (sb.ToString().Length > 0)
        {
            sb.Length--;
            //sb.Remove(sb.Length - 1, 1);
            Show();
        }
        else if (sb.ToString().Length == 0)
            sb2.Length--;
           // sb2.Remove(sb2.Length - 1, 1);
        Show2();
    }
}

