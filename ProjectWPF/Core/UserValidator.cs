using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWPF.Core
{
    public static class UserValidator
    {
        public static bool Validate(string login, string password) =>
            login.Equals("admin") && password.Equals("011974aa");
    }
}