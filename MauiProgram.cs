﻿using Microsoft.Extensions.Logging;

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
            builder.Services.AddTransient<MainPage>();
            builder.Services.AddTransient<MainPage6>();
            builder.Services.AddTransient<SecondPage>();
            builder.Services.AddTransient<SecondPage6>();
            builder.Services.AddTransient<MainViewModel>();
            return builder.Build();
        }
    }
}
