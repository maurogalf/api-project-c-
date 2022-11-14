using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_project
{
    public class User
    {
        public int Id ;
        public string Name ;
        public string LastName ;
        public string UserName ;
        public string Password ;
        public string Email ;

        public User (int id, string name, string lastName, string userName, string password, string email)
        {
            this.Id = id;
            this.Name = name;
            this.LastName = lastName;
            this.UserName = userName;
            this.Password = password;
            this.Email = email;
        }
    }
}
