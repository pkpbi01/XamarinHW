using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinHW.DAL.Services;
using XamarinHW.Models;

namespace XamarinHW.ViewModels
{
    public class PageForHttpVM 
    {
        public ObservableCollection<User> Users { get; set; }
        public Person Person { get; set; }

        public ICommand GetUsersCommand { get; set; }
        public ICommand GetPersonCommand { get; set; }

        private readonly UserService _userService;
        private readonly PersonService _personService;


        public PageForHttpVM()
        {
            Users = new ObservableCollection<User>();
            Person = new Person();
            GetUsersCommand = new Command(GetUsersCommandExecute);
            GetPersonCommand = new Command(GetPersonCommandExecute);
            _userService = new UserService();
            _personService = new PersonService();
        }

        private async void GetPersonCommandExecute()
        {
            var person = await _personService.GetPersonAsync();
            if(person != null)
            {
                Person.Name = person.Name;
                Person.Height = person.Height;
                Person.Mass = person.Mass;
                Person.HairColor = person.HairColor;
                Person.SkinColor = person.SkinColor;
                Person.EyeColor = person.EyeColor;
                Person.BirthYear = person.BirthYear;
                Person.Gender = person.Gender;
                Person.Homeworld = person.Homeworld;

            }
        }

        private async void GetUsersCommandExecute()
        {
            var model = await _userService.GetUsersAsync();
            if(model != null && model.UsersList != null)
            {
                foreach (var usersInfo in model.UsersList)
                {
                    Users.Add(new User
                    {
                        Avatar = usersInfo.Avatar,
                        Email = usersInfo.Email,
                        FirstName = usersInfo.FirstName,
                        LastName = usersInfo.LastName,
                        Id = usersInfo.Id
                    });
                }
            }

        }
    }
}
