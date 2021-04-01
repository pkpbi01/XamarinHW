using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using XamarinHW.DAL.Models;

namespace XamarinHW.DAL.Services
{
    public class UserService
    {
        private readonly HttpClient _httpClient;
        private const string BaseURL = "https://reqres.in/api";

        public UserService()
        {

            _httpClient = new HttpClient();
        }

        public async Task<UsersModel> GetUsersAsync()
        {
            var message = await _httpClient.GetAsync($"{BaseURL}/users?page=2");

            if (message.IsSuccessStatusCode)
            {
                var content = await message.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<UsersModel>(content);
            }
            return new UsersModel();
        }

        //public async Task<UsersModel> GetUsersAsync()
        //{
        //    var client = new HttpClient()
        //    {
        //        BaseAddress = new Uri("https://reqres.in/api")
        //    };

        //    var message = RestService.For<IUsersAPI>(client);
        //    var result = await message.GetUsersByRefit();
        //    return result;
        //}
    }
}
