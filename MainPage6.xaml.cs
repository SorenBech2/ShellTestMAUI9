namespace ShellTestMAUI9
{
    public partial class MainPage6 : ContentPage
    {
        private readonly MainViewModel _viewModel;

        public MainPage6(MainViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
            _viewModel = viewModel;
        }

        private async void GoToSecondPage_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"{nameof(SecondPage6)}", true);
        }
    }

}
