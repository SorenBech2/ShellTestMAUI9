using System.Diagnostics;

namespace ShellTestMAUI9;

public partial class SecondPage6 : ContentPage
{
    public SecondPage6()
    {
        InitializeComponent();
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
        Debug.WriteLine($"It never gets to this!");
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        Debug.WriteLine($"... but this works fine.");

    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..", true);
    }
}
