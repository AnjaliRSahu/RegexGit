using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPattern
{
    public class ValidEmail
    {
        
        public static void Email()
        {
            Console.WriteLine("Enter Email");
            string email=Console.ReadLine();
            string pattern2 = "^[a-zA-Z0-9]+(?:.[a-zA-Z0-9]+)*@[a-zA-Z0-9]+(?:.[a-zA-Z0-9]+)*$";

            if (Regex.IsMatch(email, pattern2))
            {
                Console.WriteLine("valid email");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
