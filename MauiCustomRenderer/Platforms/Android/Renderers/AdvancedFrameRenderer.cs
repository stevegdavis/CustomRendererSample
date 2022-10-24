using Android.Content;
using Android.Views;
using Microsoft.Maui.Controls.Handlers.Compatibility;
using XamarinCustomRenderer.Controls;

namespace XamarinCustomRenderer.Droid.Renderers;

public class AdvancedFrameRenderer : VisualElementRenderer<PressableView>
{
    public AdvancedFrameRenderer(Context context)
        : base(context)
    {
    }
}