using ProjectWPF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace ProjectWPF.Core
{
    public static class UserValidator
    {
        public static User Validate(string login, string password, string path) =>
           UserParser.Parse(path)?.FirstOrDefault(u => u.Login.Equals(login) && u.Password.Equals(password))!;
    }
}