using System.Diagnostics;

namespace ShellTestMAUI9
{
    public partial class Page6 : ContentPage
    {

        public Page6()
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

        private async void GoToSecondPage_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"{nameof(SecondPage6)}", true);
        }
    }

}
