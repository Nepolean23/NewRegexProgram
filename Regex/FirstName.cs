using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexProgram
{
    public class RegexFirstname
    {
        public string RegexOptions = "^[A-Z]{1}[a-z]+$";

        public void FirstName()
        {
            Console.WriteLine("Enter your Firstname:");
            string firstname = Console.ReadLine();

            Regex rg = new Regex(RegexOptions);


            if (rg.IsMatch(firstname))
            {
                Console.WriteLine("The firstname is valid");

            }
            else
            {
                Console.WriteLine("The firstname is invalid");
            }
        }
    }
}
