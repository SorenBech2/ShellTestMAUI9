namespace ShellTestMAUI9
{
    public partial class Page5 : ContentPage
    {
        private readonly MainViewModel _viewModel;
        
        public Page5(MainViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
            _viewModel = viewModel;
        }

        private async void GoToSecondPage_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"{nameof(SecondPage5)}", true);
        }
    }
}
