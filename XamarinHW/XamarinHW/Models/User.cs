using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinHW.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Avatar { get; set; }

        public override bool Equals(object obj)
        {
            if(obj is User user)
            {
                return user.Id == Id
                    && user.Email == Email
                    && user.FirstName == FirstName
                    && user.LastName == LastName
                    && user.Avatar == Avatar;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
