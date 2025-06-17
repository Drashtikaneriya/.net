using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2to4.lab_3
{
    internal class changecase
    {
      

        public void demo()
        {
            Console.Write("Enter a character: ");
            string input = Console.ReadLine();

            char ch1 = input[0];

            if (char.IsUpper(ch1))
                Console.WriteLine("Changed case: " + char.ToLower(ch1));
            else if (char.IsLower(ch1))
                Console.WriteLine("Changed case: " + char.ToUpper(ch1));
            else
                Console.WriteLine("Not a letter.");
        }
    }
    }
