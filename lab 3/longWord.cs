using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2to4.lab_3
{
    internal class longWord
    {
        public void demo()
        {
            Console.Write("Enter a sentence: ");
            string input = Console.ReadLine();

            string[] words = input.Split(' ');
            string longest = "";

            foreach (string word in words)
            {
                if (word.Length > longest.Length)
                {
                    longest = word;
                }
            }

            Console.WriteLine("Longest word: " + longest);
        }
    }
}
