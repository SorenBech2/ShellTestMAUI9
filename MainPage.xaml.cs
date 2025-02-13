namespace ShellTestMAUI9
{
    public partial class MainPage : ContentPage
    {
        private readonly MainViewModel _viewModel;
        
        public MainPage(MainViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
            _viewModel = viewModel;
        }

        private async void GoToSecondPage_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"{nameof(SecondPage)}", true);
        }
    }

}
