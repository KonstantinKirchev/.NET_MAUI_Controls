namespace _NET_MAUI_Controls.Pages;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void commonControlsButton_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new CommonControls());
	}

    private void actionControlsButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ActionControls());
    }
}
