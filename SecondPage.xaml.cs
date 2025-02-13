using System.Diagnostics;

namespace ShellTestMAUI9;

public partial class SecondPage : ContentPage
{
	public SecondPage()
	{
		InitializeComponent();
	}

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
        Debug.WriteLine($"It gets to this!");
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        Debug.WriteLine($"... and this works fine.");

    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..", true);
    }
}