using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexProgram
{
    public class PasswordCreation
    {
        public string RegexOptions = "^[A-Z]{1}?([.+-@])?([a-z]+)?([0-9]+)?([@])?([a-z]+)?[.][a-z]{3}?([,.])?([a-z]+)?$";

        public void Password()
        {
            Console.WriteLine("Enter your Password: ");
            string password = Console.ReadLine();

            Regex rg = new Regex(RegexOptions);


            if (rg.IsMatch(password))
            {
                Console.WriteLine("The Password is valid");

            }
            else
            {
                Console.WriteLine("The Password is invalid");
            }
        }


    }
}
