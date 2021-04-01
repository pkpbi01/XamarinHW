using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamarinHW.DAL.Models;

namespace XamarinHW.DAL.Services
{
    public interface IUsersAPI
    {
        [Get("/users?page=2")]
        Task<UsersModel> GetUsersByRefit();
    }
}
