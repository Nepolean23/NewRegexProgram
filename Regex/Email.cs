using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexProgram
{
    public class RegexEmail
    {
        public string RegexOptions = "^[a-z]{3}[.]([a-z]{3})?@[a-z]{2}[.][a-z]{2}[.][a-z]{2}$";

        public void Email()
        {
            Console.WriteLine("Enter your Email_ID:");
            string Email_ID = Console.ReadLine();

            Regex rg = new Regex(RegexOptions);


            if (rg.IsMatch(Email_ID))
            {
                Console.WriteLine("The Email_ID is valid");

            }
            else
            {
                Console.WriteLine("The Email_ID is invalid");
            }
        }
    }
}
