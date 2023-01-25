using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexProgram
{
    public class RegexPhonenumber
    {
        public string RegexOptions = "^[0-9]{2}[0-9]+$";

        public void Phonenumber()
        {
            Console.WriteLine("Enter your Phonenumber:");
            string Phonenumber = Console.ReadLine();

            Regex rg = new Regex(RegexOptions);


            if (rg.IsMatch(Phonenumber))
            {
                Console.WriteLine("The Phonenumber is valid");

            }
            else
            {
                Console.WriteLine("The Phonenumber is invalid");
            }
        }
    }
}
