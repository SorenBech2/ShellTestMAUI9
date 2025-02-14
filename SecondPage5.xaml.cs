namespace ShellTestMAUI9;

public partial class SecondPage5 : ContentPage
{
    private readonly MainViewModel _viewModel;

    public SecondPage5(MainViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
        _viewModel = viewModel;
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..", true);
    }
}
