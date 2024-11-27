namespace ShellTestMAUI9;

public partial class SecondPage : ContentPage
{
	public SecondPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..", true);
    }
}