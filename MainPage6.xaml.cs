namespace ShellTestMAUI9
{
    public partial class MainPage6 : ContentPage
    {
        public MainPage6()
        {
            InitializeComponent();
        }

        private async void GoToSecondPage_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"{nameof(SecondPage6)}", true);
        }
    }

}
