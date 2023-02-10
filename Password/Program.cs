using Password;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Password
{
    internal class Program
    {
        static void Main(string[] args)
        {


            User[] users = new User[]
            {
                new User { FirstName = "Argishti", LastName = "Bejanyan", Age = 32, Login = "argishti", Password = "password1" },
                new User { FirstName = "Irina", LastName = "Safaryan", Age = 24, Login = "irina", Password = "password2" },
                new User { FirstName = "Rafayel", LastName = "Dallaqyan", Age = 45, Login = "rafayel", Password = "password3" }
            };

            User user = new User();
            Console.WriteLine(user.CheckUser(users, "argishti", "password1"));
            Console.WriteLine(user.CheckUser(users, "argishti", "password3"));
        }
    }
        
    }

