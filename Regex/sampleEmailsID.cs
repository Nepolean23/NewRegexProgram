using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexProgram
{
    internal class sampleEmailsID
    {
        public string RegexOptions = "^[a-z]{3}([.+-@])?([a-z]+)?([0-9]+)?([@])?([a-z]+)?[.][a-z]{3}([,.])?([a-z]+)?$";

            public void SampleEmail()
            {
                Console.WriteLine("Enter your Email: ");
                string Email = Console.ReadLine();

                Regex rg = new Regex(RegexOptions);


                if (rg.IsMatch(Email))
                {
                    Console.WriteLine("The Email is valid");

                }
                else
                {
                    Console.WriteLine("The Email is invalid");
                }
            }


        
    }
}
