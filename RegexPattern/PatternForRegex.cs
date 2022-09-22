using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPattern
{
    public class PatternForRegex
    {
        public static void ValidFirstName()
        {
            Console.WriteLine("Enter first name:");
            string fname=Console.ReadLine();

            string pattern = "^[A-Z]{1}[a-z]{2,8}$";

            if (Regex.IsMatch(fname, pattern))
            {
                Console.WriteLine("Valid First Name");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        
        }

    }
}
