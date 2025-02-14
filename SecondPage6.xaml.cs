using System.Diagnostics;

namespace ShellTestMAUI9;

public partial class SecondPage6 : ContentPage
{
    public SecondPage6()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        Debug.WriteLine($"OnAppearing works fine.");
        Debug.WriteLine($"... and below this line should be a line triggered by OnNavigatedTo.");
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
        Debug.WriteLine($"... but never gets to OnNavigatedTo!");
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..", true);
    }
}
