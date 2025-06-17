using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2to4.lab_3
{
    internal class Vice_versa
    {
        public void demo() {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            string result = "";

            foreach (char c in input)
            {
                if (char.IsLower(c))
                    result += char.ToUpper(c);
                else if (char.IsUpper(c))
                    result += char.ToLower(c);
                else
                    result += c; // Non-alphabetic characters remain the same
            }

            Console.WriteLine("Converted string: " + result);
        } 
    }
    }

