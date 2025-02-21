using System.Diagnostics;

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

        protected override void OnNavigating(ShellNavigatingEventArgs args)
        {
            base.OnNavigating(args);
            Debug.WriteLine($"OnNavigating works fine.");
            if (args == null || args.Current == null || args.Target == null)
                return;
            Debug.WriteLine($"Coming from : {args.Current.Location.ToString()}");
            Debug.WriteLine($"Going to : {args.Target.Location.ToString()}");
        }
    }
}
