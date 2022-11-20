using Maui.MultipleWindows.App.Services;
using Maui.MultipleWindows.App.View;
using Maui.MultipleWindows.App.ViewModel;

namespace Maui.MultipleWindows.App.Config;

public static class BuilderConfiguration
{
    public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder app)
    {
        app.Services.AddTransient<MainPageViewModel>();

        return app;
    }

    public static MauiAppBuilder RegisterViews(this MauiAppBuilder app)
    {
        app.Services.AddTransient<MainPage>();

        return app;
    }

    public static MauiAppBuilder RegisterServices(this MauiAppBuilder app)
    {
        app.Services.AddSingleton<PopupService>();

        return app;
    }

}
