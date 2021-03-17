using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinHW.Resources;
using XamarinHW.ViewModels;

namespace XamarinHW
{
    public partial class MainPage : ContentPage
    {
        private MainPageViewModel _viewModel;

        public MainPage()
        {
            InitializeComponent();
            _viewModel = new MainPageViewModel();
            this.BindingContext = _viewModel;
        }

        private void SizeOfCoffe_Clicked(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if(btn != null)
            {
                if(btn.Text == Strings.BtnProp4)
                {
                    btn.Text = Strings.BtnProp4_2;
                    _viewModel.CoffeModel.Price = Strings.LblCoffePrice2;
                } else if (btn.Text == Strings.BtnProp4_2)
                {
                    btn.Text = Strings.BtnProp4_3;
                    _viewModel.CoffeModel.Price = Strings.LblCoffePrice3;
                } else if(btn.Text == Strings.BtnProp4_3)
                {
                    btn.Text = Strings.BtnProp4;
                    _viewModel.CoffeModel.Price = Strings.LblCoffePrice1;
                }

            }
        }
    }
}
