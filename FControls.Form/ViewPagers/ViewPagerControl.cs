using System;
using System.Collections;
using Xamarin.Forms;

namespace FControls.Form
{
    public class ViewPagerControl : View
    {
        public static readonly BindableProperty ItemsSourceProperty = BindableProperty.Create("ItemsSource", typeof(IEnumerable), typeof(ViewPagerControl), null);
        public static readonly BindableProperty ItemTemplateProperty = BindableProperty.Create("ItemTemplate", typeof(DataTemplate), typeof(ViewPagerControl), null);
        public static readonly BindableProperty PositionProperty = BindableProperty.Create("Position", typeof(int), typeof(ViewPagerControl), 0, BindingMode.TwoWay);
        public static readonly BindableProperty InfiniteProperty = BindableProperty.Create("Infinite", typeof(bool), typeof(ViewPagerControl), false);

        public IEnumerable ItemsSource
        {
            get { return (IEnumerable)GetValue(ItemsSourceProperty); }
            set { SetValue(ItemsSourceProperty, value); }
        }
        public DataTemplate ItemTemplate
        {
            get { return (DataTemplate)GetValue(ItemTemplateProperty); }
            set { SetValue(ItemTemplateProperty, value); }
        }
        public int Position
        {
            get { return (int)GetValue(PositionProperty); }
            set { SetValue(PositionProperty, value); }
        }
        public bool Infinite
        {
            get { return (bool)GetValue(InfiniteProperty); }
            set { SetValue(InfiniteProperty, value); }
        }

        public EventHandler<int> PositionChanged;
    }
}
