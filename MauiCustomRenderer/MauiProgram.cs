using Microsoft.Maui.Controls.Compatibility.Hosting;
using XamarinCustomRenderer.Controls;

namespace MauiCustomRenderer;

public static class MauiProgram
{
public static MauiApp CreateMauiApp()
{
	var builder = MauiApp.CreateBuilder();
	builder
		.UseMauiApp<App>()
		.UseMauiCompatibility()
		.ConfigureFonts(fonts =>
		{
			fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
		})
        .ConfigureMauiHandlers((handlers) =>{
#if ANDROID
			handlers.AddHandler(typeof(PressableView),typeof(XamarinCustomRenderer.Droid.Renderers.PressableViewRenderer));
            handlers.AddHandler(typeof(AdvancedFrame), typeof(XamarinCustomRenderer.Droid.Renderers.AdvancedFrameRenderer));
#endif

#if IOS
            handlers.AddHandler(typeof(PressableView), typeof(XamarinCustomRenderer.iOS.Renderers.PressableViewRenderer));
			handlers.AddHandler(typeof(AdvancedFrame), typeof(XamarinCustomRenderer.iOS.Renderers.AdvancedFrameRenderer));
#endif
        });

	return builder.Build();
}
}
