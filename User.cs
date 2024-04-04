using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_class
{
    public class User : IAccount
    {

        public string FullName;

        public string Email;

        public string Password;
        public User(string fullname,string email)
        {
            FullName= fullname;
            Email= email;   
        }


        public bool PasswordChecker(string password)
        {
           
            bool isValidPassword = false;

            do
            {
                Console.Write("Sifreni daxil edin: ");
                password = Console.ReadLine();

              
                if (password.Length < 8)
                {
                    Console.WriteLine("Sifre min 8 simvoldan ibaret olmalidi.");
                    continue;
                }

                bool hasUpperCase = false;
                bool hasLowerCase = false;
                bool hasDigit = false;

                
                foreach (char c in password)
                {
                    if (char.IsUpper(c))
                    {
                        hasUpperCase = true;
                    }
                    else if (char.IsLower(c))
                    {
                        hasLowerCase = true;
                    }
                    else if (char.IsDigit(c))
                    {
                        hasDigit = true;
                    }
                }

               
                if (!hasUpperCase)
                {
                    Console.WriteLine("Sifrede en azi 1 boyuk herf olmalidi.");
                    continue;
                }
                if (!hasLowerCase)
                {
                    Console.WriteLine("Sifrede en azi 1 kicik herf olmalidi.");
                    continue;
                }
                if (!hasDigit)
                {
                    Console.WriteLine("Sifrede en azi 1 reqem olmalidi.");
                    continue;
                }

              
                isValidPassword = true;

            } while (!isValidPassword);

            Console.WriteLine("Sifre Ugurla qebul olundu.");

            return true;
        }

        public void ShowInfo()
        {
            Console.WriteLine("FullName:"+FullName);
            Console.WriteLine("Email:"+Email);
        }
    }
    interface IAccount
    {
        public bool PasswordChecker(string password);


        public void ShowInfo();
       
    }
}
