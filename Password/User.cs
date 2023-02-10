using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Password
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Login { get; set; }
        private string _password;
        public string Password
        {
            get { return _password; }
            set { _password = HashPassword(value); }
        }

        public string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public bool CheckPassword(string password)
        {
            return HashPassword(password) == _password;
        }

        public string CheckUser(User[] users, string login, string password)
        {
            foreach (User user in users)
            {
                if (user.Login == login && user.CheckPassword(password))
                {
                    return "User exists and password is correct."; ;
                }
            }
            return "User does not exist or password is incorrect.";
        }
    }
}


