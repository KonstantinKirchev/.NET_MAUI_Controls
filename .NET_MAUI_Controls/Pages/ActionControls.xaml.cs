namespace _NET_MAUI_Controls.Pages;

public partial class ActionControls : ContentPage
{
	public ActionControls()
	{
		InitializeComponent();
	}

	private void demoButton_Clicked(object sender, EventArgs e)
	{
		DisplayAlert("Coding Droplets", "You've clicked the demo button", "OK");
	}

    private void demoImageButton_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Coding Droplets", "You've clicked the download button", "OK");
    }
}
