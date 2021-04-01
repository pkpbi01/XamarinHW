using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamarinHW.DAL.Models;

namespace XamarinHW.DAL.Services
{
    public interface IPersonAPI
    {
        [Get("/people/1/")]
        Task<PersonInfo> GetPersonByRefit();
    }
}
