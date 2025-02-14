using System.Diagnostics;

namespace ShellTestMAUI9
{
    public partial class Page3 : ContentPage
    {
        private readonly MainViewModel _viewModel;
        
        public Page3(MainViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
            _viewModel = viewModel;
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

        private async void GoToSecondPage_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"{nameof(SecondPage3)}", true);
        }
    }

}
