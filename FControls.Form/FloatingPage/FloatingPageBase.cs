using System;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace FControls.Form
{
    public enum FloatingPosition
    {
        Custom,
        Center
    }

    [ContentProperty("FloatingContent")]
    public abstract class FloatingPageBase : ContentPage
    {
        public static readonly BindableProperty FloatingContentProperty = BindableProperty.Create(nameof(FloatingContent), typeof(View), typeof(ContentPage), null);
        public static readonly BindableProperty PositionProperty = BindableProperty.Create(nameof(Position), typeof(FloatingPosition), typeof(ContentPage), FloatingPosition.Center);

        public View FloatingContent
        {
            get { return (View)GetValue(FloatingContentProperty); }
            set { SetValue(FloatingContentProperty, value); }
        }
        public FloatingPosition Position
        {
            get { return (FloatingPosition)GetValue(PositionProperty); }
            set { SetValue(PositionProperty, value); }
        }

        protected override void LayoutChildren(double x, double y, double width, double height)
        {
            base.LayoutChildren(x, y, width, height);
        }
    }
}
