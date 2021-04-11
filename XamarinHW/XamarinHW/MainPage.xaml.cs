using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinHW.Pages;
using XamarinHW.Resources;
using XamarinHW.ViewModels;

namespace XamarinHW
{
    public partial class MainPage : ContentPage
    {
        private readonly MainPageViewModel _viewModel;

        public MainPage()
        {
            InitializeComponent();
            _viewModel = new MainPageViewModel();
            this.BindingContext = _viewModel;

        }

        private async void Button_GoToHttpPage(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//HttpPage");
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var buttom = (Button)sender;
            await buttom.ScaleTo(0.9, 100);
            await buttom.ScaleTo(1, 100);
        }
    }
}
