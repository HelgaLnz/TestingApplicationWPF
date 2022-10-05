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
        public DateTime BornDate { get; set; }
        public decimal Salary { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public User()
        {
            Id = default;
            Firstname = string.Empty;
            Middlename = string.Empty;
            Lastname = string.Empty;
            BornDate = DateTime.UnixEpoch;
            Salary = decimal.Zero;
            Login = string.Empty;
            Password = string.Empty;
            Role = string.Empty;
        }

        public User(int id, string firstname, string middlename, string lastname,
            DateTime bornDate, decimal salary, string login, string password, string role)
        {
            Id = id;
            Firstname = firstname;
            Middlename = middlename;
            Lastname = lastname;
            BornDate = bornDate;
            Salary = salary;
            Login = login;
            Password = password;
            Role = role;
        }
    }
}