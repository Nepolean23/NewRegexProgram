using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexProgram
{
    public class RegexLastName
    {
        public string RegexOptions = "^[A-Z]{1}[a-z]+$";

        public void LastName()
        {
            Console.WriteLine("Enter your Lastname:");
            string lastname = Console.ReadLine();

            Regex rg = new Regex(RegexOptions);


            if (rg.IsMatch(lastname))
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
