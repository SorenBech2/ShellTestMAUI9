namespace ShellTestMAUI9;

public partial class SecondPage6 : ContentPage
{
	public SecondPage6()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..", true);
    }
}