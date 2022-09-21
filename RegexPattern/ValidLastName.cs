using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPattern
{
    public class ValidLastName
    {
        public static void LastName()
        {
            Console.WriteLine("Enter Last Name");
            string lastname=Console.ReadLine();
                
            string pattern1 = "^[A-Z]{1}[a-z]{2,8}$";
            if (Regex.IsMatch(lastname, pattern1))
            {
                Console.WriteLine("Valid Last Name");
            }
            else 
            {
                Console.WriteLine("Invalid");
            
            }

        
        }
    }
}
