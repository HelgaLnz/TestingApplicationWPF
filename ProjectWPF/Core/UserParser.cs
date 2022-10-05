using ProjectWPF.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWPF.Core
{
    public class UserParser
    {
        public static IEnumerable<User> Parse(string path)
        {
            foreach (var user in File.ReadAllLines(path).Skip(1))
            {
                string[] prop = user.Split(';');
                yield return new User(Convert.ToInt32(prop.GetValue(0)), prop.GetValue(2)?.ToString()!, prop.GetValue(1)?.ToString()!,
                    prop.GetValue(3)?.ToString()!, Convert.ToDateTime(prop.GetValue(4)), Convert.ToDecimal(prop.GetValue(5)),
                    prop.GetValue(6)?.ToString()!, prop.GetValue(7)?.ToString()!, prop.GetValue(8)?.ToString()!);
            }
        }
    }
}