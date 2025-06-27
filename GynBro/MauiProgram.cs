using Microsoft.Extensions.Logging;

namespace GynBro
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

                    //font awesome
                    fonts.AddFont("FAB.ttf", "FAB");
                    fonts.AddFont("FAR.ttf", "FAR");
                    fonts.AddFont("FAS.ttf", "FAS");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
