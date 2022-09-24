using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPattern
{
    public class ValidMobileNumber
    {
        public static void CheckMobileNumber()
        {
            Console.WriteLine("Enter Mobile Number");
            string num =Console.ReadLine();
            string pattern = "^91[ ][0-9]{10}$";
            //int p = Convert.ToInt32(pattern);

            try
            {
                if (Regex.IsMatch(num, pattern))
                {
                    Console.WriteLine("Valid Number");
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
