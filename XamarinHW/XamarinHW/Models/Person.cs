using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace XamarinHW.Models
{
    public class Person : INotifyPropertyChanged
    {
        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        private string _height;
        public string Height
        {
            get => _height;
            set
            {
                _height = value;
                OnPropertyChanged(nameof(Height));
            }
        }
        private string _mass;
        public string Mass
        {
            get => _mass;
            set
            {
                _mass = value;
                OnPropertyChanged(nameof(Mass));
            }
        }
        private string _hairColor;
        public string HairColor
        {
            get => _hairColor;
            set
            {
                _hairColor = value;
                OnPropertyChanged(nameof(HairColor));
            }
        }
        private string _skinColor;
        public string SkinColor
        {
            get => _skinColor;
            set
            {
                _skinColor = value;
                OnPropertyChanged(nameof(SkinColor));
            }
        }
        private string _eyeColor;
        public string EyeColor
        {
            get => _eyeColor;
            set
            {
                _eyeColor = value;
                OnPropertyChanged(nameof(EyeColor));
            }
        }
        private string _birthYear;
        public string BirthYear
        {
            get => _birthYear;
            set
            {
                _birthYear = value;
                OnPropertyChanged(nameof(BirthYear));
            }
        }
        private string _gender;
        public string Gender
        {
            get => _gender;
            set
            {
                _gender = value;
                OnPropertyChanged(nameof(Gender));
            }
        }
        private string _homeworld;
        public string Homeworld
        {
            get => _homeworld;
            set
            {
                _homeworld = value;
                OnPropertyChanged(nameof(Homeworld));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public override bool Equals(object obj)
        {
            if(obj is Person person)
            {
                return person.Name == Name
                    && person.Height == Height
                    && person.Mass == Mass
                    && person.HairColor == HairColor
                    && person.SkinColor == SkinColor
                    && person.EyeColor == EyeColor
                    && person.BirthYear == BirthYear
                    && person.Gender == Gender
                    && person.Homeworld == Homeworld;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
