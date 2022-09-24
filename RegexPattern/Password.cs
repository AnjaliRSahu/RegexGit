using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPattern
{
    public class Password
    {
        public static void CheckPassword()
        {
            Console.WriteLine("Enter password");
            string password=Console.ReadLine();

            string pattern = "^+[A-Z-a-z-0-9-?(!,@,#,$,%,^,&,*)]{8,}$";
            if (Regex.IsMatch(password, pattern))
            {
                Console.WriteLine("Valid passsword");
            }
            else
            {
                Console.WriteLine("Invalid password");
            }

        }
    }
}
