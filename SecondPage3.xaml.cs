using System.Diagnostics;

namespace ShellTestMAUI9;

public partial class SecondPage3 : ContentPage
{
	public SecondPage3()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        Debug.WriteLine($"OnAppearing works fine.");
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
        Debug.WriteLine($"... and it gets to OnNavigatedTo!");
    }


    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..", true);
    }
}