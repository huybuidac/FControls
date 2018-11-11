using System;
using FControls.Form.Utils;
using UIKit;
using Xamarin.Forms;

namespace FControls.Utils
{
    public class PlatformHelper : IPlatformHelper
    {
        public Size ScreenSize {
            get {
                var height = UIScreen.MainScreen.Bounds.Height;
                var width = UIScreen.MainScreen.Bounds.Width;
                return new Size(width, height);
            }
        }

        public int NavigationHeight => 44;

        public float DpToPixel(float dp)
        {
            var convertValue = UIScreen.MainScreen.NativeBounds.Width / UIScreen.MainScreen.Bounds.Width;
            return (float)(dp * convertValue);
        }

        public float PixelToDp(float px)
        {
            var convertValue = UIScreen.MainScreen.NativeBounds.Width / UIScreen.MainScreen.Bounds.Width;
            return (float)(px / convertValue);
        }
    }
}
