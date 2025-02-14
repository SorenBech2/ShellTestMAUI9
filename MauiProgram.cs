using Microsoft.Extensions.Logging;

namespace ShellTestMAUI9
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddTransient<EmptyPage>()
                            .AddTransient<Page1>()
                            .AddTransient<Page3>()
                            .AddTransient<Page6>()
                            .AddTransient<SecondPage3>()
                            .AddTransient<SecondPage5>()
                            .AddTransient<SecondPage6>()
                            .AddTransient<MainViewModel>();

            return builder.Build();
        }
    }
}
