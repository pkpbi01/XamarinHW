using Refit;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using XamarinHW.DAL.Models;

namespace XamarinHW.DAL.Services
{
    public class PersonService
    {
        public async Task<PersonInfo> GetPersonAsync()
        {
            var client = new HttpClient()
            {
                BaseAddress = new Uri("https://swapi.dev/api")
            };

            var message = RestService.For<IPersonAPI>(client);
            var result = await message.GetPersonByRefit();
            return result;
        }
    }
}
