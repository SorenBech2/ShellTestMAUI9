namespace ShellTestMAUI9
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }

        private async void GoToSecondPage_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"{nameof(SecondPage)}", true);
        }
    }

}
