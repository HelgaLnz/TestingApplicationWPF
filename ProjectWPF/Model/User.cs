using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWPF.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public User()
        {
            Id = default;
            Firstname = string.Empty;
            Middlename = string.Empty;
            Lastname = string.Empty;
            Login = string.Empty;
            Password = string.Empty;
            Email = string.Empty;
        }

        public User(int id, string firstname, string middlename, string lastname, string login, string password, string email)
        {
            Id = id;
            Firstname = firstname;
            Middlename = middlename;
            Lastname = lastname;
            Login = login;
            Password = password;
            Email = email;
        }
    }
}