using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using FControlsDemo.Models;
using FControlsDemo.Views;
using FControlsDemo.ViewModels;
using System.Collections.ObjectModel;

namespace FControlsDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemsPage : ContentPage
    {
        public ObservableCollection<int> ListItems { get; set; }
        public int Position { get; set; }
        ItemsViewModel viewModel;

        public ItemsPage()
        {
            InitializeComponent();

            ListItems = new ObservableCollection<int>() { 0, 1, 2, 3, 4, 5, 6 };
            Position = 5;
            BindingContext = this;
        }

        void Handle_Add(object sender, System.EventArgs e)
        {
            ListItems.Insert(Position, ListItems.Count);
        }

        void Handle_Delete(object sender, System.EventArgs e)
        {
            ListItems.RemoveAt(Position);
        }
    }
}