using Microsoft.Extensions.Logging;

namespace MauiAppEvento
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
                    fonts.AddFont("Poppins-Light.ttf", "Poppins-Light");
                    fonts.AddFont("Poppins-Medium.ttf", "Poppins-Medium");
                    fonts.AddFont("Poppins-Regular.ttf", "Poppins-Regular");
                    fonts.AddFont("Poppins-Semibold.ttf", "Poppins-Semibold");

                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
