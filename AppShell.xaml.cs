namespace ShellTestMAUI9
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(SecondPage), typeof(SecondPage));
            Routing.RegisterRoute(nameof(SecondPage6), typeof(SecondPage6));
        }
    }
}
