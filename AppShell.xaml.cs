namespace ShellTestMAUI9
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(SecondPage3), typeof(SecondPage3));
            Routing.RegisterRoute(nameof(SecondPage5), typeof(SecondPage5));
            Routing.RegisterRoute(nameof(SecondPage6), typeof(SecondPage6));
        }
    }
}
