using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinHW.ViewModels;

namespace XamarinHW.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HttpPage : ContentPage
    {
        private readonly PageForHttpVM _pageForHttpVM;

        public HttpPage()
        {
            InitializeComponent();
            _pageForHttpVM = new PageForHttpVM();
            this.BindingContext = _pageForHttpVM;
        }
    }
}