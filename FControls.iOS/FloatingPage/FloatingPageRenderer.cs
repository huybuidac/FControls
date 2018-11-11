using System;
using CoreGraphics;
using FControls.FloatingPage;
using FControls.Form;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(FloatingPageBase), typeof(FloatingPageRenderer))]
namespace FControls.FloatingPage
{
    public class FloatingPageRenderer : PageRenderer
    {
        private UIViewController _parentModalViewController;

        public override void DidMoveToParentViewController(UIViewController parent)
        {
            base.DidMoveToParentViewController(parent);

            // Save modal wrapper from Xamarin.Forms
            _parentModalViewController = parent;

            // Set custom to be able to set clear background!
            parent.ModalPresentationStyle = UIModalPresentationStyle.Custom;
        }
        public override void ViewWillAppear(bool animated)
        {
            base.ViewDidAppear(false);
            if (_parentModalViewController != null)
            {
                // Clear background on parent modal wrapper!!
                _parentModalViewController.View.BackgroundColor = UIColor.Clear;
            }
            View.BackgroundColor = UIColor.Clear;
        }
        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(false);
            if (_parentModalViewController != null)
            {
                // Clear background on parent modal wrapper!!
                _parentModalViewController.View.BackgroundColor = UIColor.Clear;
            }
            View.BackgroundColor = UIColor.Clear;
        }
    }
}
