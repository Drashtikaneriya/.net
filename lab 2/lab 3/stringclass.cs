using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2to4.lab_3
{
    internal class stringclass
    {
        public void display()
        {
            string str1 = "Hello World";
            string str2 = "hello world";

            Console.WriteLine("Original String: " + str1);

            // Length
            Console.WriteLine("Length: " + str1.Length);

            // ToUpper
            Console.WriteLine("ToUpper: " + str1.ToUpper());

            // ToLower
            Console.WriteLine("ToLower: " + str1.ToLower());

            // Equals
            Console.WriteLine("Equals (case-sensitive): " + str1.Equals(str2));

            // Compare
            Console.WriteLine("Compare: " + String.Compare(str1, str2)); 

            // Contains
            Console.WriteLine("Contains 'World': " + str1.Contains("World"));

            // IndexOf
            Console.WriteLine("Index of 'o': " + str1.IndexOf('o'));

            // Replace
            Console.WriteLine("Replace 'World' with 'C#': " + str1.Replace("World", "C#"));

            // Substring
            Console.WriteLine("Substring (6, 5): " + str1.Substring(6, 5));

            // Trim
            string str3 = "   Trim me   ";
            Console.WriteLine("Before Trim: '" + str3 );
            Console.WriteLine("After Trim: '" + str3.Trim());

            // Split
            string[] words = str1.Split(' ');
            Console.WriteLine("Split:");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            // Join
            string joined = String.Join("-", words);
            Console.WriteLine("Join with '-': " + joined);
        }
    }
}
