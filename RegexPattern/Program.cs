using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //checking for first name
            PatternForRegex.ValidFirstName();
            //checking for Last Name
            ValidLastName.LastName();
            //Checking for Email using NLog
            ValidEmail validEmail = new ValidEmail();
            validEmail.Email();
            
            //Checking for Mobile Number
            ValidMobileNumber.CheckMobileNumber();
            //Checking For Password
           Password.CheckPassword();

            Console.ReadLine();
        }
    }
}
