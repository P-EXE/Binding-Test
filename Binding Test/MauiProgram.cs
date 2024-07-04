using Binding_Test.Pages;
using Binding_Test.ViewModels;
using Binding_Test.Views;
using Microsoft.Extensions.Logging;

namespace Binding_Test
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

      builder.Services.AddTransient<MainPage>();
      builder.Services.AddTransient<MainView>();
      builder.Services.AddTransient<MainVM>();

#if DEBUG
  		builder.Logging.AddDebug();
#endif

      return builder.Build();
    }
  }
}
