using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinHW.ViewModels;

namespace XamarinHW
{
    public partial class PageForHttp : ContentPage
    {
        private readonly PageForHttpVM _pageForHttpVM;

        public PageForHttp()
        {
            InitializeComponent();
            _pageForHttpVM = new PageForHttpVM();
            this.BindingContext = _pageForHttpVM;
        }
    }
}