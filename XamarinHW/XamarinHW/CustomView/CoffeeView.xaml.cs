using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinHW.CustomView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CoffeeView : ContentView
    {
        public static BindableProperty ImageProperty =
    BindableProperty.Create(
        nameof(Image),
        typeof(string),
        typeof(CoffeeView),
        propertyChanged: ImagePropertyChanged);

        public string Image
        {
            get => (string)GetValue(ImageProperty);
            set => SetValue(ImageProperty, value);
        }
        private static void ImagePropertyChanged(BindableObject bindable, object oldvalue, object newvalue)
        {
            if (bindable is CoffeeView coffeeView)
            {
                //coffeeView.CoffeeImage = (string)newvalue;
            }
        }

        public static BindableProperty NameProperty =
            BindableProperty.Create(
                nameof(Name),
                typeof(string),
                typeof(CoffeeView),
                propertyChanged: NamePropertyChanged);
        public string Name
        {
            get => (string)GetValue(NameProperty);
            set => SetValue(NameProperty, value);
        }
        private static void NamePropertyChanged(BindableObject bindable, object oldvalue, object newvalue)
        {

        }

        public static BindableProperty MakerProperty =
            BindableProperty.Create(
                nameof(Maker),
                typeof(string),
                typeof(CoffeeView),
                propertyChanged: MakerPropertyChanged);
        public string Maker
        {
            get => (string)GetValue(MakerProperty);
            set => SetValue(MakerProperty, value);
        }
        private static void MakerPropertyChanged(BindableObject bindable, object oldvalue, object newvalue)
        {

        }

        public static BindableProperty PriceProperty =
            BindableProperty.Create(
                nameof(Price),
                typeof(string),
                typeof(CoffeeView),
                propertyChanged: PricePropertyChanged);
        public string Price
        {
            get => (string)GetValue(PriceProperty);
            set => SetValue(PriceProperty, value);
        }
        private static void PricePropertyChanged(BindableObject bindable, object oldvalue, object newvalue)
        {

        }

        public CoffeeView()
        {
            InitializeComponent();
        }
    }
}