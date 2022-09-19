using PRJS.Services;
using PRJS.ViewModels;
using Telerik.Maui.Controls.Compatibility;

namespace PRJS;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{

		var builder = MauiApp.CreateBuilder();
		builder
            .UseTelerik()
            .UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
        builder.Services.AddSingleton(new DatabaseService());
        builder.Services.AddSingleton(new GridViewModel());
        return builder.Build();
	}
}
