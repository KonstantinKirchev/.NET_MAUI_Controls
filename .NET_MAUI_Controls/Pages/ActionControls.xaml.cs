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

	private void demoSearchBar_SearchButtonPressed(object sender, EventArgs e)
	{
        DisplayAlert("Coding Droplets", $"You've searched for \"{demoSearchBar.Text}\"", "OK");
    }

    private void facebookSwipeItem_Invoked(object sender, EventArgs e)
    {
        DisplayAlert("Coding Droplets", "You've clicked the Facebook button", "OK");
    }

    private void instagramSwipeItem_Invoked(object sender, EventArgs e)
    {
        DisplayAlert("Coding Droplets", "You've clicked the Instagram button", "OK");
    }

    private void twitterSwipeItem_Invoked(object sender, EventArgs e)
    {
        DisplayAlert("Coding Droplets", "You've clicked the Twitter button", "OK");
    }

    private void linkedInSwipeItem_Invoked(object sender, EventArgs e)
    {
        DisplayAlert("Coding Droplets", "You've clicked the LinkedIn button", "OK");
    }
}
