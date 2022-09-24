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
        NLog log = new NLog();
        
        public  void Email()
        {
            Console.WriteLine("Enter Email");
            string email = Console.ReadLine();
            string pattern2 = "^[a-z-A-Z-0-9]{3,10}?[.,-,+]{0,1}?[0-9]{0,}[@][a-z-0-9]{1,}[.][a-z]{2,}?[.]{0,1}[a-z]{0,3}$";
            try
            {
                if (Regex.IsMatch(email, pattern2))
                {
                    log.LogDebug("valid email " +email);
                    Console.WriteLine("valid email");
                   
                }
                else
                {
                    Console.WriteLine("Invalid");
                    log.LogError("Invalid " +email);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
