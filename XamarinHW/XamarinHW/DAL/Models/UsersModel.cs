using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinHW.DAL.Models
{
    public class UsersModel
    {
        [JsonProperty("data")]
        public List<UserInfo> UsersList { get; set; }
    }
}
