using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FControlsDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new TestDialog());
        }
    }
}