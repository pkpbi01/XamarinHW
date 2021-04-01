using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinHW.Models;
using XamarinHW.Resources;

namespace XamarinHW.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand ChangeCoffeParametersCommand { get; set; }

        public ObservableCollection<CoffeePropertyModel> _properties;
        public ObservableCollection<CoffeePropertyModel> Properties
        {
            get => _properties;
            set
            {
                _properties = value;
                OnPropertyChanged(nameof(Properties));
            }
        }

        private CoffeePropertyModel _coffeePropertyModel;
        public CoffeePropertyModel CoffeePropertyModel
        {
            get => _coffeePropertyModel;
            set
            {
                _coffeePropertyModel = value;
            }
        }

        private CoffeModel _coffeModel;
        public CoffeModel CoffeModel
        {
            get => _coffeModel;
            set
            {
                _coffeModel = value;
            }
        }

        public MainPageViewModel()
        {
            ChangeCoffeParametersCommand = new Command(ChangeCoffeParameters);

            _coffeModel = new CoffeModel
            {
                Price = Strings.LblCoffePrice1,
                Name = Strings.LblCoffeName1,
                Maker = Strings.LblCoffeMaker1
            };
            Properties = new ObservableCollection<CoffeePropertyModel>
            {
                new CoffeePropertyModel()
                {
                    Picture = "coffeeBean.png",
                    Name = Strings.LabelProp1,
                    ButtonText = Strings.BtnProp1
                },
                new CoffeePropertyModel()
                {
                    Picture = "cup.png",
                    Name = Strings.LabelProp2,
                    ButtonText = Strings.BtnProp2
                },
                new CoffeePropertyModel()
                {
                    Picture = "fork_knife.png",
                    Name = Strings.LabelProp3,
                    ButtonText = Strings.BtnProp3
                },
                new CoffeePropertyModel()
                {
                    Picture = "barista.png",
                    Name = Strings.LabelProp4,
                    ButtonText = Strings.BtnProp4
                },
                new CoffeePropertyModel()
                {
                    Picture = "barista.png",
                    Name = Strings.LabelProp4,
                    ButtonText = Strings.BtnProp4
                }
            };
        }

        private void ChangeCoffeParameters()
        {
            if (CoffeModel.Price == Strings.LblCoffePrice1)
            {
                CoffeModel.Price = Strings.LblCoffePrice2;
                CoffeModel.Name = Strings.LblCoffeName2;
                CoffeModel.Maker = Strings.LblCoffeMaker2;
            }
            else if (CoffeModel.Price == Strings.LblCoffePrice2)
            {
                CoffeModel.Price = Strings.LblCoffePrice3;
                CoffeModel.Name = Strings.LblCoffeName3;
                CoffeModel.Maker = Strings.LblCoffeMaker3;
            }
            else if (CoffeModel.Price == Strings.LblCoffePrice3)
            {
                CoffeModel.Price = Strings.LblCoffePrice1;
                CoffeModel.Name = Strings.LblCoffeName1;
                CoffeModel.Maker = Strings.LblCoffeMaker1;
            }
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
