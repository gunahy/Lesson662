using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson662
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.Email = "dddd";
            user.Login = "dd";
            Console.WriteLine(user.Email);
            Console.WriteLine(user.Login);  
            Console.ReadKey();
                        
        }
    }

    class User
    {
        private string login;
        private string password;
        private string email;
        private int age;

        public string Login {
            get { return login; }
            set { if (value.Length < 3)
                {
                    Console.WriteLine("Логин должен быть не менее 3 символов");
                }
                else { login = value; }
            }
        }
        public string Password { get; set; }
        public int Age {
            get { return age; }
            set { age = value; }
        }
        public string Email
        {
            get { return email; }
            set
            {
                if (value.Contains("@"))
                {
                    email = value;
                }
                else { Console.WriteLine("Ваш email введен некорректно"); }
            }
        }

        public User() { }
        public User(string login, string email)
        {
            this.Login = login;
            this.Email = email;
        }
    }
}
