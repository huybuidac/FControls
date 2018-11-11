using System;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace FControls.Form
{
    public class FDialog : FloatingPageBase
    {
        readonly Grid _mainLayout = new Grid() {
            VerticalOptions = LayoutOptions.FillAndExpand,
            HorizontalOptions = LayoutOptions.FillAndExpand
        };
        public FDialog()
        {
            Content = _mainLayout;
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
            if (propertyName == nameof(FloatingContent))
            {
                _mainLayout.Children.Add(FloatingContent);
                FloatingContent.VerticalOptions = LayoutOptions.Center;
                FloatingContent.HorizontalOptions = LayoutOptions.Center;
            }
        }
    }
}

