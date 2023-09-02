using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Base2022.DTO
{
    public class UserDto
    {
        public UserDto(string fullName, string email, string userName, DateTime dateCreated ,string role, string birthday, string mobile,string id=null)
        {
            Id = id;
            FullName = fullName;
            Email = email;
            UserName = userName;
            DateCreated = dateCreated;
            Role = role;
            Birthday = birthday; 
            Mobile = mobile;
        }
        public string Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public DateTime DateCreated { get; set; }
        public string Token { get; set; }

        public string Role { get; set; }

        public string Birthday { get; set; }
        public string Mobile { get; set; }
    }
}
