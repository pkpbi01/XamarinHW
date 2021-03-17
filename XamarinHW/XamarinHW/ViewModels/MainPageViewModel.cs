using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using XamarinHW.Models;
using XamarinHW.Resources;

namespace XamarinHW.ViewModels
{
    public class MainPageViewModel //: INotifyPropertyChanged
    {
        private CoffeModel _coffeModel;

        public CoffeModel CoffeModel
        {
            get => _coffeModel;
            set
            {
                _coffeModel = value;
                //OnPropertyChanged(nameof(CoffeModel.Price));
            }
        }

        public MainPageViewModel()
        {
            _coffeModel = new CoffeModel();
            _coffeModel.Price = Strings.LblCoffePrice1;
        }

        //public event PropertyChangedEventHandler PropertyChanged;

        //protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}
    }
}
