using System;
using Xamarin.Forms;

namespace FControls.Form.Utils
{
    public interface IPlatformHelper
    {
        Size ScreenSize { get; }
        int NavigationHeight { get; }
        float DpToPixel(float dp);
        float PixelToDp(float px);
    }
}
